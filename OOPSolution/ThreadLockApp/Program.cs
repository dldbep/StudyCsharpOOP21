﻿using System;
using System.Threading;

namespace ThreadLockApp
{
    class Counter
    {
        private object thislock = new object();

        private int counter = 1000;
        public void Run()
        {
            for (int i = 0; i < 10; i++)    
            {
                Thread th = new Thread(UnsafeCalc);   // 스레드 10개 생성
                th.Start();
            }
        }
        public void UnsafeCalc()
        {
            lock(thislock)  //lock을 통해서 동기화 다른 스레드가 접근 못하도록
            {
                counter++;
                Thread.Sleep(1);
                Console.WriteLine(counter);  
            }
            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Run();
        }
    }
}
