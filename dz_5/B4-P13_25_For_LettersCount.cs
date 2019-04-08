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
            Console.WriteLine("Введите слово");

            string word = Console.ReadLine();

            int counter = 0;

            char[] ar = word.ToCharArray();
            for (int i = 0; i < word.Length; ++i) 
            {
                if (ar[i] == 'а' || ar[i] == 'a')
                {
                  counter++;           
                }
                Console.WriteLine($"буква:  {ar[i]}");

            }

            Console.WriteLine($"Количество букв:  {counter}");
            Console.ReadKey();
        }
    }
}
