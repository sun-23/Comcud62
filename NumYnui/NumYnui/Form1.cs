using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumYnui
{
    public partial class Form1 : Form
    {
        int b;
        string x = "";
        int sum;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            for (int i = 0; i < b; i++)
            {
                x = x + "1";
            }

            sum = int.Parse(x) * int.Parse(x);
            label2.Text = sum.ToString("##,###,###");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = "";
            textBox1.Text = "";
            b = 0;
            label2.Text = "";
        }
    }
}
