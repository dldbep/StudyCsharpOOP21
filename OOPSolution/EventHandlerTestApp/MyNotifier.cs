using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message); //대리자
    class MyNotifier
    {
        public event EventHandler SomethingHappend;
        public void Dosomething(int number)
        {
            int temp = number % 10;
            if(temp !=0 && temp % 3 ==0)
            {
                SomethingHappend($"짝\t ");
            }
            else
            {
                SomethingHappend($"{number}\t");
            }
        }
        
    }
}
