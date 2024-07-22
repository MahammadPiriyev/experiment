using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator Num = new NumberGenerator();

            while (true)
            {
                Console.WriteLine("Enter a number : ");
                Num.MyNum = int.Parse(Console.ReadLine());

                if (Num.MyNum == 50)
                {
                    Console.WriteLine("yes it s true!");
                    break;
                }
            }
        }
    }
}
