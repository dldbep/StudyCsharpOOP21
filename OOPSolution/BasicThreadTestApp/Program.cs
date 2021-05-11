using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dosomthing();
            Thread th1 = new Thread(Dosomthing);
            th1.Start();
            //th1.Join();     //스레드 종료 대기   보통 사용안함
            DoOtherthing();

            th1.Interrupt(); //스레드를 waitjoinsleep상태일때 중단메서드... 사용안함
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10);  //10ms 대기
            }
        }

        private static void Dosomthing()
        {
            for(int i =0; i<30;i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);  //10ms
            }
        }
    }
}
