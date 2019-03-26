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
            int a=0;
            
            string max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    a = i;  
             }
          
            for (int i = 0; i < array.Length; i++)
            { if (i != a)
                    Console.WriteLine(array[i]);
           }



            Console.ReadLine();
        }
    }
}
