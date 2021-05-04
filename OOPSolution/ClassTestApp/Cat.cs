using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
       /* public string Name { get; set; }*/
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat() { /*nothing*/}
        public Cat(string name, string color, int age)
        {
            //initialization   초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public Cat (string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public Cat( string color, int age)
        {
            this.Age = age;
            this.Color = color;
        }

        public override void Sleep()
        {
           // base.Sleep();      있으면 부모의 Sleep()메소드 실행 이후 자식 클래스의 Sleep 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) zz잡니다.");
        }
        public void Meow()
        {
            Console.WriteLine($"{this.Color} {this.Name}, 야옹!");
        }

    }
}
