using DataAccess.Class;
using DataAccess.Interface;
using DataAccess.RequestData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager
{
	public class ProductManager : IProductManager
	{
		public List<Product_GetListResponseData> Product_GetList(Product_GetListRequestData requestData)
		{
			var list = new List<Product_GetListResponseData>();
			try
			{
				//Buoc 1 mo connection
				var connectionManager = new Connection.SqlConnectionDB_Generic();
				var connection = connectionManager.DoConnect();
				//Buoc 2 tao command
				var cmd = new SqlCommand("SP_Product_GetList", connection);// van chua hieu doc store procedure
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				//them thams so neu co
				cmd.Parameters.AddWithValue("@ProductID", requestData.ProductID);
				//Buoc 3 thuc thi command
				var reader = cmd.ExecuteReader();
				//Buoc 4 doc du lieu
				while (reader.Read())
				{
					var product = new Product_GetListResponseData();
					product.ProductID = reader["ProductID"] != DBNull.Value ? Convert.ToInt32(reader["ProductID"]) : 0;
					product.ProductName = reader["ProductName"] != DBNull.Value ? Convert.ToString(reader["ProductName"]) : "";
					product.CategoryName = reader["CategoryName"] != DBNull.Value ? Convert.ToString(reader["CategoryName"]) : "";
					list.Add(product);
				}
			//Buoc 5 dong connection
				connection.Close();
			//buoc 6 tra ve ket qua
				return list;

			}

			catch (Exception e)
			{

				throw;
			}
		}

		public int Product_Insert(Product_InsertRequestData requestData)
		{
			var result = 0;	
			try
			{
				//Buoc 1 mo connection
				var connectionManager = new Connection.SqlConnectionDB_Generic();
				var connection = connectionManager.DoConnect();
				//Buoc 2 tao command
				var cmd = new SqlCommand("SP_Product_Insert", connection);// van chua hieu doc store procedure
				cmd.CommandType = System.Data.CommandType.StoredProcedure;
				//them thams so neu co
				cmd.Parameters.AddWithValue("@ProductName", requestData.ProductName);
				cmd.Parameters.AddWithValue("@ProductImage", requestData.ProductImage);
				cmd.Parameters.AddWithValue("@CategoryID", requestData.CategoryID);
				//Buoc 3 thuc thi command
				var rowOfAffect = cmd.ExecuteNonQuery();

				return rowOfAffect;
			}
			catch (Exception ex)
			{

				throw;
			}
			return result;
		}
	}
}
