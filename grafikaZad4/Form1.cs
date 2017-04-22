using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikaZad4
{
    public partial class Form1 : Form
    {
        Graphics drawArea;
        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            double dx, dy;
            double x = 200, y = 200;

            dx = (float)Double.Parse(textBox1.Text);
            dy = (float)Double.Parse(textBox2.Text);

            drawArea.DrawEllipse(new Pen(Color.Black), (float)x, (float)y, 100, 100);

            // przesuwanie

            drawArea.DrawEllipse(new Pen(Color.Blue), (float)(x + dx), (float)(y + dy), 100, 100);

        }

        private void ScaleButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            double dx, dy;
            double x = 200, y = 200;
            float height = 100;
            float width = 150;
            PointF centre = new PointF((float)(x - width / 2), (float)(y - height / 2));

            dx = (float)Double.Parse(textBox3.Text);
            dy = (float)Double.Parse(textBox4.Text);


            drawArea.DrawEllipse(new Pen(Color.Black), (float)centre.X, (float)centre.Y, width, height);
            drawArea.DrawEllipse(new Pen(Color.Blue), (float)centre.X, (float)centre.Y, (float)(width * dx), (float)(height * dy));
        }

        public PointF Rotate(PointF p, float angle)
        {
            p.X = (float)(p.X * Math.Cos(angle) + p.Y * Math.Sin(angle));
            p.Y = (float)(-p.X * Math.Sin(angle) + p.Y * Math.Cos(angle));
            return p;
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);

            float angle = (float)Double.Parse(textBox5.Text);

            drawArea.DrawRectangle(new Pen(Color.Black), 300, 300, 100, 100);

            drawArea.RotateTransform(angle);
            drawArea.DrawRectangle(new Pen(Color.Blue), 300, 300, 100, 100);
            drawArea.RotateTransform(-angle);
        }

        private void TSButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            double x = 200, y = 200;
            float height = 100;
            float width = 100;
            PointF centre = new PointF((float)(x - width / 2), (float)(y - height / 2));

            drawArea.DrawEllipse(new Pen(Color.Black), (float)centre.X, (float)centre.Y, width, height);

            double dTx, dTy, dSx, dSy;

            dTx = (float)Double.Parse(textBox6.Text);
            dTy = (float)Double.Parse(textBox7.Text);
            dSx = (float)Double.Parse(textBox8.Text);
            dSy = (float)Double.Parse(textBox9.Text);
            drawArea.DrawEllipse(new Pen(Color.Blue), (float)(centre.X+dTx), (float)(centre.Y+dTy), (float)(width * dSx), (float)(height * dSy));
        }

        private void TRButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);

            double x = 300, y = 300;
            drawArea.DrawRectangle(new Pen(Color.Black), (float)x, (float)y, 100, 100);


            double dx, dy;

            dx = (float)Double.Parse(textBox10.Text);
            dy = (float)Double.Parse(textBox11.Text);
            float angle = (float)Double.Parse(textBox12.Text);

            drawArea.RotateTransform(angle);
            drawArea.DrawRectangle(new Pen(Color.Blue), (float)(x+dx), (float)(y+dy), 100, 100);
            drawArea.RotateTransform(-angle);
        }

        private void SRButton_Click(object sender, EventArgs e)
        {
            drawArea.Clear(Color.White);
            double x = 200, y = 200;
            float height = 100;
            float width = 150;
            PointF centre = new PointF((float)(x - width / 2), (float)(y - height / 2));

            drawArea.DrawEllipse(new Pen(Color.Black), (float)centre.X, (float)centre.Y, width, height);

            double dx, dy;

            dx = (float)Double.Parse(textBox13.Text);
            dy = (float)Double.Parse(textBox14.Text);
            float angle = (float)Double.Parse(textBox15.Text);

            drawArea.RotateTransform(angle);
            drawArea.DrawEllipse(new Pen(Color.Blue), (float)centre.X, (float)centre.Y, (float)(width * dx), (float)(height * dy));
            drawArea.RotateTransform(-angle);
        }
    }
}
