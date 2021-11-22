using System;
using NLog.Web;
using System.IO;

namespace _netFinal
{
    class Program
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            logger.Info("Program started");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            logger.Info("Program ended");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
