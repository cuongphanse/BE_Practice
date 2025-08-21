using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class Bai1
	{
		public void Run()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			// Nhập số thứ nhất
			Console.Write("Nhập số thứ nhất: ");
			var input1 = Console.ReadLine();
			if (!int.TryParse(input1, out int number1))
			{
				Console.WriteLine("Giá trị nhập vào không hợp lệ!");
				return;
			}

			// Nhập số thứ hai
			Console.Write("Nhập số thứ hai: ");
			var input2 = Console.ReadLine();
			if (!int.TryParse(input2, out int number2))
			{
				Console.WriteLine("Giá trị nhập vào không hợp lệ!");
				return;
			}

			// Menu chọn phép toán
			Console.WriteLine("\nChọn phép toán:");
			Console.WriteLine("1. Cộng (+)");
			Console.WriteLine("2. Trừ (-)");
			Console.WriteLine("3. Nhân (*)");
			Console.WriteLine("4. Chia (/)");
			Console.Write("Nhập lựa chọn (1-4): ");
			var choice = Console.ReadLine();

			// Thực hiện phép toán
			switch (choice)
			{
				case "1":
					Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
					break;
				case "2":
					Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
					break;
				case "3":
					Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
					break;
				case "4":
					if (number2 != 0)
						Console.WriteLine($"{number1} / {number2} = {(double)number1 / number2}");
					else
						Console.WriteLine("Không thể chia cho 0!");
					break;
				default:
					Console.WriteLine("Lựa chọn không hợp lệ!");
					break;
			}
		}
	}
}
