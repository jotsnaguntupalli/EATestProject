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
        //Create filename
        private static string _logFileName = string.Format("{0}:yyyymmddhhmmss", DateTime.Now);

        private static StreamWriter _streamLogWriter = null;

        // Create a file 
        public static void CreateFile()
        {
            var dir = @"c:\SeleniumLibrary";
            if (Directory.Exists(dir))
            {
                _streamLogWriter = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamLogWriter = File.AppendText(dir + _logFileName + ".log");
            }
        }
       // write to file
        public static void WriteToFile(string logmessage)
        {
            _streamLogWriter.Write("{0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            _streamLogWriter.Write(" {0}", logmessage);
            _streamLogWriter.Flush();
           
        }

    }
}