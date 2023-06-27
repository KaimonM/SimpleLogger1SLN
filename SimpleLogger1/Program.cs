using System;
using System.IO;


namespace SimpleLoggerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SimpleLoggerobj = new SimpleLogger { LogFilePath = @"c:/Projects/logger.txt" };

           bool success = SimpleLoggerobj.WriteToLog(DateTime.Now," " , SimpleLogger.Severity.Mid ); 
            if(success )
            {
                Console.WriteLine("The info was logged succesfully");
            }

            else
            {
                Console.WriteLine("Log failed");
            }

         

            


        }
    }
}

