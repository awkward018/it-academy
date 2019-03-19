using System;

namespace hm_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data_1 = new int[5];
            Random rand = new Random();
            Console.WriteLine("data_1:");
            for (int i = 0; i < data_1.Length; i++)
            {
                data_1[i] = rand.Next();
                Console.WriteLine(data_1[i]);
            }

            Console.WriteLine("Enter members of data_2");
            int[] data_2 = new int[5];
            for (int j = 0; j < data_2.Length; j++)
            {
                data_2[j] = int.Parse(Console.ReadLine());
            }

            int[] data_3 = new int[5];
            Console.WriteLine("data_3:");
            for (int k = 0, i = 0, j = 0; k < data_3.Length; k++, i++, j++)
            {
                data_3[k] = data_1[i] + data_2[j];
                Console.WriteLine(data_3[k]);
            }

            Console.ReadLine();
        }
    }
}
