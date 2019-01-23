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
    public partial class HK : Form
    {
        public HK()
        {
            InitializeComponent();
        }

        private void CB_add_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_add.Checked)
            {
                CB_divide.Checked = false;
                CB_modulo.Checked = false;
                CB_multiply.Checked = false;
                CB_soustract.Checked = false;
            }
        }

        private void CB_soustract_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_soustract.Checked)
            {
                CB_divide.Checked = false;
                CB_modulo.Checked = false;
                CB_multiply.Checked = false;
                CB_add.Checked = false;
            }
        }

        private void CB_multiply_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_multiply.Checked)
            {
                CB_divide.Checked = false;
                CB_modulo.Checked = false;
                CB_add.Checked = false;
                CB_soustract.Checked = false;
            }
        }

        private void CB_Divide_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_divide.Checked)
            {
                CB_add.Checked = false;
                CB_modulo.Checked = false;
                CB_multiply.Checked = false;
                CB_soustract.Checked = false;
            }
        }

        private void CB_modulo_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_modulo.Checked)
            {
                CB_divide.Checked = false;
                CB_add.Checked = false;
                CB_multiply.Checked = false;
                CB_soustract.Checked = false;
            }
        }

        private void BTN_return_Click(object sender, EventArgs e)
        {
            Form1 baseForm = new Form1();
            this.Close();
            baseForm.Show();
        }

        private void BTN_calculate_Click(object sender, EventArgs e)
        {
            string result = CalculateMe(int.Parse(NUD_first.Text), int.Parse(NUD_second.Text)).ToString();

            TB_result.Text = result;
        }
        private int CalculateMe(int numberOne, int numberTwo)
        {
            int result = 0;
            if (CB_add.Checked)
                result = numberOne + numberTwo;
            else if (CB_soustract.Checked)
                result = numberOne - numberTwo;
            else if (CB_multiply.Checked)
                result = numberOne * numberTwo;
            else if (CB_divide.Checked)
                result = numberOne / numberTwo;
            else if (CB_modulo.Checked)
                result = numberOne % numberTwo;
            else
                throw new ArgumentException();
            return result;
        }
    }
}
