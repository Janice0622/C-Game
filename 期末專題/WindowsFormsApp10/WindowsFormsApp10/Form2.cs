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
    public partial class Form2 : Form
    {
        Random rn = new Random();
        int[] answer = new int[1];
        int x = 0, y = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label3.Text = "石頭";
            int temp = rn.Next(1, 4);
            if (temp == 1)
            {
                label1.Text = "剪刀";
                y++;
                label6.Text = y.ToString();
            }
            else if (temp == 2)
            {
                label1.Text = "石頭";
            }
            else
            {
                label1.Text = "布";
                x++;
                label4.Text = x.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label3.Text = "布";
            int temp = rn.Next(1, 4);
            if (temp == 1)
            {
                label1.Text = "剪刀";
                x++;
                label4.Text = x.ToString();
            }
            else if (temp == 2)
            {
                label1.Text = "石頭";
                y++;
                label6.Text = y.ToString(); ;
            }
            else
            {
                label1.Text = "布";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Text = "剪刀";
            int temp = rn.Next(1, 4);
            if (temp == 1)
            {
                label1.Text = "剪刀";
            }
            else if (temp == 2)
            {
                label1.Text = "石頭";
                x++;
                label4.Text = x.ToString();
            }
            else
            {
                label1.Text = "布";
                y++;
                label6.Text = y.ToString();
            }
        }
    }
}
