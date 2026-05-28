using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public partial class ImOutControl : UserControl
    {
        public Image Image { get; set; }

        public ImOutControl()
        {
            InitializeComponent();
        }


        private void ImOutControl_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image;
        }
    }
}
