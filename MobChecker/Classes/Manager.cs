using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobChecker.Classes
{
    class Manager
    {
        private List<PlayerHunt> Players = new List<PlayerHunt>();
        private bool Uploaded = false;
        public Manager()
        {
                
        }

        public string GetAllFailures()
        {
            string Report = "";

            foreach (var player in Players)
            {
                Report += player.FailureCheck(1);
            }
            return Report;
        }

        public bool UploadFile(string [] filenames)
        {
            int counter = 0;
            int amount = filenames.Length;
            PlayerHunt playerHunt;

            //For time
            if (Uploaded)
                return false;

            try
            {
                if (amount == 1)
                {
                    using (var reader = new StreamReader(filenames[0]))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            if (counter > 1)
                            {         
                                playerHunt = new PlayerHunt(values);
                                Players.Add(playerHunt);
                            }
                            counter++;
                        }
                    }
                    if (Players.Count > 0)
                        Uploaded = true;
                    return Uploaded;
                }
                else if (amount > 1)
                {
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при загрузке данных!");
                Uploaded = false;
            }
            return Uploaded;
        }
    }
}
