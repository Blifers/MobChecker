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
        private string GoalPercentage; // ?


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
            Total += Convert.ToInt32(playerInfo[2]);
            Hunt += Convert.ToInt32(playerInfo[3]);
            Purchase += Convert.ToInt32(playerInfo[4]);
            Tier1Mob += Convert.ToInt32(playerInfo[5]);
            Tier2Mob += Convert.ToInt32(playerInfo[6]);
            Tier3Mob += Convert.ToInt32(playerInfo[7]);
            Tier4Mob += Convert.ToInt32(playerInfo[8]);
            Tier5Mob += Convert.ToInt32(playerInfo[9]);
            Tier1Purchase += Convert.ToInt32(playerInfo[10]);
            Tier2Purchase += Convert.ToInt32(playerInfo[11]);
            Tier3Purchase += Convert.ToInt32(playerInfo[12]);
            Tier4Purchase += Convert.ToInt32(playerInfo[13]);
            Tier5Purchase += Convert.ToInt32(playerInfo[14]);
            Points += Convert.ToInt32(playerInfo[15]);
        }

        public string FailureCheck(int days)
        {
            if ((Convert.ToDouble(Points) / days) < 6)
                return NickName + " - " + Convert.ToString(Points) + " очков. " +
                "1 лвл - " + Convert.ToString(Tier1Mob) + " шт. " +
                "2 лвл - " + Convert.ToString(Tier2Mob) + " шт. " +
                "3 лвл - " + Convert.ToString(Tier3Mob) + " шт. " + "\n";
            return "";
        }

    }
}
