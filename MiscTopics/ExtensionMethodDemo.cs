using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class A
    {
        public void Get1()
        {
            Console.WriteLine("Get1 of Actual class");
        }
    }

    // extension meethods
    static class ExtendedA
    {
        public static void Get2(this A a)
        {
            Console.WriteLine("Method Get2 has been added to class A");
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Get1();
            a.Get2();
        }

    }
}
