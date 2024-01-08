using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            findFactor(10);
            Console.ReadKey();
        }
        static void findFactor(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
