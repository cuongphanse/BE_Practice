using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Class
{
	public class Car
	{
		// field
		//get de lay gia tri trong thuoc tinh 
		//set de gan gia tri cho thuoc tinh
		public int Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }
		// constructor
		// phuong thuoc khoi tao khong tham so
		public Car()
		{
		}
		// phuong thuc khoi tao co tham so
		public Car(int id, string brand, string model, string color, int year)
		{
			Id = id;
			Brand = brand;
			Model = model;
			Color = color;
			Year = year;
		}
		// phuong thuc hien thi thong tin xe	
		public void Display()
		{
			Console.WriteLine($"Car ID: {Id}, Brand: {Brand}, Model: {Model}, Color: {Color}, Year: {Year}");
		}

		public int Run(int distant)
		{
			return distant;
		}
	}
}
