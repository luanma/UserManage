using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManage.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace UserManage.Util.Tests
{
    [TestClass()]
    public class QRGeneratorTests
    {
        [TestMethod()]
        public void GenerateQRCodeTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //for(int i=0;i<100;i++)
            //{
                string s = "weixin：//wxpay/s/" + System.Guid.NewGuid().ToString().Substring(4);
                Bitmap b = QRGenerator.GenerateQRCode(s);
            b.Save(@"C:\code\a.bmp");
            //}
            sw.Stop();
            System.Diagnostics.Debug.Print(sw.ElapsedMilliseconds.ToString());
            Assert.IsTrue(sw.ElapsedMilliseconds < 3000);

        }

    }
}