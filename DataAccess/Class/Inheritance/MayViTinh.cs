using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Class.Inheritance
{
	public class MayViTinh
	{
		public string TenMay { get; set; }
		public string ChieuDai { get; set; }
		public string ChieuRong { get; set; }
		
		public void UpRam()
		{
			Console.WriteLine(ChieuDai);
			Console.WriteLine(ChieuRong);
			Console.WriteLine("Đã nâng cấp RAM cho máy tính.");
		}
	}
}
