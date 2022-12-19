namespace LR3_WinFormsCharts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.equationList = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.equationText = new System.Windows.Forms.TextBox();
            this.addFormulaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.changeSeriesType = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.equationList);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Location = new System.Drawing.Point(8, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 233);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Формулы";
            // 
            // equationList
            // 
            this.equationList.Location = new System.Drawing.Point(7, 20);
            this.equationList.Name = "equationList";
            this.equationList.Size = new System.Drawing.Size(193, 174);
            this.equationList.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(27, 197);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 30);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить все";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClickClearButton);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(224, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 465);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Диаграмма";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 429);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, -1);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(468, 439);
            this.chart1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.equationText);
            this.groupBox1.Controls.Add(this.addFormulaButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление типа y = f(x)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y  =";
            // 
            // equationText
            // 
            this.equationText.Location = new System.Drawing.Point(41, 20);
            this.equationText.Name = "equationText";
            this.equationText.Size = new System.Drawing.Size(147, 20);
            this.equationText.TabIndex = 5;
            // 
            // addFormulaButton
            // 
            this.addFormulaButton.Location = new System.Drawing.Point(43, 49);
            this.addFormulaButton.Name = "addFormulaButton";
            this.addFormulaButton.Size = new System.Drawing.Size(116, 23);
            this.addFormulaButton.TabIndex = 1;
            this.addFormulaButton.Text = "Добавить формулу";
            this.addFormulaButton.UseVisualStyleBackColor = true;
            this.addFormulaButton.Click += new System.EventHandler(this.OnClickAddFormulaButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(34, 390);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(163, 33);
            this.drawButton.TabIndex = 11;
            this.drawButton.Text = "Обновить";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.OnClickUpdateButton);
            // 
            // changeSeriesType
            // 
            this.changeSeriesType.Location = new System.Drawing.Point(34, 429);
            this.changeSeriesType.Name = "changeSeriesType";
            this.changeSeriesType.Size = new System.Drawing.Size(163, 35);
            this.changeSeriesType.TabIndex = 12;
            this.changeSeriesType.Text = "Сменить график";
            this.changeSeriesType.UseVisualStyleBackColor = true;
            this.changeSeriesType.Click += new System.EventHandler(this.OnClickChangeSeriesType);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(8, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 45);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оси";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "0.5";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(124, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Step";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(68, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "10";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "10";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Очистить все";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.changeSeriesType);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label equationList;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFormulaButton;
        private System.Windows.Forms.TextBox equationText;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button changeSeriesType;
    }
}

