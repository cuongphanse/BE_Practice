using DataAccess.Class;
using DataAccess.RequestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
	public interface IProductManager
	{
		List<Product_GetListResponseData> Product_GetList(Product_GetListRequestData requestData);
		int Product_Insert(Product_InsertRequestData requestData);
	}
}
