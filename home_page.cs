using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santral_Rehberi
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
            GradientBackground.Apply(this, Color.White, Color.Blue, LinearGradientMode.Vertical);
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }
    }
}
