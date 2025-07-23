using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc_Topics
{
    internal class A
    {
           public virtual  void Get()
        {
            Console.WriteLine("Inside Class A");
        }
    }
    class B : A
    {
        public override  void Get()
        {

            Console.WriteLine("Inside class B");
        }
    }
    class Program
    {
         static void Main()
        {
            //A a = new A();
            //a.Get();
            //B b = new B();
            //b.Get();
            //a = b;
            //a.Get();

        }
    }
}
