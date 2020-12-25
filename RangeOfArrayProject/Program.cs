
using System;

namespace RangeOfArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = -5, max = 15;
            RangeOfArray mas = new RangeOfArray
            {
                Subscript = min,
                Superscript = max
            };

            for (int i = min, j = 0; i <= max; i++, j++)
            {
                mas[i] = j;
            }
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine($"Элемент {i} = {mas[i]}");
            }
            mas[max + 1] = 10;
            mas[min - 1] = 10;
            Console.WriteLine(mas[max + 1]);
            Console.WriteLine(mas[min - 1]);
        }
    }
}
