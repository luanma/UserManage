using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManage.BLL;
using UserManage.Model;

namespace UserManage.Web.Controllers
{
    public class UserController : Controller
    {
        private string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
       
        
        public ActionResult Login()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            string username = collection["username"];
            string password = collection["password"];
            UserManager um = new UserManager(connstr);
            var result= um.Login(username, password);
            return View();
        }


        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                UserInfo user = new UserInfo();
                user.UserName = collection["UserName"].ToString();
                user.Password = collection["Password"].ToString();
                user.Status = UserStatus.Normal;
                user.CreateDate = System.DateTime.Now;
                UserManager um = new UserManager(connstr);
                var result= um.CreateUser(user.UserName, user.Password,user.RefUserId);
               // if(result==CreateUserResult.Success)
                 return RedirectToAction("Index");
               
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
