using System;

namespace hm_06
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter poem, separating lines with \";\"");
                string s1 = Console.ReadLine();
                string s2 = s1.Replace("o", "a");
                string[] array = s2.Split(";");

                for (int i = 0; i < array.Length; i++)
                    Console.WriteLine(array[i]);

                Console.ReadLine();

            
        }
    }
}
    

