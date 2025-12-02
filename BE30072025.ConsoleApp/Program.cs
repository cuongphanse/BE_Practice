using DataAccess;
using DataAccess.Class;
using System;
using static DataAccess.Bai3;

namespace BE30072025.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;/////
			//DataAccess.Bai1 bai1 = new DataAccess.Bai1();
			//DataAccess.Bai2 bai2 = new DataAccess.Bai2();

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

			//try
			//{
			//	DataAccess.Bai3.UserInput("Day la mot chuot troi troi la dai...");
			//}
			//catch (DataTooLong e)
			//{
			//	Console.WriteLine($"Lỗi: {e.Message}");
			//}
			//catch (Exception other)
			//{
			//	Console.WriteLine($"Lỗi: {other.Message}");
			//}

			//Product product = new Product();
			//product.Id = 1;
			//product.Name = "Sản phẩm A";
			//product.category = new ProductCategory(1, "Danh mục A");
			//Console.WriteLine($"ID: {product.Id}, Tên: {product.Name}, Danh mục: {product.category.Name}");
			//string result = product.Display();
			//Console.WriteLine(result);
			//---------------------------------------------------------------------
			//var trangthai = 1;
			//if(trangthai == (int)TrangThaiSanPham.ChuaBan)
			//{
			//	Console.WriteLine("Sản phẩm chưa bán");
			//}
			//---------------------------------------------------------------------
			//var employeeManager = new EmployeeManager();
			//var result = employeeManager.EmployeeInsert("NV001", "Nguyen Van A", DateTime.Now);

			//PrintResult(result);

			//// Thêm nhân viên 2 failed
			//result = employeeManager.EmployeeInsert("<img", "Tran Thi B", DateTime.Now.AddDays(-10));
			//PrintResult(result);

			//// Thêm nhân viên 3
			//result = employeeManager.EmployeeInsert("NV003", "Le Van C", DateTime.Now.AddMonths(-1));
			//PrintResult(result);

			//// In danh sách nhân viên
			//employeeManager.ListEmployee();
			//-----------------------------------------------------------------
			//var path = "C:\\Users\\NCPC\\Desktop\\Book_Employee.xlsx";
			//var rs = employeeManager.Employee_Insert_FromExcelFile(path);
			//Console.WriteLine(rs);

			var xeBus = new Car(1, "Toyota", "Bus", "RED", 2025);
			xeBus.Display();
			Console.WriteLine("Cach khac lay nhan hieu {0}", xeBus.Brand);
		}
		static void PrintResult(int result)
		{
			switch (result)
			{
				case (int)EmployeeStatus.THANH_CONG:
					Console.WriteLine("Thêm nhân viên thành công!");
					break;
				case (int)EmployeeStatus.THAT_BAI:
					Console.WriteLine("Thêm nhân viên thất bại!");
					break;
				case (int)EmployeeStatus.TEN_NV_KHONG_HOP_LE:
					Console.WriteLine("Tên nhân viên không hợp lệ!");
					break;
				case (int)EmployeeStatus.MA_NV_KHONG_HOP_LE:
					Console.WriteLine("Mã nhân viên không hợp lệ!");
					break;
				case (int)EmployeeStatus.MA_NV_DA_TON_TAI:
					Console.WriteLine("Mã nhân viên đã tồn tại!");
					break;
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
