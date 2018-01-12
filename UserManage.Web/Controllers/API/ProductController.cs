using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserManage.Model;
using UserManage.BLL;
using System.Configuration;

namespace UserManage.Web.Controllers.API
{
    public class ProductController : ApiController
    {
        public List<Product> GetProducts()
        {
            string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            ProductManager pm = new ProductManager(connstr);
            return pm.GetProducts();
        }
    }
}
