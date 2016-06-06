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
        //Create logfilename
        private static string _logFileName = string.Format("{0}:yyyymmddhhmmss", DateTime.Now);
        private static StreamWriter _streamLogWriter = null;
        
        //Create File   
        public static void CreateLogFile()
        {
            string dir = @"c:\SeleniumLibrary";
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
        //Write to logfile
        public static void Write(string logMessage)
        {
            _streamLogWriter.Write("{0} {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            _streamLogWriter.Write("        {0}", logMessage);
            _streamLogWriter.Flush();
        }
      }
 }