using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length];  //5짜리 int배열
            //복사전
            Console.WriteLine("복사전 targetint값 ======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            
            CopyArray(sourceInt, targetInt);
            Console.WriteLine("복사후 targetint값 ======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            float[] sourcefloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetfloat = new float[sourcefloat.Length];
            //복사전
            Console.WriteLine("복사전 targetfloat값 ======>");
            foreach (var item in targetfloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourcefloat, targetfloat);
            Console.WriteLine("복사후 targetfloat값 ======>");
            foreach (var item in targetfloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            string[] sourcestring = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] targetstring = new string[sourcestring.Length];
            //복사전
            Console.WriteLine("복사전 targetstring값 ======>");
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray(sourcestring, targetstring);
            Console.WriteLine("복사후 targetstring값 ======>");
            foreach (var item in targetstring)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)  //static안에서 만들어지는 메소드는 static 사용
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
