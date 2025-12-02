using DataAccess.Struct;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class EmployeeManager
	{
		List<Employeer> empl = new List<Employeer>();
		public int EmployeeInsert(string EmployeeCodeInput, string EmployeeNameInput, DateTime StartDateInput)
		{
			var ketqua = 0;
			try
			{
				// kiểm tra dau vào
				if (!Common.ValidateDataStringInput.CheckValidString(EmployeeCodeInput)
					|| !Common.ValidateDataStringInput.CheckXSSInput(EmployeeCodeInput))
				{
					return ketqua = (int)EmployeeStatus.MA_NV_KHONG_HOP_LE;
				}
				if (!Common.ValidateDataStringInput.CheckValidString(EmployeeNameInput)
					|| !Common.ValidateDataStringInput.CheckXSSInput(EmployeeNameInput))
				{
					return ketqua = (int)EmployeeStatus.TEN_NV_KHONG_HOP_LE;
				}

				var isDuplicate = false;
				// check trùng lặp mã nhân viên
				for (int i = 0; i < empl.Count; i++)
				{
					if (empl[i].EmployeeCode == EmployeeCodeInput)
					{
						isDuplicate = true;
						break;
					}
				}

				if (isDuplicate)
				{
					return ketqua = (int)EmployeeStatus.MA_NV_DA_TON_TAI;
				}

				//C2
				//var isDup = empl.FindAll(e => e.EmployeeCode == EmployeeCodeInput).FirstOrDefault();
				//if (isDup.EmployeeCode != null)
				//{
				//	return ketqua = (int)EmployeeStatus.MA_NV_DA_TON_TAI;
				//}

				var new_empl = new Employeer
				{
					EmployeeCode = EmployeeCodeInput,
					EmployeeName = EmployeeNameInput,
					StartDate = StartDateInput
				};
				empl.Add(new_empl);
				ketqua = (int)EmployeeStatus.THANH_CONG;
				return ketqua;
			}
			catch (Exception ex)
			{

				throw new Exception("Loi ngoai le: " + ex.Message);
			}
		}

		public void ListEmployee()
		{
			foreach (var item in empl)
			{
				Console.WriteLine($"Mã nhân viên: {item.EmployeeCode}, Tên nhân viên: {item.EmployeeName}, Ngày vào công ty: {item.StartDate}");
			}
		}

		public string Employee_Insert_FromExcelFile(string filePath)
		{
			var ketqua = string.Empty;
			var errName = new StringBuilder();
			try
			{
				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Set license context for EPPlus

				using (var package = new ExcelPackage(new FileInfo(filePath)))
				{
					var worksheet = package.Workbook.Worksheets[0];
					int rowCount = worksheet.Dimension.Rows;
					int colCount = worksheet.Dimension.Columns;

					for (int row = 2; row <= rowCount; row++)
					{
						var code = worksheet.Cells[row, 1].Text?.Trim();
						var name = worksheet.Cells[row, 2].Text?.Trim();
						var startDate = worksheet.Cells[row, 3].Text?.Trim();

						if (!Common.ValidateDataStringInput.CheckValidString(code)
							|| !Common.ValidateDataStringInput.CheckXSSInput(code))
						{
							errName.AppendLine($"Code ở Hàng {row}, Cột 1 dữ liệu không hợp lệ");
							continue;
						}

						if (!Common.ValidateDataStringInput.CheckValidString(name)
							|| !Common.ValidateDataStringInput.CheckXSSInput(name))
						{
							errName.AppendLine($"Tên ở Hàng {row}, Cột 2 dữ liệu không hợp lệ");
							continue;
						}

						// TODO: insert DB hoặc xử lý
						ketqua += $"✔ Thêm thành công nhân viên: {code} - {name}\n";
					}

					if (errName.Length > 0)
					{
						return errName.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				return $"❌ Lỗi khi đọc file Excel: {ex.Message}";
			}
			return ketqua;
		}

	}
}