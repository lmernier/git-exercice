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
    public partial class FormZozie : Form
    {
        public FormZozie()
        {
            InitializeComponent();
        }

        private void rndBtnRien_CheckedChanged(object sender, EventArgs e)
        {
            var text = "Circulez Rien à VOIR !!";
            //MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
