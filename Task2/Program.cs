using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число");
            int s1 = 0;
            int s2 = 1;
            int i;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                {
                    s1 += i;
                }
                else if (i < 0)
                    {
                    s2 -= i;
                }
            }
            while (i != 0);
            if (s1 > s2)
            {
                Console.WriteLine("Количество положительных чисел большe");
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Количество отрицательных чисел больше");
            }
            Console.ReadKey();
        }
    }
}
