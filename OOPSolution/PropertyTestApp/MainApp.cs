using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog baekgoo = new Dog();
            //baekgoo.SetAge(5);  //5살
            baekgoo.Name = "백구";

            //Console.WriteLine($"백구의 나이는  {baekgoo.GetAge()}");
            baekgoo.Age = 25000;
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}세");

            Dog streetdog = new Dog();
            Console.WriteLine($"{streetdog.Name}는 {streetdog.color}색입니다");

            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Age = 10;
            dog1.color = "노랑";

            Dog dog2 = new Dog()
            {
                Name = "깜둥이",
                Age = 5,
                color = "검정"
            };

            var myInstance = new { Name = "이승수", Age = 28 };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);   //한번쓰고 버림

        }
    }
}
