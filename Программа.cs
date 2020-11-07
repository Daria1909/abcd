using System;

namespace Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int i, j, k = 0;
            int[] arr = new int[N];

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] % 26 == 0)
                    {
                        k += 1;
                    }
                }
            }
            Console.WriteLine(k);
        }
    }
}
