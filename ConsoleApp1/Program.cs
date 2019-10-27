
using QRCoder;
using System;
using static QRCoder.PayloadGenerator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Url generator = new Url("https://www.codingindfw.com");
            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(20);
            qrCodeAsBitmap.Save("./qrcode.bmp");
        }
    }
}
