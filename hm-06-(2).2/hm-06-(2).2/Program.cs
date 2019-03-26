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
            int a = 0;
            int b = 0;
            
            string min = array.Min();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                    b = i;
            }


            string max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    a = i;
            }
            string x = array[a];
            array[a] = array[b];
            array[b] = x;
          
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

        
            Console.ReadLine();
        }
    }
}
