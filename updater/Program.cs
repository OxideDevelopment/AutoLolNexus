using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;

namespace updater
{
    class Program
    {
        private const string ProcessName = "AutoLolNexus.exe";

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                return; 
            }

            // check if the process is running
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Equals(ProcessName))
                {
                    process.Kill();
                }
            }

            File.Delete(ProcessName);

            var webClient = new WebClient();
            webClient.DownloadFile(args[0], ProcessName);

            Process.Start(ProcessName);

        }
    }
}
