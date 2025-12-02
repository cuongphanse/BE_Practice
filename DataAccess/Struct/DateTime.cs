using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Struct
{
	public class Bai6_DateTime
	{
		public static void DateTimeDemo()
		{
			Console.Write("Nhập ngày tháng năm (vd: 13/08/2002): ");
			string input = Console.ReadLine();

			try
			{
				// Parse chuỗi theo định dạng ngày/tháng/năm
				DateTime date = DateTime.ParseExact(input, "d/M/yyyy", CultureInfo.InvariantCulture);

				Console.WriteLine("Bạn đã nhập DateTime: " + date);
			}
			catch (FormatException)
			{
				Console.WriteLine("❌ Định dạng ngày không hợp lệ. Vui lòng nhập dạng dd/MM/yyyy");
			}
		}
	}
}
