﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitExercice
{
    public partial class Form1 : Form
    {
        int starwars = 0;
        int narnia = 0;
        int wow = 0;
        int lor = 0;
        public Form1()
        {
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK, Merci pour votre participation");
            narnia++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK, Merci pour votre participation");
            wow++;
        }

        private void starwarsbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK, Merci pour votre participation");
            starwars++;
        }

        private void lorbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK, Merci pour votre participation");
            lor++;
        }
    }
}