using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManage.Model;

namespace UserManage.IDAL
{
   public interface IProductDAL
    {
        List<Product> GetAllProducts();
    }
}
