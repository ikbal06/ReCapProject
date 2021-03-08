using Business.CSS;
using System;

namespace Business.CCS
{
    class DataLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
