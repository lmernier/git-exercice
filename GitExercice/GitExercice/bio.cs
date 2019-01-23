using System;
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
    public partial class bio : Form
    {
        public bio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Form1 close = new Form1();
            close.Show();
            this.Close();

        }

        private void Compute_Click(object sender, EventArgs e)
        {
            int nombre1 = 0;
            int nombre2 = 0;
            int result = 0;
            nombre1 = int.Parse(Nb1.Text);
            nombre2 = int.Parse(Nb2.Text);
            result = nombre1 + nombre2;
            Rep.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
