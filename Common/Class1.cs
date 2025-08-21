using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public static class ValidateData
	{
		public static bool CheckValidNumber(string number)
		{
			if (string.IsNullOrEmpty(number))
			{
				return false;
			}
			number = number.Trim();
			if (!int.TryParse(number, out int result))
			{
				return false;
			}
			int num = int.Parse(number);
			if (num > int.MaxValue || num < int.MinValue)
			{
				return false;
			}
			return true;
		}
		public static int Chia_cho_Khong()
		{
			try
			{
			int a = 10;
			int b = 0;	
				return a / b;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Lỗi: " + ex.Message);
			}
				return 0; // Hoặc xử lý lỗi theo cách khác
		}
	}
}
