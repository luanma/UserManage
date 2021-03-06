﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManage.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace UserManage.BLL
{
    public class ProductManager
    {
        private string ConnectionString = "";
        public ProductManager(string connstring)
        {
            ConnectionString = connstring;
        }
        
        public  List<Product> GetProducts()
        {
            
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {

                return  db.Query<Product>("SELECT * FROM Product").ToList();
            }
            
        }
    }
}
