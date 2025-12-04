using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.AbstractClass
{
	public class Bird : Animal
	{
	
		public override void Eat()
		{
			Console.WriteLine($"{name} is eating seeds.");
		}
		public override void MakeSound()
		{
			Console.WriteLine($"{name} says Chirp.");
		}
	}
}
