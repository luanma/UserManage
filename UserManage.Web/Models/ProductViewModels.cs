using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManage.Model;

namespace UserManage.Web.Models
{
    public class ProductViewModels
    {
        public ProductViewModels(List<Product> productList)
        {
            this.ProductList = productList; 
        }
        List<Product> ProductList;
    }
}