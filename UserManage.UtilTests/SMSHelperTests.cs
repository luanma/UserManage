using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManage.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Util.Tests
{
    [TestClass()]
    public class SMSHelperTests
    {
        [TestMethod()]
        public void SendMessageTest()
        {
            SMSHelper s = new SMSHelper();
            s.SendMessage("13691043111", "9527");
        }
    }
}