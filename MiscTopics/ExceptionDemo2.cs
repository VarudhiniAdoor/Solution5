using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class Emp
    {
         static void Main()
        {
            int age=0;
            string name=string.Empty;
            try
            {
                Console.WriteLine("enter age");
                age = byte.Parse(Console.ReadLine());
                if (age < 20 || age > 30)
                {
                    throw new CustomException("Range for age is 20 to 30");
                }
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                if(name.Trim().Length < 10)
                {
                    throw new CustomException("Min 10 characters are needed");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Name is " + name);
        }
    }
}
