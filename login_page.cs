using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Santral_Rehberi
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
            GradientBackground.Apply(this, Color.White, Color.Blue, LinearGradientMode.Vertical);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_page homePage = new home_page();
            homePage.Show();
            this.Hide();
        }
    }
}
