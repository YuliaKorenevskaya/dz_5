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
            int number = 91;
            char[] ar = new char[26];
            for (int i = 0; i < 26; ++i) 
            {
                number--;

                char symbol = Convert.ToChar(number);

                Console.WriteLine($"{symbol}");

                number = Convert.ToInt32(symbol);

            }

            Console.ReadKey();
        }
    }
}
