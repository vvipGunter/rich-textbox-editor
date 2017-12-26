using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gunterRichTextBoxEditor
{
    public partial class WelcomeUse : Form
    {
        public WelcomeUse()
        {
            InitializeComponent();
        }
        private void WelcomeUse_Load(object sender, EventArgs e)
        {
           //WelcomeUse welcomeUse = new WelcomeUse();
           // if(welcomeUse.WindowState==)
           //         welcomeUse.Visible = false;
            //MessageBox.Show("fdsafdsa");
            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.05)
                Opacity -= 0.05;
            else
            {
                timer1.Enabled = false;
                Home myHome = new Home();
                myHome.Show(); 
                //this.Hide();                                //对用户隐藏控件
            }
        }

        private void WelcomeUse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
