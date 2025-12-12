using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager
{
	public class CowManager : IAnimal
	{
		public void Eat()
		{
			Console.WriteLine("Con bò đang ăn cỏ...");
		}
	}
}
