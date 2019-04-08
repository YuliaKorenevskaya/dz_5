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
           Console.WriteLine("Введите слово:");
           string word = Console.ReadLine();
           char[] ar = word.ToCharArray();       
            for (int i = 0; i < ar.Length; i++)
            {       
                Console.WriteLine($"{ar[ar.Length-i-1]}");
            }

            Console.ReadKey();
        }
    }
}

