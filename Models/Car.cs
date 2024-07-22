using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    //Interface
    interface FirstInterface
    {
        void MyMethod();
    }

    interface SecondInterface
    {
        void MyOtherMethod();
    }

    class DemoClass : FirstInterface, SecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text ... ");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("Other some text ... ");
        }
    }
}
