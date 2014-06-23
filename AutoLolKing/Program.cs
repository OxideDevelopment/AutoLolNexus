using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SharpConfig;
using System.Windows.Forms;
using UpdaterLib;

namespace AutoLolNexus
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckForUpdates();

            while (true)
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName.Equals("League of Legends"))
                    {
                        //Load config.
                        var config = Configuration.Load("settings.ini");
                        var category = config["AutoLolNexus"];

                        var setup = category["Setup"].GetValue<bool>();
                        var server = category["Server"].Value;
                        var summonerName = category["SummonerName"].Value;

                        if (!setup)
                        {

                            var setupDialog = new Setup();
                            setupDialog.ShowDialog();

                            config["AutoLolNexus"]["Server"].Value = setupDialog.ServerName;
                            config["AutoLolNexus"]["SummonerName"].Value = setupDialog.SummonerName;
                            config["AutoLolNexus"]["Setup"].Value = "true";

                            config.Save(Environment.CurrentDirectory + "\\settings.ini");

                            server = setupDialog.ServerName;
                            summonerName = setupDialog.SummonerName;   

                        }

                        var lolNexus = new LolNexus(server, summonerName);
                        lolNexus.ShowDialog();
                        process.WaitForExit();
                    }
                }
            }
        }

        private static void CheckForUpdates()
        {
            Updater.UpdateAvailable("");
        }
    }
}
