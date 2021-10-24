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
    public partial class Form6 : Form
    {
        Random rn = new Random();
        int[] answer = new int[4];
        public Form6()
        {
            InitializeComponent();
            for (int count = 0; count < answer.Length; count++)
            {
                int temp = rn.Next(0, 10);
                answer[count] = temp;
                for (int i = 0; i < count; i++)
                {
                    if (temp == answer[i]) count--;
                }
                if (count == 0 && temp == 0) count--;
            }

            List<int> pool = new List<int>();
            for (int count = 0; count < 10; count++)
            {
                pool.Add(count);
            }

            for (int count = 0; count < 4; count++)
            {
                int temp = rn.Next(0, 10 - count);
                answer[count] = pool[temp];
                pool.RemoveAt(temp);

                if (count == 0 && answer[0] == 0)
                {
                    count--;
                    pool.Insert(0, 0);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int[] input_array = new int[4];
            for (int count = 0; count < input_array.Length; count++)
            {
                input_array[count] = Int32.Parse(textBox1.Text.Substring(count, 1));
                if (input_array[count] == answer[count]) a++;
                for (int index = 0; index < answer.Length; index++)
                {
                    if (input_array[count] == answer[index] && count != index) b++;
                }
            }
            listBox1.Items.Add(string.Format("您輸入{0}\t{1}A{2}B", textBox1.Text, a.ToString(), b.ToString()));
            textBox1.Clear();

            if (a == 4)
            {
                MessageBox.Show("答對，結束遊戲");
                Application.Restart();
            }
        }
    }
}
