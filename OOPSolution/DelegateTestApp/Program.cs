using System;

namespace DelegateTestApp
{
    class Program
    {
        delegate int Calculator(int a, int b);
        static void Main(string[] args)
        {
            //일반적인 호출
            /*Calculator calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Plus(3, 5)}");
            Console.WriteLine($"3 / 5 = {calc.Divide(3, 5)}");

            //대리자 호출
            CalcDele callback;
            callback = new CalcDele(calc.Plus);
            Console.WriteLine($"3 + 5 = {callback(3, 5)}");
            callback = new CalcDele(calc.Multiply);
            Console.WriteLine($"3 + 5 = {callback(3, 5)}");*/

            //무명함수 표현  1 = 일반식
            /* calc = delegate (int a, int b);
             { 
            return a+b ;
            } */
            
            Calculator calc = (a, b) => a + b;
            
            Console.WriteLine($" a + b = {calc(3, 5)}");

        }
    }
}
