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
        private int Days;
        private string Dates;
        private List<string> Bots = new List<string>();
        private List<string> Twins = new List<string>();

        public Manager()
        {
                
        }

        private string GetDatePeriod()
        {
            string rtnValue;
            string[] datesArr = Dates.Split(',');

            if (datesArr.Length < 2)
                rtnValue = datesArr[0];
            else
                rtnValue = "Период отчета: с " + datesArr[0] + " по " + datesArr[datesArr.Length - 2];

            return rtnValue;
        }

        public void FormExcel()
        {
            SetStatuses();

            //Добавить проверки??
            Microsoft.Office.Interop.Excel.Application application;
            Microsoft.Office.Interop.Excel._Workbook workBook;
            Microsoft.Office.Interop.Excel._Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;

            int row = 4;

            try
            {
                application = new Microsoft.Office.Interop.Excel.Application();
                //application.Visible = true;

                workBook = application.Workbooks.Add();
                worksheet = workBook.ActiveSheet;

                worksheet.Cells[1, 1] = GetDatePeriod();
                worksheet.Cells[2, 1] = "Суммарно отчет за: " + Convert.ToString(Days) + " дней";

                worksheet.Cells[2, 5] = "0 Очков";
                worksheet.Cells[2, 6] = "2 Очка";
                worksheet.Cells[2, 7] = "2 Очка";
                worksheet.Cells[2, 8] = "4 Очка";
                worksheet.Cells[2, 9] = "4 Очка";

                worksheet.Cells[3, 2] = "IGG ID";
                worksheet.Cells[3, 3] = "Никнейм";
                worksheet.Cells[3, 4] = "Охота всего";
                worksheet.Cells[3, 5] = "Монстр 1";
                worksheet.Cells[3, 6] = "Монстр 2";
                worksheet.Cells[3, 7] = "Монстр 3";
                worksheet.Cells[3, 8] = "Монстр 4";
                worksheet.Cells[3, 9] = "Монстр 5";
                worksheet.Cells[3, 10] = "Очков всего";
                worksheet.Cells[3, 11] = "Дней";
                worksheet.Cells[3, 12] = "Очков в день";

                //Молодцы
                foreach (var player in Players)
                {
                    string[] values = player.GetExcelInfo();
                    if (player.GetStatus() == PlayerHunt.Status.Player && Convert.ToDouble(values[8]) / (double)Days >= 6)
                    {
                        worksheet.Cells[row, 2] = values[0];
                        worksheet.Cells[row, 3] = values[1];
                        worksheet.Cells[row, 4] = values[2];
                        worksheet.Cells[row, 5] = values[3];
                        worksheet.Cells[row, 6] = values[4];
                        worksheet.Cells[row, 7] = values[5];
                        worksheet.Cells[row, 8] = values[6];
                        worksheet.Cells[row, 9] = values[7];
                        worksheet.Cells[row, 10] = values[8];
                        worksheet.Cells[row, 11] = Convert.ToString(Days);
                        worksheet.Cells[row, 12] = Convert.ToDouble(values[8]) / (double)Days;

                        worksheet.get_Range("B" + row.ToString(), "L" + row.ToString()).Interior.Color = System.Drawing.Color.FromArgb(0, 255, 10);

                        row++;
                    }
                }
                //Двоешники
                foreach (var player in Players)
                {
                    string[] values = player.GetExcelInfo();
                    if (player.GetStatus() == PlayerHunt.Status.Player && Convert.ToDouble(values[8]) / (double)Days < 6)
                    {
                        worksheet.Cells[row, 2] = values[0];
                        worksheet.Cells[row, 3] = values[1];
                        worksheet.Cells[row, 4] = values[2];
                        worksheet.Cells[row, 5] = values[3];
                        worksheet.Cells[row, 6] = values[4];
                        worksheet.Cells[row, 7] = values[5];
                        worksheet.Cells[row, 8] = values[6];
                        worksheet.Cells[row, 9] = values[7];
                        worksheet.Cells[row, 10] = values[8];
                        worksheet.Cells[row, 11] = Convert.ToString(Days);
                        worksheet.Cells[row, 12] = Convert.ToDouble(values[8]) / (double)Days;

                        worksheet.get_Range("B" + row.ToString(), "L" + row.ToString()).Interior.Color = System.Drawing.Color.FromArgb(200, 36, 0);


                        row++;
                    }
                }
                //Твины
                foreach (var player in Players)
                {
                    if (player.GetStatus() == PlayerHunt.Status.Twin)
                    {
                        string[] values = player.GetExcelInfo();
                        worksheet.Cells[row, 1] = "Твин";
                        worksheet.Cells[row, 2] = values[0];
                        worksheet.Cells[row, 3] = values[1];
                        worksheet.Cells[row, 4] = values[2];
                        worksheet.Cells[row, 5] = values[3];
                        worksheet.Cells[row, 6] = values[4];
                        worksheet.Cells[row, 7] = values[5];
                        worksheet.Cells[row, 8] = values[6];
                        worksheet.Cells[row, 9] = values[7];
                        worksheet.Cells[row, 10] = values[8];
                        worksheet.Cells[row, 11] = Convert.ToString(Days);
                        worksheet.Cells[row, 12] = Convert.ToDouble(values[8]) / (double)Days;

                        row++;
                    }
                }
                //Боты
                foreach (var player in Players)
                {
                    if (player.GetStatus() == PlayerHunt.Status.Bot)
                    {
                        string[] values = player.GetExcelInfo();
                        worksheet.Cells[row, 1] = "Бот";
                        worksheet.Cells[row, 2] = values[0];
                        worksheet.Cells[row, 3] = values[1];
                        worksheet.Cells[row, 4] = values[2];
                        worksheet.Cells[row, 5] = values[3];
                        worksheet.Cells[row, 6] = values[4];
                        worksheet.Cells[row, 7] = values[5];
                        worksheet.Cells[row, 8] = values[6];
                        worksheet.Cells[row, 9] = values[7];
                        worksheet.Cells[row, 10] = values[8];
                        worksheet.Cells[row, 11] = Convert.ToString(Days);
                        worksheet.Cells[row, 12] = Convert.ToDouble(values[8]) / (double)Days;

                        worksheet.get_Range("B" + row.ToString(), "L" + row.ToString()).Interior.Color = System.Drawing.Color.FromArgb(128, 128, 128);

                        row++;
                    }
                }

                range = worksheet.get_Range("C1", "C1");
                range.EntireColumn.Font.Size = 14;

                range = worksheet.get_Range("A1", "M1");
                worksheet.get_Range("A1", "A2").Font.Bold = true;
                worksheet.get_Range("A2", "M2").Font.Bold = true;
                worksheet.get_Range("A2", "M2").Font.Size = 16;
                worksheet.get_Range("A3", "M3").Font.Bold = true;
                worksheet.get_Range("A3", "M3").Font.Size = 16;
                //worksheet.get_Range("A3", "M3").AutoFilter()
                range.EntireColumn.AutoFit();
                range.EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


                if (application.Visible == false)
                    application.Visible = true;

                application.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetAllFailures()
        {
            string Report = "";

            foreach (var player in Players)
            {
                Report += player.FailureCheck();
            }
            return Report;
        }

        public bool UploadFile(string [] filenames)
        {
            int amount = filenames.Length;

            string[] filename;
            //Временно
            if (Uploaded)
                return false;

            Days = amount;

            try
            {
                if (amount == 1)
                {
                    FillClasses(filenames[0]);

                    filename = filenames[0].Split('\\');
                    Dates += filename[filename.Length - 1].Substring(0, 5) + ",";
                    if (Players.Count > 0)
                        Uploaded = true;
                    
                    return Uploaded;
                }
                else if (amount > 1)
                {
                    FillClasses(filenames[0]);
                    filename = filenames[0].Split('\\');
                    Dates += filename[filename.Length - 1].Substring(0, 5) + ",";
                    for (int i = 1; i < amount; i++)
                    {
                        AddToClasses(filenames[i], Players);
                        filename = filenames[i].Split('\\');
                        Dates += filename[filename.Length - 1].Substring(0, 5) + ",";
                    }

                    if (Players.Count > 0)
                        Uploaded = true;

                    return Uploaded;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка при загрузке данных!");
                Uploaded = false;
            }
            return Uploaded;
        }

        private void FillClasses(string filename)
        {
            int counter = 0;
            PlayerHunt playerHunt;

            using (var reader = new StreamReader(filename))
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
        }

        private void AddToClasses(string filename,List<PlayerHunt> players)
        {
            int counter = 0;
            bool playerFound = false;
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    foreach (var player in players)
                    {
                        if (counter > 1)
                        {
                            if (Convert.ToInt64(values[0]) == player.GetID())
                            {
                                player.AddData(values);
                                playerFound = true; 
                            }
                        }
                    }
                    if (playerFound == false && counter > 1)
                    {
                        PlayerHunt playerHunt = new PlayerHunt(values);
                        Players.Add(playerHunt);
                    }
                    playerFound = false;
                    counter++;
                }
            }
        }

        public string GetMobInfo(string NickName)
        {
            PlayerHunt ph = Players.Find(x => x.GetNickName() == "ByyDu");
            string rtnValue = "";

            if (ph != null)
                rtnValue = ph.GetMobInfo();

            return rtnValue;
        }

        public bool UploadTwinBots()
        {
            using (var reader = new StreamReader("BotsAndTwins.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var BotsAndTwins = line.Split(':');
                    var bots = BotsAndTwins[0].Split(',');
                    var twins = BotsAndTwins[1].Split(',');

                    foreach (var bot in bots)
                    {
                        Bots.Add(bot);
                    }
                    foreach (var twin in twins)
                    {
                        Twins.Add(twin);
                    }
                }
            }
            return true;
        }

        private void SetStatuses()
        {
            foreach (var player in Players)
            {
                PlayerHunt.Status status = PlayerHunt.Status.Player;
                foreach (var bot in Bots)
                {
                    if (player.GetID().ToString() == bot)
                        status = PlayerHunt.Status.Bot;
                }
                if (status == PlayerHunt.Status.Bot)
                    player.SetStatus(status);
                else
                {
                    foreach (var twin in Twins)
                    {
                        if (player.GetID().ToString() == twin)
                            status = PlayerHunt.Status.Twin;
                    }
                    player.SetStatus(status);
                }
            }

        }
    }

}

