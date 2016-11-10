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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
