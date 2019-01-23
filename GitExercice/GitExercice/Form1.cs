using System;
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
    public partial class Form1 : System.Windows.Forms.Form
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

        private void univerBtn_Click(object sender, EventArgs e)
        {
            UniverForm f2 = new UniverForm();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMarie f2 = new FormMarie();
            f2.Show();
            this.Hide();
        }

        private void BtnQtn_Click(object sender, EventArgs e)
        {
            var text = "Ca fonctionne (enlève( et ceci aussi) ceci) bien";
            text = Regex.Replace(text, @"\(.*\)", "");
            text = Regex.Replace(text, @"\s+", " ");
            MessageBox.Show(text);
        }

        private void GuyGuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue à Guy Guy Land");
        }

        private void Btn_GoToHK_Click(object sender, EventArgs e)
        {
            HK hk = new HK();
            hk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZozie zozie = new FormZozie();
            zozie.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bryan8 b8 = new Bryan8();
            b8.Show();
            this.Hide();
        }
    }
}