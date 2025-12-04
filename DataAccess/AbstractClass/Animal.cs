using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AbstractClass
{
	public abstract class Animal
	{
		public virtual string name { get; set; }
		public abstract void Eat();
		public abstract void MakeSound();

		public virtual void Display()
		{
			Console.WriteLine($"Animal Name: {name}");
		}
	}
}
