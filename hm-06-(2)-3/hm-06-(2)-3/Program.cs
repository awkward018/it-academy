using System;
using System.Linq;

namespace hm_06_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line, separate words with blank space");
            string s1 = Console.ReadLine();

            int a = 0;
            Console.WriteLine("number of letters:");
            for (int i = 0; i < s1.Length; i++)
            {
                if ((s1[i] >= 'a' && s1[i] <= 'z') || (s1[i] >= 'A' && s1[i] <= 'Z'))
                    a++;
            }
            Console.WriteLine(a);

            int b = 0;
            Console.WriteLine("number of symbols:");
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ' ')
                    b++;

            }
            int c = (s1.Length) - a - b;
            Console.WriteLine(c);




            Console.ReadLine();
        }
    }
}

