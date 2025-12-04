using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AbstractClass
{
	public class HinhVuong : HinhHoc
	{
		public double Canh { get; set; }
		public HinhVuong(double canh)
		{
			Canh = canh;
		}
		public override double TinhChuVi()
		{
			return 4 * Canh;
		}
		public override double TinhDienTich()
		{
			return Canh * Canh;
		}
	}
}



