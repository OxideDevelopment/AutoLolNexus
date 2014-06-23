using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net;

namespace UpdaterLib
{
    class Updater
    {

        public static string UpdateUrl { get; set; }
        public static string UpdateDownload { get; set; }

        public static bool UpdateAvailable(string version)
        {
            var webClient = new WebClient();
            string onlineVersion = webClient.DownloadString(UpdateUrl);

            return !onlineVersion.Equals(version);
        }

        public static void InstallUpdate()
        {
            Process.Start("updater.exe", UpdateDownload);
        }
    }
}
