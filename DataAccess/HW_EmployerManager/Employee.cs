using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.HW_EmployerManager
{
	public class Employee
	{
		public string Name { get; set; }
		public double Salary { get; set; }
		public Employee() { }
		public Employee(string name, double salary)
		{
			Name = name;
			Salary = salary;
		}
		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Employee Name: {Name}, Salary: {Salary}");
		}

	}
}
