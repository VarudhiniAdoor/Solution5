using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class ExceptionHandlingDemo
    {
        static void Main()
        {
            int num1;
            int[] num = new int[10];
            try
            {
                // open some database connection here
                // if some error comes, then your database connection will remain only
                // that can be closed in finally block

                Console.WriteLine("enter Num1");
                num1 = byte.Parse(Console.ReadLine());
                num[9] = 100;
                Console.WriteLine("Num1 is " + num1);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Please enter value in range");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("please enter a number only");
            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // this block is used for any cleanup activity
                // dispose the objects
                // close any open connections 
                Console.WriteLine("IN FINALLY BLOCK");
            }
        }
    }
}
