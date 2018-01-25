using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManage.BLL;
using UserManage.Model;
using UserManage.Util;
using UserManage.Web.Models;

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
            Session["user"] = result;
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

                //verify code
                UserInfo user = new UserInfo();
                user.UserName = collection["UserName"].ToString();
                user.Password = collection["Password"].ToString();
                user.Status = UserStatus.Normal;
                user.CreateDate = System.DateTime.Now;
                UserManager um = new UserManager(connstr);
                var result= um.CreateUser(user.UserName, user.Password,user.RefUserId);
                if (result == CreateUserResult.Success)
                    return RedirectToAction("Index");
                else
                {
                    UserViewModels u = new UserViewModels();
                    u.UserName = user.UserName;
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ChangePassword(string userName)
        {
            return View();
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


        public bool Validate(string code)
        {
            if (Session["VALIDATESTR"]!=null && 
                Session["VALIDATESTR"].ToString() == code)
                return true;
            else
                return false;
        }

        public bool SendPhoneCode(string phone)
        {
            var code = System.Guid.NewGuid().ToString().Substring(1, 6);
            Session["VALIDATESTR"] = code;
            var key = ConfigurationManager.AppSettings["smskey"].ToString();
            return SMSHelper.SendMessage(phone, code, key);
        }

        public bool VerifyPhoneCode(string code)
        {
            if (Session["VALIDATESTR"] == null)
                return false;

            return Session["VALIDATESTR"].ToString().ToUpper() == code.ToUpper();            
        }

    }
}
