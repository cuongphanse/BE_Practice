using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Class.Inheritance
{
	public class MayAsus : MayViTinh, IAnimal
	{
		// , Implement interface IAnimal
		// : ke thua MayViTinh
		public void Eat()
		{
			throw new NotImplementedException();
		}
	}
}
