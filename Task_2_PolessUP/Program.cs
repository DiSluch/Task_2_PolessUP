using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int[] nums2 = new int[n];

            nums = nums2;

            Console.WriteLine("Введите целое число:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите {n} целых чисел:");          

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int j=1;

            for (int i = 0; i < n; i++)
            {
                for (; j < n; j++)
                {
                    if (nums[i] + nums2[j] == target)
                    {
                        Console.WriteLine($"[{i+1},{j+1}]");
                    }
                }
                j = 0;
            }

            Console.ReadKey();
        }
    }
}
