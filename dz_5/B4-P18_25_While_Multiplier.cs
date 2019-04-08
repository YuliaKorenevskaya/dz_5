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
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();
            int x = Convert.ToInt32(number);

            Console.WriteLine("Введите степень:");
            string power = Console.ReadLine();
            int y = Convert.ToInt32(power);
 
            int i = 1;
            int reply = x;

            if (y == 1)
            {
                reply = x;
                Console.WriteLine($"Ответ: {reply}");
            }

            if (y == 0)
            {
                reply = 1;
                Console.WriteLine($"Ответ: {reply}");
            }
            
            else
            {
                while (i <  y) 
                {
                    i++;              
                    reply = reply * x;

                    if (i == y)
                    {
                     Console.WriteLine($"Ответ: {reply}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
