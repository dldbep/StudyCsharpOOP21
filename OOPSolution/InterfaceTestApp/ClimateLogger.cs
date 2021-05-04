using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger   //Ver 1.0에서 개발
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();   //WriteError를 사용안함
        }

        public void WriteLog(string weather)
        {
            Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재 날씨 {weather}");
        }
    }
}
