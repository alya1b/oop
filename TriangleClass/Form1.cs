using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TriangleClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Triangle
        {
            public double a;
            public double b;
            public double c;

            public void Perimetr(ref double p)
            {
                p = a + b + c;
            }

            public void Angles(ref double ang_a, ref double ang_b, ref double ang_c)
            {
                ang_a = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                ang_b = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                ang_c = Math.Acos((b * b + a * a - c * c) / (2 * b * a));
            }

            public void Change_a(double newa)
            {
                a = newa;
            }
            public void Change_b(double newb)
            {
                b = newb;
            }
            public void Change_c(double newc)
            {
                c = newc;
            }
        }
        class Equilateral_triangle : Triangle
        {
            public double S;
            public void Count_S()
            {
                S = a * a * 0.433;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;

            Triangle A = new Triangle();
            double ang_a=0;
            double ang_b=0;
            double ang_c=0;

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));
            A.Change_c(Convert.ToDouble(c));
            A.Angles(ref ang_a, ref ang_b, ref ang_c);

            textBox5.Text = ang_a.ToString();
            textBox6.Text = ang_b.ToString();
            textBox7.Text = ang_c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s=0;
            string a = textBox4.Text;
            Equilateral_triangle A = new Equilateral_triangle();
            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(a));
            A.Change_c(Convert.ToDouble(a));

            A.Count_S();
            s = A.S;
            textBox9.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double p = 0;
            string a = textBox4.Text;
            Equilateral_triangle A = new Equilateral_triangle();
            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(a));
            A.Change_c(Convert.ToDouble(a));

            A.Perimetr(ref p);
            textBox8.Text = p.ToString();
        }
    }
}
