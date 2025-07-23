using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisTopics
{
    static class Operations
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
    static class Employee
    {
        static int id;
        static string name;
        public static void Get()
        {

        }
        static Employee() { }


    }
    class Program
    {
        static void Main()
        {
            Employee.Get();
            Console.WriteLine(Operations.Add(10, 90));
            Console.WriteLine(Math.Min(10,90));
        }
    }

}
