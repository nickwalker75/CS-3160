﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Class_3
{
    public partial class Form1 : Form
    {
        public string Sentence { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string str)
        {
            InitializeComponent();
            Sentence = str;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(this.Sentence);
        }
    }
}
