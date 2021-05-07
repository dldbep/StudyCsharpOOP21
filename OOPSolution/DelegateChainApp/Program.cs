using System;
using System.Reflection.Metadata.Ecma335;

namespace DelegateChainApp
{
    class Program
    {
        delegate int Calculatle(int a, int b); //대리자 선언

        static void Main(string[] args)
        {
           
            Calculatle calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a + b = {calc(3, 5)}");

            FireStation station = new FireStation();
            ThereIsFire firehouse = new ThereIsFire(station.Call119);
            firehouse += new ThereIsFire(station.ShotOut);
            firehouse += new ThereIsFire(station.Escape);
            //대리자 실행
            firehouse("우리집");

            ThereIsFire firewoorim = new ThereIsFire(station.Call119);
            firewoorim += new ThereIsFire(station.Escape);
            //대리자 실행
            firewoorim("우림라이온벨리");
        }
    }
}
