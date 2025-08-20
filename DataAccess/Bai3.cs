using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public static class Bai3
	{
		public static void UserInput(string s)
		{
			if(s.Length > 10) {
				Exception e = new DataTooLong();
				throw e; // Ném ra ngoại lệ nếu chuỗi quá dài
			}
		}
	}
}
