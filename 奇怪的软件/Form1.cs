using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nene1212
{
    public partial class zuzu : Form
    {
        public zuzu()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "帅";
            button2.Text = "不帅";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "帅";
            button1.Text = "不帅";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你怎么知道！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你都把我说不好意思了");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Text = "up帅炸了";
            MessageBox.Show("被你发现了ww");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, base.Size.Width - this.button5.Size.Width);
            int y = random.Next(0, base.ClientSize.Height - this.button5.Size.Height);
            Point location = new Point(x, y);
            this.button5.Location = location;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你也很帅嘛！");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("up已经帅出天际了吧？", "人生的抉择", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("=w=");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是up的id哦，赶快bilibili关注一波ww");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我在问你诶"); 
        }
    }
}
