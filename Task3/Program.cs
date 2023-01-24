using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++; 
            }
            while (b >= c)
            {
                b -= c;
                n++;
            }
            int i = 0;
            int number = 0;
            while (i < k)
            {
                i++;
                number += n;
            }
            Console.WriteLine("N= {0}", number);
            Console.ReadKey();
        }
    }
}
