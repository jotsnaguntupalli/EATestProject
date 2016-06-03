using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImpromptuInterface.Dynamic;

namespace EATestProject
{
    public class LogHelper
    {
        //log file name (Global declaration)
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamLogWriter = null;

        //Create a file that can hold the log information
        public static void CreateLogFile()
        {
            string dir = @"c:\SeleniumLibrary\";
            if (Directory.Exists(dir))
            {
                
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamLogWriter = File.AppendText(dir + _logFileName + ".log");
            }
        }
        //Create a method that can write text in the log file
        public static void Write(string logMessage)
        {
            _streamLogWriter.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamLogWriter.WriteLine("   {0}", logMessage);
            _streamLogWriter.Flush();
        }
    }
}
