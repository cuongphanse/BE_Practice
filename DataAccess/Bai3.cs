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
		public struct Product
		{
			public int Id { get; set; } // get la cho phep lay du lieu tu thuoc tinh
			public string Name { get; set; } // set la cho phep gan gia tri cho thuoc tinh

			public ProductCategory category { get; set; } // Thuộc tính category kiểu ProductCategory
		  // phương thức (hàm)
		  // Hàm khởi tạo
		  // + Không có kiểu trả về, không có từ khóa return
		  // + Số lượng tham số bằng số lượng thuộc tính
		  // + Phải khởi tạo tất cả các thuộc tính của struct
		public Product(int _id, string _name, ProductCategory _category)
			{
				this.Id = _id; // this.Id là thuộc tính của struct Product
				this.Name = _name; // this.Name là thuộc tính của struct Product
				this.category = _category; // this.category là thuộc tính của struct Product
			}
			// Phương thức
			public string Display()
			{
				return Id.ToString();
			}
		}

		public struct ProductCategory { 			
			public int Id { get; set; }
			public string Name { get; set; }
			public ProductCategory(int _id, string _name)
			{
				this.Id = _id;
				this.Name = _name;
			}
		}

		public enum TrangThaiSanPham
		{
			ChuaBan = 1,
			DaBan = 2,
			HuyDon = 3,
			DaHuy = 4
		}
	}
}
