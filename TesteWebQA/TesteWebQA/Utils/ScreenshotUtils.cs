using FrameworkCsharp.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using TesteWebQA.Utils;

namespace FrameworkCsharp.Utils
{
    public static class ScreenshotUtils
    {
        public static String TakeScreenshot()
        {
            String screenshotName = "Evidence_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".png";
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen. Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(ProjConfig.GetPath() + "Screenshots\\" + screenshotName, ImageFormat.Png);
            return "./Screenshots/" + screenshotName;
        }
    }
}