using System;
using System.Linq;

namespace hm_06_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line, separate words with blank space");
            string[] array = Console.ReadLine().Split(' ');

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Editted array:");

            for (int i = 0; i < array.Length; i++) 
            Console.WriteLine(array[i]);
            
            Console.ReadLine();
        }
    }
}

