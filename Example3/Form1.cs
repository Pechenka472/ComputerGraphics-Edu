using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LR3_WinFormsCharts
{
    public partial class Form1 : Form
    {
        private int leftBound = -10;
        private int rightBound = 10;
        private float step = .1f;

        private List<string> legends = new List<string>();

        private List<float[]> formulas = new List<float[]>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formulasLabel.Text = string.Empty;
            chart1.Series.Clear();

            var axisX = new Axis();
            axisX.Title = "  X";
            chart1.ChartAreas[0].AxisX = axisX;
            var axisY = new Axis();
            axisY.Title = "  Y";
            chart1.ChartAreas[0].AxisY = axisY;

            chart1.ChartAreas[0].AxisX.Minimum = leftBound;
            chart1.ChartAreas[0].AxisX.Maximum = rightBound;
            chart1.ChartAreas[0].AxisY.Minimum = leftBound;
            chart1.ChartAreas[0].AxisY.Maximum = rightBound;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void updateAsisButton_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out var newRightBound);
            int.TryParse(textBox1.Text, out var newLeftBound);
            
            rightBound = newRightBound == 0 ? leftBound : newRightBound;
            leftBound = newLeftBound == 0 ? leftBound : newLeftBound;
        }

        private void addFormulaButton_Click(object sender, EventArgs e)
        {
            var temp = 0f;

            float.TryParse(textBox1.Text, out temp);
            k = temp == 0 ? 1 : temp;

            float.TryParse(textBox2.Text, out temp);
            power = temp == 0 ? 1 : temp;

            float.TryParse(textBox3.Text, out b);
            float.TryParse(textBox4.Text, out plusXKoeff);

            formulas.Add(new float[] { k, power, b, plusXKoeff });

            formulasLabel.Text = "";
            for (int i = 0; i < formulas.Count; i++)
            {
                var text = "";
                if (formulas[i][3] == 0) 
                {
                    text = $"y = {(formulas[i][0] == 1 ? string.Empty : formulas[i][0].ToString())}x" +
                    $"{(formulas[i][1] == 1 ? "" : " ^ " + formulas[i][1])}" +
                    $"{(formulas[i][2] == 0 ? "" : (formulas[i][2] > 0 ? " + " + formulas[i][2] : " - " + -formulas[i][2]))} \n";

                    formulasLabel.Text += text;
                }
                else
                {
                    text = $"y = {(formulas[i][0] == 1 ? string.Empty : formulas[i][0].ToString())}(x" +
                    $"{(formulas[i][3] < 0 ? " - " + -formulas[i][3] : " + " + formulas[i][3])})" +
                    $"{(formulas[i][1] == 1 ? "" : " ^ " + formulas[i][1])}" +
                    $"{(formulas[i][2] == 0 ? "" : (formulas[i][2] > 0 ? " + " + formulas[i][2] : " - " + -formulas[i][2]))} \n";

                    formulasLabel.Text += text;
                }
                legends.Add(text);
            }

            drawButton.Enabled = true;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (formulas.Count == 0) return;

            AddNewSeries();
            drawButton.Enabled = false;
        }

        private void AddNewSeries()
        {
            Series newSeries = new Series(legends[legends.Count - 1]);

            chart1.Series.Add(newSeries);
            chart1.Series[formulas.Count - 1].ChartType = SeriesChartType.Spline;
            //chart1.Series[formulas.Count - 1] = SeriesChartType.Spline;

            float x = leftBound;
            float y = 0f;

            while (x <= rightBound)
            {
                for(int i = 0; i < formulas.Count; i++)
                {
                    y = formulas[i][0] * (float)Math.Pow(x + formulas[i][3], formulas[i][1]) + formulas[i][2];
                    chart1.Series[i].Points.AddXY(x, y);
                }
                x += step;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            formulas.Clear();
            formulasLabel.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (Series s in chart1.Series)
            {
                s.ChartType = (SeriesChartType)rnd.Next(0, Enum.GetNames(typeof(SeriesChartType)).Length);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
