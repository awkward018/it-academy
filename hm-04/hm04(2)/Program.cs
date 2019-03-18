using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm04_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol");
            char symbol;
            symbol = char.Parse(Console.ReadLine());
            
            switch(symbol)
            {
                case char x when (symbol=='D') :
                    Console.WriteLine("Turn right");
                    break;
                case char x when (symbol == 'A'):
                    Console.WriteLine("Turn left");
                    break;
                case char x when (symbol == 'W'):
                    Console.WriteLine("Go up");
                    break;
                case char x when (symbol == 'S'):
                    Console.WriteLine("Go down");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}
