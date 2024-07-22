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
            //Working with files
            string WritingFiles = "Hello Worlddddd";
            File.WriteAllText("filename.txt", WritingFiles);

            string ReadingText = File.ReadAllText("filename.txt");
            Console.WriteLine(ReadingText);

            File.Delete("filename.txt");


            DemoClass demo = new DemoClass();
            demo.MyMethod();
            demo.MyOtherMethod();
        }
    }
}
