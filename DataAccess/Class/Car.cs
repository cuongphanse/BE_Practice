using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Class
{
	public class Car
	{
		// Thuoc tinh
		public int Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public string Color { get; set; }
		public int Year { get; set; }

		// phuong thuc
		public Car()
		{

		}
		public Car(int  id, string brand, string model, string color, int year)
		{
			Id = id;
			Model = model;
			Brand = brand;
			Color = color;
			Year = year;
		}

		public void Display()
		{
			Console.WriteLine("Id {0}", Id);
			Console.WriteLine("Brand {0}", Brand);
			Console.WriteLine("Model {0}", Model);
			Console.WriteLine("Color {0}", Color);
			Console.WriteLine("Year {0}", Year);
		}
		public int Run(int distance)
		{
			return distance;
		}
	}
}
