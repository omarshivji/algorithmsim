﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bubble_form bubble = new Bubble_form();
            bubble.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Binary_form binary = new Binary_form();
            binary.Show();
        }
    }
}
