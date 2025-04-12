using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть чотири цифри по черзі:");

            Console.Write("Цифра 1: ");
            int d1 = int.Parse(Console.ReadLine());

            Console.Write("Цифра 2: ");
            int d2 = int.Parse(Console.ReadLine());

            Console.Write("Цифра 3: ");
            int d3 = int.Parse(Console.ReadLine());

            Console.Write("Цифра 4: ");
            int d4 = int.Parse(Console.ReadLine());

            if (IsValidDigit(d1) && IsValidDigit(d2) && IsValidDigit(d3) && IsValidDigit(d4))
            {
                int result = d1 * 1000 + d2 * 100 + d3 * 10 + d4;
                Console.WriteLine($"Сформоване число: {result}");
            }
            else
            {
                Console.WriteLine("Будь ласка, вводьте лише окремі цифри від 0 до 9.");
            }





            
        }

        static bool IsValidDigit(int d)
        {
            return d >= 0 && d <= 9;
        }
    }





}