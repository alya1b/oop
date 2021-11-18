using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Triangle
        {
            public double a;
            public double b;
            public double ang_c; //angle in radians

            public virtual void CountArea(ref double area)
            {
                area = a * b * Math.Sin(ang_c);
            }
            public virtual void CountPerimeter(ref double perimeter)
            {
                perimeter = Math.Sqrt(b * b + a * a - 2 * b * a * Math.Cos(ang_c)) + a + b;
            }
            public void Change_a(double newa)
            {
                a = newa;
            }
            public void Change_b(double newb)
            {
                b = newb;
            }
            public void Change_angle(double newangle)
            {
                ang_c = newangle;
            }
        }
        class Right_Triangle : Triangle
        {
            public override void CountArea(ref double area)
            {
                area = a * b /2;
            }
            public override void CountPerimeter(ref double perimeter)
            {
                perimeter = Math.Sqrt(b * b + a * a) + a + b;
            }

        }
        class Isosceles_Triangle : Triangle
        {
            public override void CountArea(ref double area)
            {
                area = a * a * Math.Sin(ang_c);
            }
            public override void CountPerimeter(ref double perimeter)
            {
                perimeter = Math.Sqrt(2 * a * a - 2 * a * a * Math.Cos(ang_c)) + a * 2;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox4.Text;
            string b = textBox5.Text;
            Right_Triangle A = new Right_Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));

            A.CountArea(ref result);

            textBox8.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox4.Text;
            string b = textBox5.Text;
            Right_Triangle A = new Right_Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));

            A.CountPerimeter(ref result);

            textBox13.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox6.Text;
            string angle = textBox7.Text;
            Isosceles_Triangle A = new Isosceles_Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_angle(Convert.ToDouble(angle));

            A.CountArea(ref result);

            textBox11.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox6.Text;
            string angle = textBox7.Text;
            Isosceles_Triangle A = new Isosceles_Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_angle(Convert.ToDouble(angle));

            A.CountPerimeter(ref result);

            textBox12.Text = result.ToString();
        }
    }
}
