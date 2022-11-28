using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 23. Вычислить частичную сумму рядаS=(1*3)/ 2 + (2 * 4) / 3 + (3 * 5) / 4 +⋯
Вычисление прекратить, когда сумма ряда станет больше 100. */


namespace Lab_3_1_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 2;
            double sum = 0;
            while (sum < 100)
            {
                sum += (n - 1) * (n + 1) / n;
                Console.WriteLine(n + " " + sum);                
                n++;
            }
            Console.ReadKey();
        }
    }
}
