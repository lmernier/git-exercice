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
        public Form1()
        {
            InitializeComponent();
        }

        private void univerBtn_Click(object sender, EventArgs e)
        {
            UniverForm f2 = new UniverForm();
            f2.Show();
            this.Hide();
        }
    }
}
