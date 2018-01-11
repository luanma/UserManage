using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManage.IDAL;
using UserManage.Model;
using Dapper;

namespace UserManage.DAL
{
    public class ProductDal: IProductDAL
    {
        public List<Product> GetAllProducts()
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                db.Query<Product>
                    ("SELECT * FROM Product Order BY SortID").ToList();
            }
            return null;
        }
    }
}
