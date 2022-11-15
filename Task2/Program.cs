using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
         
        {
            string str = Console.ReadLine();
            str = str.Replace(" ", "").ToLower();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            if (str == str2)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }

            Console.ReadKey();
        }
    }
}
