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
        Form1 me = new Form1();
        private void Btn_GoToHK_Click(object sender, EventArgs e)
        {
            HK hk = new HK();
            hk.Show();
            me.Close();
        }
    }
}
