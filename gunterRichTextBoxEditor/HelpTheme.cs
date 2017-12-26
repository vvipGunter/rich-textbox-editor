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
    public partial class HelpTheme : Form
    {
        public HelpTheme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Author author = new Author();
            author.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起，现在无法为你提供帮助！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("应急邮箱：E-mail:814117018@qq.com");
        }
    }
}
