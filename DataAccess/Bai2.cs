using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class Bai2
	{
		public void TinhGiaiThua()
		{
			Console.Write("Nhập số nguyên dương n: ");
			var input = Console.ReadLine();
			var isValid = Common.ValidateDataStringInput.CheckValidNumber(input);
			if (!isValid)
			{
				Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng nhập một số nguyên dương.");
				return;
			}
			long giaiThua = 1;
			for (int i = 1; i <= int.Parse(input); i++)
			{
				giaiThua *= i;
			}
			Console.WriteLine($"Giai thừa của {input} là: {giaiThua}");
		}
		public void KiemTraNguyenTo()
		{
			Console.Write("Nhập số cần kiểm tra: ");
			var input = Console.ReadLine();

			if (!Common.ValidateDataStringInput.CheckValidNumber(input))
			{
				Console.WriteLine("Số nhập vào không hợp lệ!");
				return;
			}

			int n = int.Parse(input);
			if (n < 2)
			{
				Console.WriteLine($"{n} không phải là số nguyên tố.");
				return;
			}

			bool isPrime = true;
			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					isPrime = false;
					break;
				}
			}

			Console.WriteLine(isPrime
				? $"{n} là số nguyên tố."
				: $"{n} không phải là số nguyên tố.");
		}

		// Hàm kiểm tra số chẵn/lẻ
		public void KiemTraChanLe()
		{
			Console.Write("Nhập số cần kiểm tra: ");
			var input = Console.ReadLine();

			if (!Common.ValidateDataStringInput.CheckValidNumber(input))
			{
				Console.WriteLine("Số nhập vào không hợp lệ!");
				return;
			}

			int n = int.Parse(input);
			Console.WriteLine(n % 2 == 0 ? $"{n} là số chẵn." : $"{n} là số lẻ.");
		}

		
	}
}
