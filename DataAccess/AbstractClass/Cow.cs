using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AbstractClass
{
	public class Cow : Animal
	{
		public override void Eat()
		{
			Console.WriteLine($"{name} is eating grass.");
		}
		public override void MakeSound()
		{
			Console.WriteLine($"{name} says Moo.");
		}
	}
}
