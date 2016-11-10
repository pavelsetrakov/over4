using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess
{
    public partial class Form1 : Form
    {
        public String[] famil = new String[8];
        public int[] year = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;

            famil[0] = textBox1.Text;
            famil[1] = textBox2.Text;
            famil[2] = textBox3.Text;
            famil[3] = textBox4.Text;
            famil[4] = textBox5.Text;
            famil[5] = textBox6.Text;
            famil[6] = textBox7.Text;
            famil[7] = textBox8.Text;

            year[0] = Convert.ToInt16(textBox9.Text);
            year[1] = Convert.ToInt16(textBox10.Text);
            year[2] = Convert.ToInt16(textBox11.Text);
            year[3] = Convert.ToInt16(textBox12.Text);
            year[4] = Convert.ToInt16(textBox13.Text);
            year[5] = Convert.ToInt16(textBox14.Text);
            year[6] = Convert.ToInt16(textBox15.Text);
            year[7] = Convert.ToInt16(textBox16.Text);

            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < year.Length - 1; i++)
                {
                    if (year[i] > year[i + 1])
                    {
                        year[i] = year[i + 1] + year[i];
                        year[i + 1] = year[i] - year[i + 1];
                        year[i] = year[i] - year[i + 1];

                        String a = famil[i + 1];
                        famil[i + 1] = famil[i];
                        famil[i] = a;
                    }
                }
            }
            textBox1.Text = famil[0];
            textBox2.Text = famil[1];
            textBox3.Text = famil[2];
            textBox4.Text = famil[3];
            textBox5.Text = famil[4];
            textBox6.Text = famil[5];
            textBox7.Text = famil[6];
            textBox8.Text = famil[7];

            textBox9.Text = year[0].ToString();
            textBox10.Text = year[1].ToString();
            textBox11.Text = year[2].ToString();
            textBox12.Text = year[3].ToString();
            textBox13.Text = year[4].ToString();
            textBox14.Text = year[5].ToString();
            textBox15.Text = year[6].ToString();
            textBox16.Text = year[7].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox17.Text = textBox1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox17.Text = textBox2.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox18.Text = textBox3.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox18.Text = textBox4.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Text = textBox5.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Text = textBox6.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox20.Text = textBox7.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox20.Text = textBox8.Text;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox21.Text = textBox17.Text;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox21.Text = textBox18.Text;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            textBox22.Text = textBox19.Text;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox22.Text = textBox20.Text;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            textBox23.Text = textBox21.Text;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            textBox23.Text = textBox22.Text;
        }
    }
}
