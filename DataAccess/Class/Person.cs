using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Class
{
	public class Person
	{
		private int Id { get; set; } = 4;
		private string first_name { get; set; } = "Phan";
		private string last_name { get; set; } = "Dinh Tung";
		public string address { get; set; }

		public Person()
		{
		}


		public int GetId()
		{
			return Id;
		}

		public string GetFullName()
		{
			return $"{first_name} {last_name}";
		}
	}
}
