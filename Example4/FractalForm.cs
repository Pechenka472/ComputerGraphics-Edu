using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_WinFormsFractal
{
    public partial class FractalForm : Form
    {
        Graphics graphics;
        int _iteration;
        readonly Brush brush = new SolidBrush(Color.Black);
        readonly Pen pen = new Pen(Color.Black);
        private int _length;
        const int d = 4;
        bool lineTypeTriangles;

        public FractalForm()
        {
            InitializeComponent();
        }

        private void FractalForm_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
            _iteration = int.Parse(textBox1.Text);
            _length = int.Parse(textBox2.Text);
        }
        #region Triangle
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "0")
            {
                drawButton.Enabled = false;
            }
            else
            {
                drawButton.Enabled = true;
            }
            if (int.TryParse(textBox1.Text, out var parse))
            {
                _iteration = parse;
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawTriangle(_iteration);
        }

        private void DrawTriangle(int Iteration)
        {
            var point1 = new PointF(d, panel1.Height - 2 * d);
            var point2 = new PointF(panel1.Width / 2, 0);
            var point3 = new PointF(panel1.Width - 2 * d, panel1.Height - 2 * d);

            if (lineTypeTriangles)
            {
                graphics.DrawLine(pen, point1, point2);
                graphics.DrawLine(pen, point2, point3);
                graphics.DrawLine(pen, point3, point1);
            }
            else
            {
                graphics.FillEllipse(brush, point1.X, point1.Y, d, d);
                graphics.FillEllipse(brush, point2.X, point2.Y, d, d);
                graphics.FillEllipse(brush, point3.X, point3.Y, d, d);
            }

             DrawTriangleFractal(point1, point2, point3, Iteration);
             DrawTriangleFractal(point3, point1, point2, Iteration);
             DrawTriangleFractal(point2, point3, point1, Iteration);
        }

        private void DrawTriangleFractal(PointF point1, PointF point2, PointF point3, int iteration)
        {
            var midPoint1 = new Point(
                (int)(point1.X - (point1.X - point2.X) / 2),
                (int)(point1.Y - (point1.Y - point2.Y) / 2));

            var midPoint2 = new Point(
                (int)(point1.X - (point1.X - point3.X) / 2),
                (int)(point1.Y - (point1.Y - point3.Y) / 2));

            var midPoint3 = new Point(
                (int)(point2.X - (point2.X - point3.X) / 2),
                (int)(point2.Y - (point2.Y - point3.Y) / 2));

            if (lineTypeTriangles)
            {
                graphics.DrawLine(pen, midPoint1, midPoint2);
                graphics.DrawLine(pen, midPoint2, midPoint3);
                graphics.DrawLine(pen, midPoint3, midPoint1);
            }
            else
            {
                graphics.FillEllipse(brush, midPoint1.X, midPoint1.Y, d, d);
                graphics.FillEllipse(brush, midPoint2.X, midPoint2.Y, d, d);
                graphics.FillEllipse(brush, midPoint3.X, midPoint3.Y, d, d);
            }

            iteration--;
            if (iteration > 0)
            {
                DrawTriangleFractal(point1, midPoint1, midPoint2, iteration);
                DrawTriangleFractal(point2, midPoint1, midPoint3, iteration);
                DrawTriangleFractal(point3, midPoint2, midPoint3, iteration);
            }
        }
        #endregion

        #region Tree
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                drawButton2.Enabled = false;
            }
            else
            {
                drawButton2.Enabled = true;
            }
            if (int.TryParse(textBox2.Text, out var parse))
            {
                _length = parse;
            }
        }

        private void DrawButton2_Click(object sender, EventArgs e)
        {
            DrawTreeFractal(panel1.Width / 2, panel1.Height, _length, 10, 0);
        }

        private void DrawTreeFractal(int x, int y, int length, int width, double angleDegree)
        {
            int x1, y1;
            x1 = x - (int)(length * Math.Sin(angleDegree * Math.PI * 2 / 360.0));
            y1 = y - (int)(length * Math.Cos(angleDegree * Math.PI * 2 / 360.0));

            graphics.DrawLine(new Pen(Color.Black, width), x, y, x1, y1);

            if (length > 20)
            {
                DrawTreeFractal(x1, y1, (int)(length * 0.6), (int)(width * 0.8), angleDegree + 45);
                DrawTreeFractal(x1, y1, (int)(length * 0.8), (int)(width * 0.8), angleDegree + 30);
                DrawTreeFractal(x1, y1, (int)(length * 0.8), (int)(width * 0.8), angleDegree - 30);
                DrawTreeFractal(x1, y1, (int)(length * 0.6), (int)(width * 0.8), angleDegree - 45);
            }
        }
        #endregion 
        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lineTypeTriangles = checkBox.Checked;
        }
    }
}
