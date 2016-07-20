using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShervinShahrdar_GA_HW
{
    public static class Logger
    {
        public static StringBuilder results = new StringBuilder();
        public static BackgroundWorker RefToWorker;

        public static void AddResults(string s)
        {
             Logger.results.AppendLine(s);
        }

        public static void Info(string message)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd:hh:mm:ss");
            string log = string.Format("[{0}] {1}",now,message);
            RefToWorker.ReportProgress(1, log);
        }

        public static void GenerateFile()
        {
            string directory = Directory.GetCurrentDirectory();
            string fileName = @"\results.txt";
            string path = directory + fileName;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter file = new System.IO.StreamWriter( path))
            {
                file.Write(results.ToString());
            }
            Process.Start("results.txt");
        }
        

    }
}
