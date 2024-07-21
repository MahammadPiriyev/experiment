using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle newVehicle = new Vehicle();
            Console.WriteLine(newVehicle.BrandName);
            Console.WriteLine(newVehicle.ModelName);
            Console.WriteLine("Hi everyone !");
            Console.WriteLine("for pulling");
        }
    }
}
