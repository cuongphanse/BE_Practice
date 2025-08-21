using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
	public static class ValidateDataStringInput
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

		public static bool CheckValidString(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return false;
			}
			input = input.Trim();
			
			if(int.TryParse(input, out int num))
			{
				return false; // Nếu là số thì không hợp lệ
			}

			if(input.Length > 100)
			{
				return false; // Nếu độ dài vượt quá 100 ký tự thì không hợp lệ
			}

			//if(DateTime.TryParse(input, out DateTime date))
			//{
			//	return false; // Nếu là ngày tháng thì không hợp lệ
			//}

			return true;
		}

		public static bool CheckSpeacticalCharacter(string input)
		{
			var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
			if(!regexItem.IsMatch(input))
			{
				return false; // Nếu có ký tự đặc biệt thì không hợp lệ
			}
			return true; // Nếu không có ký tự đặc biệt thì hợp lệ
		}

		public static bool CheckXSSInput(string input)
		{
			try
			{
				// Danh sách các chuỗi nguy hiểm thường gặp trong XSS
				var listDangerousString = new List<string>
		{
			"<script", "<iframe", "<img", "<object", "<embed", "<applet", "<body", "onerror", "onload"
		};

				if (string.IsNullOrEmpty(input))
					return false;

				foreach (var dangerous in listDangerousString)
				{
					if (input.Trim().ToLower().IndexOf(dangerous) >= 0)
						return false; // Nếu chứa chuỗi nguy hiểm -> không hợp lệ
				}

				return true; // An toàn
			}
			catch (Exception)
			{
				return false; // Nếu có lỗi -> coi như không hợp lệ
			}
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