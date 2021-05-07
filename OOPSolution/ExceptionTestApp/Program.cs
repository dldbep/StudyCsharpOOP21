using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작");
            int[] array = new int[5];
           
               
            try
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        array[i] = (i + 1);  //1,2,3,4,5
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"문제발생 : {ex.Message} 관리자에게 문의하세요 : Main(15~)");   //예외가 발생한 이유 설명                
                
                
               
            }
            Console.WriteLine("다른 로직 수행");

            int[] list = { 107, 108, 109 };
            try
            {
                string message =null;
                Console.WriteLine(message.Length);

                var result = list[1] / 0;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            /*catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");
                //indexoutofrange 예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");
                Console.WriteLine("입력 제대로 해라!");
            }*/
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");   //얘 하나로 퉁치기
            }
            finally
            {
                Console.WriteLine("Finally, 언제든지 실행됨");  //예외가 발생하든 발생하지 않든 실행된다
            }
            Console.WriteLine("다른 로직 수행");

        }
    }
}
