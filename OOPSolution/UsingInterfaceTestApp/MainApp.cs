using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var moniter1 = new ExtendedMoniter(new ConsoleLogger(DateTime.Now));
            moniter1.PrintLog("콘솔로그입니다!");

            var moniter = new ExtendedMoniter(new FileLogger("210504.log"));
            moniter.PrintLog("로그내용입니다!");

            Thread.Sleep(1000); //시간 딜레이
            moniter.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램 종료");
        }
    }
}
