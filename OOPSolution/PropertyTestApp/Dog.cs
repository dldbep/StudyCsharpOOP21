using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        // private string name;
        //color생략

        public string Name { get; set; }
        public string color { get; set; } = "누렁";
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value<0)
                {
                    this.age = 1;
                }
                else if (value>15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }
        }
        /*
        public string GetName() { return this.name; }
        
        public void SetName(string name) { this.name = name; }

        //값을 사용
        public string GetAge() { return $"{this.age}세"; }
        //값을 설정
        public void SetAge(int age) {
            if(age<0)
            {
                this.age = 1;
            }
            else if (age >15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
            this.age = age; 
        }
        //bark등 시간상 생략   */
    }
}
