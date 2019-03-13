﻿using System;
using System.IO;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // monitor 객체는 애플리케이션이 시작된 디렉토리에 Mylog.txt를 만들고 여기에 로그를 남깁니다.
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            //monitor.start();

            // 비타민 퀴즈 8-1
            ClimateMonitor monitor2 = new ClimateMonitor(new ConsoleLogger());
            monitor2.start();
        }
    }
}
