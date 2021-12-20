using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobChecker.Classes
{
    class PlayerHunt
    {
        private int Days = 0;

        public bool AddedInDay = false;

        private long UserID;
        private string NickName;
        private int Total;
        private int Hunt;
        private int Purchase;
        
        //Монстры 1-5 тира
        private int Tier1Mob;
        private int Tier2Mob;
        private int Tier3Mob;
        private int Tier4Mob;
        private int Tier5Mob;

        //Покупки 1-5 тира
        private int Tier1Purchase;
        private int Tier2Purchase;
        private int Tier3Purchase;
        private int Tier4Purchase;  
        private int Tier5Purchase;

        private int Points;
        private string GoalPercentage;

        public enum Status:int
        {
            Player = 1,
            Twin = 2,
            Bot = 3
        }

        private Status PlayerStatus;

        public PlayerHunt(string [] playerInfo)
        {
            FillData(playerInfo);
        }

        public PlayerHunt()
        {

        }

        public void FillData (string [] playerInfo)
        {
            FillClass(playerInfo);
        }

        private void FillClass(string[] playerInfo)
        {
            
            try
            {
                UserID = Convert.ToInt64(playerInfo[0]);
                NickName = playerInfo[1];
                
                Total = Convert.ToInt32(playerInfo[2]);
                Hunt = Convert.ToInt32(playerInfo[3]);
                Purchase = Convert.ToInt32(playerInfo[4]);
                Tier1Mob = Convert.ToInt32(playerInfo[6]);
                Tier2Mob = Convert.ToInt32(playerInfo[7]);
                Tier3Mob = Convert.ToInt32(playerInfo[8]);
                Tier4Mob = Convert.ToInt32(playerInfo[9]);
                Tier5Mob = Convert.ToInt32(playerInfo[10]);
                Tier1Purchase = Convert.ToInt32(playerInfo[12]);
                Tier2Purchase = Convert.ToInt32(playerInfo[13]);
                Tier3Purchase = Convert.ToInt32(playerInfo[14]);
                Tier4Purchase = Convert.ToInt32(playerInfo[15]);
                Tier5Purchase = Convert.ToInt32(playerInfo[16]);
                Points = Convert.ToInt32(playerInfo[18]);
                GoalPercentage = playerInfo[19];
                Days++;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddData(string [] playerInfo)
        {
            long userID = Convert.ToInt64(playerInfo[0]);

            if (UserID != userID)
                return;
            else
                AddHuntStats(playerInfo);
        }

        private void AddHuntStats(string [] playerInfo)
        {          
            try
            {
                Total += Convert.ToInt32(playerInfo[2]);
                Hunt += Convert.ToInt32(playerInfo[3]);
                Purchase += Convert.ToInt32(playerInfo[4]);
                Tier1Mob += Convert.ToInt32(playerInfo[6]);
                Tier2Mob += Convert.ToInt32(playerInfo[7]);
                Tier3Mob += Convert.ToInt32(playerInfo[8]);
                Tier4Mob += Convert.ToInt32(playerInfo[9]);
                Tier5Mob += Convert.ToInt32(playerInfo[10]);
                Tier1Purchase += Convert.ToInt32(playerInfo[12]);
                Tier2Purchase += Convert.ToInt32(playerInfo[13]);
                Tier3Purchase += Convert.ToInt32(playerInfo[14]);
                Tier4Purchase += Convert.ToInt32(playerInfo[15]);
                Tier5Purchase += Convert.ToInt32(playerInfo[16]);
                Points += Convert.ToInt32(playerInfo[18]);
                if (!AddedInDay)
                    Days++;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string FailureCheck()
        {
            if ((Convert.ToDouble(Points) / Days) < 6)
                return GetMobInfo();
            return "";
        }

        public long GetID()
        {
            return UserID;
        }

        public string GetNickName()
        {
            return NickName;
        }

        public string GetMobInfo()
        {
            return NickName + " - " + Convert.ToString(Points) + " из " + Convert.ToString(6 * Days) + " очков. " +
            "1 лвл - " + Convert.ToString(Tier1Mob) + " шт. " +
            "2 лвл - " + Convert.ToString(Tier2Mob) + " шт. " +
            "3 лвл - " + Convert.ToString(Tier3Mob) + " шт. " + "За " + Convert.ToString(Days) + " дней.\n";
        }

        public string [] GetExcelInfo()
        {
            string[] rtnArray = new string[10];

            rtnArray[0] = Convert.ToString(UserID);
            rtnArray[1] = Convert.ToString(NickName);
            rtnArray[2] = Convert.ToString(Hunt);
            rtnArray[3] = Convert.ToString(Tier1Mob);
            rtnArray[4] = Convert.ToString(Tier2Mob);
            rtnArray[5] = Convert.ToString(Tier3Mob);
            rtnArray[6] = Convert.ToString(Tier4Mob);
            rtnArray[7] = Convert.ToString(Tier5Mob);
            rtnArray[8] = Convert.ToString(Points);
            rtnArray[9] = Convert.ToString(Days);

            return rtnArray;
        }

        public void SetStatus(Status status)
        {
            if (Status.Bot != status && Status.Twin != status)
                status = Status.Player;

            PlayerStatus = status;
        }

        public Status GetStatus()
        {
            if (PlayerStatus != Status.Player && PlayerStatus != Status.Bot && PlayerStatus != Status.Twin)
                return Status.Player;
            else
                return PlayerStatus;
        }

        public void ReCalcPoints()
        {
            Points = Tier1Mob * Properties.Settings.Default.FirstLvlPoints
                     + Tier2Mob * Properties.Settings.Default.SecondLvlPoints
                     + Tier3Mob * Properties.Settings.Default.ThirdLvlPoints
                     + Tier4Mob * Properties.Settings.Default.FourthLvlPoints
                     + Tier5Mob * Properties.Settings.Default.FifthLvlPoints;
        }
    }
}
