using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.BLL.Tests
{
    [TestClass()]
    public class UserManagerTests
    {
        string conn = "Data Source=.;Initial Catalog=userManage;Integrated Security=False;User Id=sa;Password=sa;";
        [TestMethod()]
        public void UserExistsTest()
        {

            UserManager um = new UserManager(conn);
            var result= um.UserExists("13691043111");
            Assert.IsTrue(result);

            Assert.IsFalse(um.UserExists("1369104311"));

        }
    }
}