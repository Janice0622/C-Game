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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int computer = random.Next(1, 100);
            int user = random.Next(1, 100);
            label2.Text = user.ToString();
            label1.Text = computer.ToString();

            if (user > computer)
            {
                MessageBox.Show("你贏了");
            }
            else if (user == computer)
            {
                MessageBox.Show("平手");
            }
            else
            {
                MessageBox.Show("電腦贏");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int computer = random.Next(1, 100);
            int user = random.Next(1, 100);
            label2.Text = user.ToString();
            label1.Text = computer.ToString();

            if (user < computer)
            {
                MessageBox.Show("你贏了");
            }
            else if (user == computer)
            {
                MessageBox.Show("平手");
            }
            else
            {
                MessageBox.Show("電腦贏");
            }
        }
    }
}
