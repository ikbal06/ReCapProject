
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CSS
{
    class DataLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
