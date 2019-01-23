using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitExercice
{
    public partial class Bryan8 : Form
    {
        public Bryan8()
        {
            InitializeComponent();
        }
        Stopwatch sw = new Stopwatch();
        private void button_close_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
        int StringTaille = 0;
        int StringBuilderTaille = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Facto();

            textBox_simplestring.Text = StringTaille.ToString();
            StringBuilderBox.Text = StringBuilderTaille.ToString();
            textBox2.Text = sw.ElapsedMilliseconds.ToString();
            textBox3.Text = sw.ElapsedMilliseconds.ToString();
        }

        // private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //}
        // private void textBox_simplestring_TextChanged(object sender, EventArgs e)
        //{
        //textBox_simplestring.Text = StringTaille.ToString();
        //}

        //private void StringBuilderBox_TextChanged(object sender, EventArgs e)
        //{
        // textBox_simplestring.Text = StringBuilderTaille.ToString();
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{           
        //textBox_simplestring.Text = sw.ElapsedMilliseconds.ToString();
        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        // textBox_simplestring.Text = sw.ElapsedMilliseconds.ToString();
    //}

    public void Facto()
        {
            const int MAX = 100000;
            const int MIN = 1;

            StringTaille = int.Parse(numericUpDown1.Text);
            StringBuilderTaille = int.Parse(numericUpDown2.Text);

            if ((StringTaille < MAX && StringTaille > MIN) && (StringBuilderTaille < MAX && StringBuilderTaille > MIN))
            {               
                string s = "A";

                sw.Start();
                for (int i = 0; i < StringTaille; i++)
                {
                    s = s + "B";
                }
                sw.Stop();
                sw.Restart();
                StringBuilder sb = new StringBuilder("A");
                for (int i = 0; i < StringBuilderTaille; i++)
                {
                    sb.Append("b");
                }
                sb.ToString();
                sw.Stop();
            }
            else
            {
                MessageBox.Show("vous etiez hors limite, le programme n'a pas pu fonctionner correctement");
            }
        }
    }
}
