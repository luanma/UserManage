using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Util
{
    public static class QRGenerator
    {
       static  QRCodeGenerator qrGenerator = new QRCodeGenerator();
        public static Bitmap GenerateQRCode(string source)
        {
            
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(source, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
