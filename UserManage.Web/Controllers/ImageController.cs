using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManage.Util;

namespace UserManage.Web.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult GetImage()
        {
            string validateStr = Session["VALIDATESTR"].ToString();
            Bitmap img = Util.GDIPicGenerater.GetPicGenerate().GetImage(validateStr);
            return new ImageResult()
            {
                Image = img,
                ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
            };
        }
    }
}