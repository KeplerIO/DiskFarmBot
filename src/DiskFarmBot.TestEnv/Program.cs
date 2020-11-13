using System.IO;
using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime;

namespace DiskFarmBot.TestEnv
{
    class Program
    {
        static void Main(string[] args)
        {
                     

            

        }

        static void createAppDataDir()
        {
            string dataFolderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\DiscFarmBot";
            Directory.CreateDirectory(dataFolderPath);
        }
        
        static void takeScreenshot(string imgDestinationPath)
        {
            Bitmap bmp = new Bitmap(2560, 1440);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(0, 0, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            g.Dispose();

            bmp.Save(imgDestinationPath, ImageFormat.Jpeg);
            bmp.Dispose();
        }
    }
}
