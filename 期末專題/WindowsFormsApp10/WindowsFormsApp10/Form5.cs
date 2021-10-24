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
    public partial class Form5 : Form
    {
        List<int> shffled = new List<int>();

        public Form5()
        {
            InitializeComponent();
            button1.Text = "驗證答案";

            List<int> pool = new List<int>();
            for (int i = 1; i < 11; i++) pool.Add(i);

            while (pool.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, pool.Count);
                shffled.Add(pool[index]);
                pool.RemoveAt(index);
            }

            int counter = 0;
            foreach (int value in shffled)
            {
                Label lb = new Label();
                lb.Name = "lb_" + value.ToString();
                lb.Font = new Font("微軟正黑體", 16);
                lb.Size = new Size(50, 50);
                lb.Text = value.ToString();
                lb.Location = new Point(50 + counter * 70, 50);
                lb.DragOver += Lb_DragOver;
                lb.MouseMove += Lb_MouseMove;
                this.Controls.Add(lb);

                Label answer = new Label();
                answer.Name = "lb_answer" + counter.ToString();
                answer.Text = 0 + "";
                answer.Font = new Font("微軟正黑體", 16);
                answer.Size = new Size(50, 50);
                answer.Location = new Point(50 + counter * 70, 150);
                answer.DragDrop += Answer_DragDrop;
                answer.DragEnter += Answer_DragEnter;
                answer.AllowDrop = true;

                this.Controls.Add(answer);

                counter++;

            }
        }

        private void Answer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void Answer_DragDrop(object sender, DragEventArgs e)
        {
            Label lb = (Label)sender;
            lb.Text = e.Data.GetData(typeof(string)).ToString();
        }


        private void Lb_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Label lb = (Label)sender;
                string r = lb.Text;
                lb.DoDragDrop(r, DragDropEffects.Copy);
            }
        }

        private void Lb_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int check = 0;
            foreach (Control contorl in this.Controls)
            {
                if (contorl.Name.Contains("lb_answer"))
                {
                    Label lb_answer = (Label)contorl;
                    if (check >= int.Parse(lb_answer.Text))
                    {
                        MessageBox.Show("GG"); return;
                    }
                    else check = int.Parse(lb_answer.Text);
                }
            }
            if (MessageBox.Show("play again?", "win", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            };
        }
    }
}
