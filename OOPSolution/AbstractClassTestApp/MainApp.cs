using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Delived();
            obj.PublicMethod();
            obj.AbstractMethod();
        }
    }
}
