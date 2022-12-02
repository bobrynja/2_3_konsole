using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите границу A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите границу B: ");
                int B_original = Convert.ToInt32(Console.ReadLine());
                int B1 = B_original; int B2 = B_original;
                if (A > B_original) { Console.WriteLine("B должно быть больше A"); }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Цикл while");
                    while (A <= B1)
                    {
                        Console.WriteLine(Math.Pow(B1, 3));
                        B1--;
                    }
                    Console.WriteLine("----------------------------");

                    Console.WriteLine("Цикл do...while");
                    do
                    {
                        Console.WriteLine(Math.Pow(B2, 3));
                        B2--;
                    } while (A <= B2);
                    Console.WriteLine("----------------------------");

                    Console.WriteLine("Цикл for");
                    for (int i = B_original; A <= i; i--)
                    {
                        Console.WriteLine(Math.Pow(i, 3));

                    }
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            Console.ReadKey();
        }
    }
}
