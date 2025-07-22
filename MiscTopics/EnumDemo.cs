using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    enum Choice : byte { Add = 1, Subtract, Product, Remainder };
    internal class EnumDemo
    {
        // WAP to take 2 numbers & choice
        // choice 1 > add 
        // 2 > -
        // 3 - product
        // 4 - remainder
        static void Main()
        {
            int num1, num2, ch;
            Console.WriteLine("enter num1");
            num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter choice");
            ch = byte.Parse(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1: Console.WriteLine(num1 + num2); break;
            //    case 2: Console.WriteLine(num1 - num2); break;
            //    case 3: Console.WriteLine(num1 * num2); break;
            //    case 4: Console.WriteLine(num1 % num2); break;
            //    default: Console.WriteLine("invalid choice");break;
            //}
            switch (ch)
            {
                case (int)Choice.Add: Console.WriteLine(num1 + num2); break;
                case (int)Choice.Subtract: Console.WriteLine(num1 - num2); break;
                case (int)Choice.Product: Console.WriteLine(num1 * num2); break;
                case (int)Choice.Remainder: Console.WriteLine(num1 % num2); break;
                default: Console.WriteLine("invalid choice"); break;
            }





        }
    }
}
