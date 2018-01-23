using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserManage.BLL;
using UserManage.Model;
using System.Web.Mvc;

namespace UserManage.Web.Controllers.API
{
    public class UserController : ApiController
    {
        public bool UserExists(string userName)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            UserManager um = new UserManager(connstr);
            return um.UserExists(userName);
        }

        public UserInfo login(string username, string password)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            UserManager um = new UserManager(connstr);
            var result= um.Login(username, password);
            return result;
        }

        public void UpdatePassword(UserInfo user)
        {
            string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            UserManager um = new UserManager(connstr);
            um.UpdatePassword(user.UserName, user.Password);
        }        
    }
}
