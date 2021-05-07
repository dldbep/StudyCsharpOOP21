using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for(int i = 0; i<list.Length;i++)
            {
                list[i] = i + 1;
            }
            for(int i = 0; i<list.Length;i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<string> stlist = new MyList<string>();
            for (int i=0; i< stlist.Length;i++)
            {
                stlist[i] = "hello_" + (i + 1);
            }

            for(int i =0; i<stlist.Length; i++)
            {
                Console.Write($"{stlist[i]}\t");            //원래 배열이라 int만 들어가는데 다른 것도 사용할 수 있게 됨
            }

            MyList<object> objectlist = new MyList<object>();
            objectlist[0] = 111;
            objectlist[1] = 3.142f;
            objectlist[2] = "hello world";
            
            
        }
    }
}
