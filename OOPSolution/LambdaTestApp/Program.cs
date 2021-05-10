using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething(string name);
        delegate string Concatenate(string[] arr);
        static void Main(string[] args)   //void는 return이 있대 값이 없음
        {
            DoSomething doit = (name) =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine($"{name}~!");
                //void이기 때문에 return생략 가능
            };
            string name = "Hugo";
            doit(name);

            Concatenate concat = (arr) =>
                           {
                               string result = "";
                               foreach (var item in arr)
                               {
                                   result += item;
                               }
                               return result;
                           };
            
            string[] strarr = { "아버지가", "방에", "들어가신다" };
            Console.WriteLine(concat(strarr));


            Func<int> func1 = () => 3;
            var val = func1();
            Console.WriteLine($"val의 값은{val}");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            Action<float> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };
            area(10);
        }
    }
}
