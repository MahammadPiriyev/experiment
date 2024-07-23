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

            //for (int b = 0; b < 5; b++)
            //{
            //    Console.WriteLine("Mahammad Piriyev");
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Mahammad Piriyev");
            //    i++;
            //}

            bool BooleanValue = true;
            int i = 0;
            while (BooleanValue)
            {
                if (i < 5)
                {
                    Console.WriteLine("Mahammad Piriyev");
                }
                else
                {
                    break;
                }
                i++;
            }

            Console.WriteLine("YESS");
        }
    }
}
