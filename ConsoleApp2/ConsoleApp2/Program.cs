using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;
            int sum1;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum");
            sum1 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            if
           (sum == sum1)
                Console.WriteLine("Right");
            else
            {
                Console.WriteLine("Wrong");
                if
                    (sum > sum1)
                    Console.WriteLine("Must be bigger");
                else
                    Console.WriteLine("Must be smaller");
            }

            Console.ReadLine();
        }
    }
}
