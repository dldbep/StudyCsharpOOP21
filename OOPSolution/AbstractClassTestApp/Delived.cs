using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Delived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.Abstractmethod");
            base.ProtectedMethod();
            
        }
    }
}
