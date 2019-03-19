using System;

namespace hm_05_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            int[] data = new int[5];
            for (int i = 0; i < (data.Length - 1); i++) 
                data[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter place");
            n = int.Parse(Console.ReadLine());

            for (int j = (data.Length-1); j > (n-1); j--)
             data[j] = data[j - 1];
            data[n-1] = x;

            Console.WriteLine("data:");
            for (int j = 0; j < data.Length; j++)
                Console.WriteLine(data[j]);

            Console.ReadLine();
        }
    }
}
