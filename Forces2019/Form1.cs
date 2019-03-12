using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x * 180.0 / Math.PI));
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0)); 
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180.0 / Math.PI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox2.Text);

            double Fx = F * cos(angle);
            double Fy = F * sin(angle);

            MessageBox.Show("Fx = " + Fx + " N");
            MessageBox.Show("Fy = " + Fy + " N");

        }
    }
}
