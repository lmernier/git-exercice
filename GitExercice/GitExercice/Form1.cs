﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void BtnQtn_Click(object sender, EventArgs e)
        {
            var text = "Ca fonctionne (enlève ceci) bien";
            text = Regex.Replace(text, @"\(.*\)", "");
            text = Regex.Replace(text, @"\s+", " ");
            MessageBox.Show(text);
        }
    }
}