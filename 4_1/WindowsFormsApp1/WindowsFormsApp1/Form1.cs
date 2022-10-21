using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;   
            string d = textBox4.Text;
            int i_start = Convert.ToInt32(a);
            int i_end = Convert.ToInt32(b);
            int j_start = Convert.ToInt32(c);
            int j_end = Convert.ToInt32(d);
            double sum=0, mul,y;
            int k = i_start - 1,j;
            do
            {
                k++;
                sum = sum + (1 + Math.Log(k));
            }
            while (k<=i_end);
            mul = 1;
            j = j_start- 1;
            do
            {
                j++;
                mul = mul * (3 * k - j);
            }
            while(j<=j_end);
            y = sum + mul;
            textBox5.Text = sum.ToString();
            textBox6.Text = mul.ToString();     
        }
    }
}
