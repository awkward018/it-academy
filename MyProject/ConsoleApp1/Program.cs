using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
