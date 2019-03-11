using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            int result1;
            char @operator;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            @operator = char.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter result");
            result1 = int.Parse(Console.ReadLine());
            if
                (@operator == '+') 

                result = num1 + num2;
            else
                result = num1 - num2;
                    if
                   (result1 == result)
                        Console.WriteLine("Right");
                    else
                    {
                        Console.WriteLine("Wrong");
                        if
                            (result > result1)
                            Console.WriteLine("Must be bigger");
                        else
                            Console.WriteLine("Must be smaller");
                    }
                
            

                Console.ReadLine();
        }
    }
}
