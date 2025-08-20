using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DataTooLong : Exception
	{
		const string erroMessage = "Dữ liệu quá dài";
		public DataTooLong() : base(erroMessage)
		{
		}
	}
}
