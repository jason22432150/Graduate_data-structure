using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case1();
            //Case2();
            Console.ReadLine();
        }
        static void Case1()
        {
            for (int i = 1; i < 10; i += 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i:00} x {j:00}={i * j:00}\t");
                    Console.Write($"{i + 1:00} x {j:00}={(i + 1) * j:00}\t");
                    Console.WriteLine($"{i + 2:00} x {j:00}={(i + 2) * j:00}\t");
                }
                Console.WriteLine();
            }
        }
        static void Case2()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{j:0#} x {i:0#} = {i * j:0#}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
