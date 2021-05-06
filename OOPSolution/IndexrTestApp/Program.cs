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
                list[i] = (i + 1); 
            }
            for (int i=0; i < list.Length;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
