using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int step1 = 0;
            int step2 = 0;

            while (i < 25)
            {
                i++;
                Console.WriteLine($"Ход:{i}");

                Console.WriteLine("Первый игрок,введите число от 1 до 6:");
               // string number1 = Console.ReadLine();
               // int x = Convert.ToInt32(number1);

                Random rnd1 = new Random();
                int x = rnd1.Next(1, 6);
                step1 = step1 + x;
                Console.WriteLine($"Первый игрок - шаг: {step1}");

                Console.WriteLine("Второй игрок, введите число от 1 до 6:");
                //string number2 = Console.ReadLine();
                //int y = Convert.ToInt32(number2);

                Random rnd2 = new Random();
                int y = rnd2.Next(1, 6);
                step2 = step2 + y;
                Console.WriteLine($"Второй игрок - шаг: {step2}");              
            }
 
            Console.ReadKey();
        }
    }
}
