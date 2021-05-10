﻿using System;

namespace AttributeTestApp
{
    class Program
    {
        public class MyClass
        { 
         //Properties...

            [Obsolete("이 메서드는 폐기되었습니다. NewMethod()로 대체하세요.")]
            public void OldMethod() { Console.WriteLine("먼가를 한다."); }
            public void NewMethod() { Console.WriteLine("새로운 먼가를 한다."); }
            
            public int Plus(int a, int b) { return a + b; }
        }
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            mine.OldMethod();

            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
