using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserManage.BLL;

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
                
        
    }
}
