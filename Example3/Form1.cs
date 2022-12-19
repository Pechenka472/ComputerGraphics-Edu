using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.mariuszgromada.math.mxparser;

namespace LR3_WinFormsCharts
{
    public partial class Form1 : Form
    {
        private int _maxX;
        private int _maxY;
        private float _step;
        private SeriesChartType _seriesChartType = SeriesChartType.Spline;
        private List<string> _equations;
        
        private readonly Random _rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equationList.Text = string.Empty;
            chart1.Series.Clear();

            _equations = new List<string>();

            var axisX = new Axis();
            axisX.Title = "  X";
            chart1.ChartAreas[0].AxisX = axisX;
            var axisY = new Axis();
            axisY.Title = "  Y";
            chart1.ChartAreas[0].AxisY = axisY;

            UpdateAsis();

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
        }

        private void OnClickAddFormulaButton(object sender, EventArgs e)
        {
            if (equationText.Text == null) return;
            if (_equations.Find(x => x.Contains(equationText.Text)) != null) return;
            
            _equations.Add(equationText.Text);
            
            equationList.Text += GetEquationName(equationText.Text);

            chart1.Series.Add(CalculateEquation(equationText.Text));
        }

        private void OnClickUpdateButton(object sender, EventArgs e)
        {
            if (_equations.Count == 0) return;
            
            UpdateAsis();
            UpdateChart();
        }
        
        private void OnClickClearButton(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            _equations.Clear();
            equationList.Text = string.Empty;
        }
        
        private void OnClickChangeSeriesType(object sender, EventArgs e)
        {
            _seriesChartType = (SeriesChartType)_rnd.Next(0, Enum.GetNames(typeof(SeriesChartType)).Length);
            var seriesCollection = new List<Series>(chart1.Series);
            chart1.Series.Clear();
            
            foreach (Series series in seriesCollection)
            {
                series.ChartType = _seriesChartType;
                chart1.Series.Add(series);
            }
        }

        private void UpdateChart()
        {
            chart1.Series.Clear();

            foreach (Series series in _equations.Select(CalculateEquation))
            {
                chart1.Series.Add(series);
            }
        }

        private Series CalculateEquation(string equation)
        {
            var series = new Series(GetEquationName(equation));
            series.ChartType = _seriesChartType;

            for (double i = -_maxX; i < _maxX; i += _step)
            {
                var substitution = equation.Replace("x", $"{i}").Replace(",", ".");
                var expression = new Expression(substitution);
                var y = expression.calculate();
                    
                if (y > _maxY || y < -_maxY) continue;
                    
                series.Points.AddXY(i, y);
            }

            return series;
        }

        private static string GetEquationName(string equation)
        {
            return "y = " + equation + "\n";
        }
        
        private void UpdateAsis()
        {
            int.TryParse(textBox5.Text, out var newMaxX);
            int.TryParse(textBox6.Text, out var newMaxY);
            var textNewStep = textBox2.Text;
            float.TryParse(textNewStep.Replace(".", ","), out var newStep);
            
            _maxY = newMaxX == 0 ? _maxX : newMaxX;
            _maxX = newMaxY == 0 ? _maxX : newMaxY;
            _step = newStep == 0 ? _step : newStep;

            SetAsisExtremes();
        }

        private void SetAsisExtremes()
        {
            chart1.ChartAreas[0].AxisX.Minimum = -_maxX;
            chart1.ChartAreas[0].AxisX.Maximum = _maxX;
            chart1.ChartAreas[0].AxisY.Minimum = -_maxY;
            chart1.ChartAreas[0].AxisY.Maximum = _maxY;
        }
    }
}
