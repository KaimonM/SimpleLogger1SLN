using System;
using System.IO;

namespace SimpleLoggerr
{
    public class SimpleLogger
    {
        public string LogFilePath { get; set; }

        public enum Severity
        {
            VeryLow,
            Low,
            Mid,
            High,
            ExtremyHigh
        };

        public bool WriteToLog(DateTime eventTime, string whatHappened, Severity severityLevel)
        {
            try
            {
                var logStr = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}, {whatHappened}, {severityLevel}";

                using (StreamWriter writer = new StreamWriter(LogFilePath, true))
                {
                    writer.WriteLine($"({DateTime.Now.ToShortDateString()}, {DateTime.Now.ToLongTimeString()}, {whatHappened}, {severityLevel}");
                    
                    return true;

                }
            }
            catch
            {
                return false;
            }
        }
    }
}

