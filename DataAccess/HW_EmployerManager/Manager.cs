using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.HW_EmployerManager
{
	public class Manager : Employee
	{
		public string Department { get; set; }

		public Manager(string name, double salary, string department) : base(name, salary)
		{
			Department = department;
		}
		public override void DisplayInfo()
		{
			Console.WriteLine("=== Manager ===");
			Console.WriteLine($"Name: {Name}, Salary: {Salary}, Department: {Department}");
		}
	}
}
