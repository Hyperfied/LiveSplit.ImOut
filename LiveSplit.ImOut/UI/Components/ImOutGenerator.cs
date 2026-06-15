using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;

namespace LiveSplit.UI.Components
{
    public class ImOutGenerator
    {
        private string outImage = "Resources/out.png";
        private string inImage = "Resources/in.png";
        private string unsureImage = "Resources/unsure.jpg";

        private Color red = Color.FromArgb(245, 5, 4);
        private Color green = Color.FromArgb(81, 246, 60);

        private int currentBuffer = 0;

        private PrivateFontCollection fontCollection = new PrivateFontCollection();

        public ImOutGenerator() {
            fontCollection.AddFontFile("Resources/Gotham Black.otf");
        }

        public void DrawImage(string formattedTime)
        {
            Debug.WriteLine(formattedTime.First());
            Font font = new Font(fontCollection.Families.First(), 34);
            Brush brush;
            string image;

            
            if (formattedTime.StartsWith("+"))
            {
                Debug.WriteLine("Positive");
                brush = new SolidBrush(red);
                image = outImage;

                Bitmap bitmap = new Bitmap(image);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Move origin
                    g.TranslateTransform(265, 50);

                    // Rotate slightly
                    g.RotateTransform(5);

                    // Draw text
                    g.DrawString(formattedTime, font, brush, 0, 0);

                    // Reset transform
                    g.ResetTransform();

                    bitmap.Save("Resources/imout" + currentBuffer.ToString() + ".png", ImageFormat.Png);
                }
            }
            else
            {
                Debug.WriteLine("Negative");
                brush = new SolidBrush(green);
                image = inImage;

                Bitmap bitmap = new Bitmap(image);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Move origin
                    g.TranslateTransform(265, 50);

                    // Rotate slightly
                    g.RotateTransform(5);

                    // Draw text
                    g.DrawString(formattedTime, font, brush, 0, 0);

                    // Reset transform
                    g.ResetTransform();

                    bitmap.Save("Resources/live" + currentBuffer.ToString() + ".png", ImageFormat.Png);
                }
            }

            if (currentBuffer == 0) currentBuffer = 1;
            else currentBuffer = 0;

        }
    }
}
