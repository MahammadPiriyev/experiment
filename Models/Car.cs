using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class NumberGenerator
    {
		private int myVar;

		public int MyNum
		{
			get { return myVar; }
			set
			{
				if (value == 50)
				{
					myVar = value;
				}; 
			}
		}

	}

}
