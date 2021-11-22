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
            Console.WriteLine("Hello World!");
        }
    }
}
