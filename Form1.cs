using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double a;

            double S;

            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);
            a = double.Parse(textBox3.Text);

            S = 0.5 * A * B * Math.Sin(a);

            label4.Text = "S = " + S.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}