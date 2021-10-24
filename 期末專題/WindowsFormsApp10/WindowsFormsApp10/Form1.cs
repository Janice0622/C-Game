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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show(this);
        }

        private void 猜拳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show(this);
        }

        private void 終極密碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show(this);
        }

        private void 比大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show(this);
        }

        private void 拖曳遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show(this);
        }

        private void 幾A幾BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show(this);
        }
    }
}
