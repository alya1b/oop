using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFigure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Figure
        {
            public double area;
            public double perimeter;

            public abstract void CountPerimeter();
            public abstract void CountArea();
        }
        class Triangle : Figure
        {
            public double a;
            public double b;
            public double c;

            public override void CountArea()
            {
                double p = (a + b + c) / 2; //half of a perimeter
                area = Math.Sqrt(p*(p-c)*(p-b)*(p-a)); //Формула Герона
            }
            public override void CountPerimeter()
            {
                perimeter = a + b + c;
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
        class Circle : Figure
        {
            public double radius;
            const double pi = 3.14;
            public override void CountArea()
            {
                area = pi * radius * radius;
            }
            public override void CountPerimeter()
            {
                perimeter = pi * radius * 2;
            }
            public void Change_radius(double r)
            {
                radius=r;
            }

        }
        class Rectangle : Figure
        {
            public double a;
            public double b;
            public override void CountArea()
            {
                area = a * b;
            }
            public override void CountPerimeter()
            {
                perimeter = a * 2 + b * 2;
            }
            public void Change_a(double newa)
            {
                a = newa;
            }
            public void Change_b(double newb)
            {
                b = newb;
            }

        }
        class Square : Figure
        {
            public double a;
            public override void CountArea()
            {
                area = a * a;
            }
            public override void CountPerimeter()
            {
                perimeter = a * 4;
            }
            public void Change_a(double newa)
            {
                a = newa;
            }

        }
        class Diamond : Figure
        {
            public double a;
            public double h;
            public override void CountArea()
            {
                area = a * h;
            }
            public override void CountPerimeter()
            {
                perimeter = a * 4;
            }
            public void Change_a(double newa)
            {
                a = newa;
            }
            public void Change_h(double newh)
            {
                h = newh;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            Triangle A = new Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));
            A.Change_c(Convert.ToDouble(c));

            A.CountArea();
            result = A.area;
            textBox10.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            Triangle A = new Triangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));
            A.Change_c(Convert.ToDouble(c));

            A.CountPerimeter();
            result = A.perimeter;
            textBox11.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = 0;
            string r = textBox4.Text;
            Circle A = new Circle();
            A.Change_radius(Convert.ToDouble(r));

            A.CountArea();
            result = A.area;
            textBox12.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double result = 0;
            string r = textBox4.Text;
            Circle A = new Circle();
            A.Change_radius(Convert.ToDouble(r));

            A.CountPerimeter();
            result = A.perimeter;
            textBox13.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox5.Text;
            string b = textBox6.Text;
            Rectangle A = new Rectangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));

            A.CountArea();
            result = A.area;
            textBox14.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox5.Text;
            string b = textBox6.Text;
            Rectangle A = new Rectangle();

            A.Change_a(Convert.ToDouble(a));
            A.Change_b(Convert.ToDouble(b));

            A.CountPerimeter();
            result = A.perimeter;
            textBox15.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox7.Text;
            Square A = new Square();
            A.Change_a(Convert.ToDouble(a));

            A.CountArea();
            result = A.area;
            textBox16.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox7.Text;
            Square A = new Square();
            A.Change_a(Convert.ToDouble(a));

            A.CountPerimeter();
            result = A.perimeter;
            textBox17.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox8.Text;
            string h = textBox9.Text;
            Diamond A = new Diamond();

            A.Change_a(Convert.ToDouble(a));
            A.Change_h(Convert.ToDouble(h));

            A.CountArea();
            result = A.area;
            textBox18.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double result = 0;
            string a = textBox8.Text;
            string h = textBox9.Text;
            Diamond A = new Diamond();

            A.Change_a(Convert.ToDouble(a));
            A.Change_h(Convert.ToDouble(h));

            A.CountPerimeter();
            result = A.perimeter;
            textBox19.Text = result.ToString();
        }
    }
}
