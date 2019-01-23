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

        private void buttonOui_Click(object sender, EventArgs e)
        {
            while (true)
            {
                MessageBox.Show("Oui");
            }
        }

        private void GuyGuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue à Guy Guy Land");
        }
    }
}
