using System;

namespace IndexrTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mylist 예제");
            MyList list = new MyList();

            for(int i=0;i<5 ;i++)   //1~5
            {
                list[i] = (i + 1);    //1~5 this[index] set
            }
            for (int i=0; i < list.Length;i++)
            {
                Console.WriteLine(list[i]);   //1~5 this[index] get
            }

            Console.WriteLine("Foreach 실행");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
