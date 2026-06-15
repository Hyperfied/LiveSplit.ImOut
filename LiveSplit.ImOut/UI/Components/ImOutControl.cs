using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public partial class ImOutControl : UserControl
    {
        public enum ImageState
        {
            Running,
            Unknown
        }

        public ImageState State { get; set; }
        public string[] imagePaths { get; set; }
        private int currentBuffer;

        public ImOutControl()
        {
            InitializeComponent();

            State = ImageState.Unknown;
            currentBuffer = 0;

            imagePaths = new string[2];
            imagePaths[0] = "Resources/unsure.jpg";
            imagePaths[1] = "Resources/imout";

        }

        private string GetCurrentImage()
        {
            switch (State)
            {
                case ImageState.Running:
                    return imagePaths[1] + currentBuffer.ToString() + ".png";
                case ImageState.Unknown:
                    return imagePaths[0];
                default:
                    return imagePaths[0];
            }
        }

        private void ImOutControl_Load(object sender, EventArgs e)
        {
            pbDisplay.Image = Image.FromFile(GetCurrentImage());
        }

        public void SetControl(ImageState state) 
        {
            if (state == State)
            {
                if (currentBuffer == 0) currentBuffer = 1;
                else currentBuffer = 0;
            }

            State = state;

            if (pbDisplay.Image != null) pbDisplay.Image.Dispose();
            pbDisplay.Image = Image.FromFile(GetCurrentImage());
        }

        public void PrintDebug()
        {
            Debug.WriteLine("Component Size: " + Size.Height + " " + Size.Width);
            Debug.WriteLine("PB Size: " + pbDisplay.Size.Height + " " + pbDisplay.Size.Width);
        }

    }
}
