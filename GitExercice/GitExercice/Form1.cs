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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void cringe_Click(object sender, EventArgs e)
        {
            Form2 lel = new Form2();
            lel.Show();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            Oui o = new Oui();
            o.Show();
        }
    }
}
