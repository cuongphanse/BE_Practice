using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.HW_EmployerManager
{
	public class Worker : Employee
	{
		public string HoursWorked { get; set; }
		public Worker(string name, double salary, string hoursWorked) : base(name, salary)
		{
			HoursWorked = hoursWorked;
		}
		public override void DisplayInfo()
		{
			Console.WriteLine("=== Worker ===");
			Console.WriteLine($"Name: {Name}, Salary: {Salary}, Hours Worked: {HoursWorked}");
		}
	}
}
