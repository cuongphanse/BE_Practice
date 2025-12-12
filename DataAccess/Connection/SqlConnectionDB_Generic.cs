using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Connection
{
	public class SqlConnectionDB_Generic : GenericConnectionDatabase<SqlConnection>
	{
		SqlConnection _sqlConnection;
		public override SqlConnection DoConnect()
		{
			var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BE_Udemy_ConnectionString"].ConnectionString ?? "";
			_sqlConnection = new SqlConnection(connectionString);
			if(_sqlConnection.State != System.Data.ConnectionState.Open)
			{
				_sqlConnection.Open();
			}
			return _sqlConnection;
		}
	}
}
