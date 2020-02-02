using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeToJPG
{
    static class Program
    {
        private static Regex r = new Regex(":");
        
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           DateTime dateTaken = GetDateTakenFromImage(@"C:\Users\Gustav\Desktop\Bilder\test.jpg");
           string stringDate = dateTaken.ToString();
           Bitmap bmp = new Bitmap(@"C:\Users\Gustav\Desktop\Bilder\test.jpg");
           Graphics gra = Graphics.FromImage(bmp);
           gra.DrawString(stringDate, new Font("Verdana", 24), Brushes.Black, new PointF(0, 0));
           bmp.Save(@"C:\Users\Gustav\Desktop\Bilder\test_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            /*
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
            */




            //retrieves the datetime WITHOUT loading the whole image




        }
        
    }
}