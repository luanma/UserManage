using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace UserManage.Util
{
    public class GDIPicGenerater
    {
        private static GDIPicGenerater instance = new GDIPicGenerater();
        private static Stream backGroundStream;
        private GDIPicGenerater() { }
        public static GDIPicGenerater GetPicGenerate()
        {
            if (backGroundStream == null)
            {
                //Assembly.GetExecutingAssembly();
                Assembly assembly = Assembly.GetExecutingAssembly();// Assembly.LoadFrom("Util.Dll");
                backGroundStream = assembly.GetManifestResourceStream("Util.Img.backGround.png");
            }
            return instance;
        }

        public Bitmap GetImage(string s)
        {
            Bitmap img;
            Graphics g;
            img = new Bitmap(backGroundStream);
            g = Graphics.FromImage(img);

            Font f = new Font("Arial Black", 10);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(s, f, brush, 2, 2);
            g.Dispose();
            return img;
        }

        public MemoryStream GetImageStream(string s)
        {
            Bitmap img;
            Graphics g;
            img = new Bitmap(backGroundStream);
            g = Graphics.FromImage(img);

            Font f = new Font("Arial Black", 10);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(s, f, brush, 2, 2);
            g.Dispose();
            MemoryStream mstream = new MemoryStream();
            img.Save(mstream, System.Drawing.Imaging.ImageFormat.Png);
            return mstream;
        }

    }
}
