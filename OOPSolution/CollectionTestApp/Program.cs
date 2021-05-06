using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 123;
            //object obj = (object) a;
            //Console.WriteLine("a의 타입 :" + a.GetType());
            //Console.WriteLine("obj의 타입 : " + obj.GetType());

            //string str = "문자얄임";
            //obj = str;

            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList();   // 사이즈 지정x
            list.Add(3);                //모든 형식은 object를 상속함
            list.Add(67);
            list.Add(24);
            list.Add(14);
            list.Add(1);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();    //원하는 대로 sort하려면 같은 타입이여야 한다
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
             }
            Console.WriteLine();

            list.Reverse();    //원하는 대로 sort하려면 같은 타입이여야 한다
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5); //인덱스 5지우기
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            list.Remove(5);  // 5라는 숫자 지우기
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);
            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치 : {index14}");

            int lstindex14 = list.LastIndexOf(14);
            Console.WriteLine($"14의 위치 : {lstindex14}");

            Console.WriteLine($"총 갯수 : {list.Count}");
            Console.WriteLine($"리스트의 마지막값 {list[list.Count-1]}");
        }
    }
}
