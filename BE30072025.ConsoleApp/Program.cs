using DataAccess;
using System;

namespace BE30072025.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			DataAccess.Bai1 bai1 = new DataAccess.Bai1();
			DataAccess.Bai2 bai2 = new DataAccess.Bai2();

			//while (true) // Menu chính
			//{
			//	Console.WriteLine("\n===== MENU CHÍNH =====");
			//	Console.WriteLine("1. Tính toán cơ bản");
			//	Console.WriteLine("2. Bài toán số (giai thừa, nguyên tố, chẵn/lẻ)");
			//	Console.WriteLine("0. Thoát");
			//	Console.Write("Chọn chức năng: ");
			//	var choice = Console.ReadLine();

			//	switch (choice)
			//	{
			//		case "1":
			//			bai1.Run(); 
			//			break;
			//		case "2":
			//			SubMenu(bai2); // gọi menu con
			//			break;
			//		case "0":
			//			Console.WriteLine("Thoát chương trình...");
			//			return; // thoát hẳn
			//		default:
			//			Console.WriteLine("Lựa chọn không hợp lệ!");
			//			break;
			//	}
			//}
			//Common.ValidateData.Chia_cho_Khong
			try
			{
				DataAccess.Bai3.UserInput("Day la mot chuot troi troi la dai...");
			}
			catch (DataTooLong e)
			{
				Console.WriteLine($"Lỗi: {e.Message}");
			}
			catch (Exception other)
			{
				Console.WriteLine($"Lỗi: {other.Message}");
			}
		}

		// Menu con cho Bai2
		static void SubMenu(DataAccess.Bai2 bai2)
		{
			while (true)
			{
				Console.WriteLine("\n===== MENU BÀI TOÁN SỐ =====");
				Console.WriteLine("1. Tính giai thừa");
				Console.WriteLine("2. Kiểm tra số nguyên tố");
				Console.WriteLine("3. Kiểm tra chẵn/lẻ");
				Console.WriteLine("0. Quay lại menu chính");
				Console.Write("Chọn chức năng: ");
				var subChoice = Console.ReadLine();

				switch (subChoice)
				{
					case "1":
						bai2.TinhGiaiThua();
						break;
					case "2":
						bai2.KiemTraNguyenTo();
						break;
					case "3":
						bai2.KiemTraChanLe();
						break;
					case "0":
						Console.WriteLine("Quay lại menu chính...");
						return; // quay lại Main menu
					default:
						Console.WriteLine("Lựa chọn không hợp lệ!");
						break;
				}
			}
		}
	}
}
