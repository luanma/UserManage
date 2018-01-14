using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManage.BLL;
using UserManage.Web.Models;
using System.Web;

namespace UserManage.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductManager pm = new ProductManager(System.Web.HttpContext.Current.Application["connStr"].ToString());
            ProductViewModels pv = new ProductViewModels(pm.GetProducts());
            return View(pv);
        }
    }
}