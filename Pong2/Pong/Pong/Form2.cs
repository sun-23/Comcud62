﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.aTimerPaddle.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.aTimerPaddle.Enabled = false;
        }
    }
}
