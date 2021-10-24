using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form3 : Form
    {
        int x;
        public Form3()
        {
            InitializeComponent();
            Random r = new Random();
            x = r.Next(1, 100);
        }
        int a = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {

            a++;
            label6.Text = a.ToString();
            if (Convert.ToInt32(textBox1.Text) == x)
            {
                MessageBox.Show("答對");
                a = 0;
            }
            else if (Convert.ToInt32(textBox1.Text) > x)
            {
                label3.Text = textBox1.Text;
            }
            else if (Convert.ToInt32(textBox1.Text) < x)
            {
                label1.Text = textBox1.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("請問是否離開遊戲嗎?", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            x = r.Next(1, 100);
            label1.Text = "0";
            label3.Text = "100";
            label6.Text = "0";
            textBox1.Clear();
        }

    }
}
