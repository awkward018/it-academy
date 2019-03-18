using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            for (letter = '\u005A'; letter>='\u0041'; letter--)
            { Console.WriteLine(letter); }
            Console.ReadLine();
        }
    }
}
