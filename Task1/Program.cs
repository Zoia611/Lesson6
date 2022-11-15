using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] strArray = text.Split();
            string max = strArray[0];
            foreach (string item in strArray)
            {
                if (max.Length < item.Length)
                {
                    max = item;
                }
               
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
