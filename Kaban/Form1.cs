﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;

namespace Kaban
{
    public partial class Гипноз : MetroFramework.Forms.MetroForm
    {
        public Гипноз()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager1 = null;
            this.StyleManager = metroStyleManager1;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(metroTextBox1.Text);
            b = Convert.ToInt32(metroTextBox2.Text);
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            a = a + b;
            metroLabel1.Text = Convert.ToString(a);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
