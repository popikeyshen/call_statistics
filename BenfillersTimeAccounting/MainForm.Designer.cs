namespace BenfillersTimeAccounting
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.tabPageCalls = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCalls = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxCallsRange = new System.Windows.Forms.ComboBox();
            this.tabPageTimes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReactionsRange = new System.Windows.Forms.ComboBox();
            this.chartReactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бенфиллерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кухниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControlStatistics.SuspendLayout();
            this.tabPageCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalls)).BeginInit();
            this.tabPageTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReactions)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControlStatistics);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(867, 504);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(867, 528);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // tabControlStatistics
            // 
            this.tabControlStatistics.Controls.Add(this.tabPageCalls);
            this.tabControlStatistics.Controls.Add(this.tabPageTimes);
            this.tabControlStatistics.Controls.Add(this.tabPage1);
            this.tabControlStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStatistics.Location = new System.Drawing.Point(0, 0);
            this.tabControlStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlStatistics.Name = "tabControlStatistics";
            this.tabControlStatistics.SelectedIndex = 0;
            this.tabControlStatistics.Size = new System.Drawing.Size(867, 504);
            this.tabControlStatistics.TabIndex = 0;
            // 
            // tabPageCalls
            // 
            this.tabPageCalls.Controls.Add(this.label1);
            this.tabPageCalls.Controls.Add(this.chartCalls);
            this.tabPageCalls.Controls.Add(this.comboBoxCallsRange);
            this.tabPageCalls.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalls.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCalls.Name = "tabPageCalls";
            this.tabPageCalls.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCalls.Size = new System.Drawing.Size(859, 478);
            this.tabPageCalls.TabIndex = 0;
            this.tabPageCalls.Text = "Количество обращений";
            this.tabPageCalls.UseVisualStyleBackColor = true;
            this.tabPageCalls.Enter += new System.EventHandler(this.tabPageCalls_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество подтвержденных вызовов за";
            // 
            // chartCalls
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chartCalls.ChartAreas.Add(chartArea1);
            this.chartCalls.Location = new System.Drawing.Point(70, 79);
            this.chartCalls.Margin = new System.Windows.Forms.Padding(2);
            this.chartCalls.Name = "chartCalls";
            this.chartCalls.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsVisibleInLegend = false;
            series1.Label = "#VAL{G7}";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCalls.Series.Add(series1);
            this.chartCalls.Size = new System.Drawing.Size(456, 275);
            this.chartCalls.TabIndex = 1;
            this.chartCalls.Text = "chart1";
            this.chartCalls.Click += new System.EventHandler(this.chartCalls_Click);
            // 
            // comboBoxCallsRange
            // 
            this.comboBoxCallsRange.FormattingEnabled = true;
            this.comboBoxCallsRange.Location = new System.Drawing.Point(437, 44);
            this.comboBoxCallsRange.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCallsRange.Name = "comboBoxCallsRange";
            this.comboBoxCallsRange.Size = new System.Drawing.Size(62, 21);
            this.comboBoxCallsRange.TabIndex = 0;
            this.comboBoxCallsRange.SelectedValueChanged += new System.EventHandler(this.comboBoxRange_SelectedValueChanged);
            // 
            // tabPageTimes
            // 
            this.tabPageTimes.Controls.Add(this.label2);
            this.tabPageTimes.Controls.Add(this.comboBoxReactionsRange);
            this.tabPageTimes.Controls.Add(this.chartReactions);
            this.tabPageTimes.Location = new System.Drawing.Point(4, 22);
            this.tabPageTimes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTimes.Name = "tabPageTimes";
            this.tabPageTimes.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTimes.Size = new System.Drawing.Size(859, 478);
            this.tabPageTimes.TabIndex = 1;
            this.tabPageTimes.Text = "Среднее время реакции";
            this.tabPageTimes.UseVisualStyleBackColor = true;
            this.tabPageTimes.Enter += new System.EventHandler(this.tabPageTimes_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Среднее время реакции мин за";
            // 
            // comboBoxReactionsRange
            // 
            this.comboBoxReactionsRange.FormattingEnabled = true;
            this.comboBoxReactionsRange.Location = new System.Drawing.Point(466, 28);
            this.comboBoxReactionsRange.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxReactionsRange.Name = "comboBoxReactionsRange";
            this.comboBoxReactionsRange.Size = new System.Drawing.Size(62, 21);
            this.comboBoxReactionsRange.TabIndex = 3;
            this.comboBoxReactionsRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxReactionsRange_SelectedIndexChanged);
            this.comboBoxReactionsRange.SelectedValueChanged += new System.EventHandler(this.comboBoxReactionsRange_SelectedValueChanged);
            // 
            // chartReactions
            // 
            this.chartReactions.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelStyle.Interval = 1D;
            chartArea2.AxisY.Title = "мин";
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.chartReactions.ChartAreas.Add(chartArea2);
            this.chartReactions.Location = new System.Drawing.Point(80, 65);
            this.chartReactions.Margin = new System.Windows.Forms.Padding(2);
            this.chartReactions.Name = "chartReactions";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Label = "#VAL{G7}";
            series2.Name = "Series1";
            this.chartReactions.Series.Add(series2);
            this.chartReactions.Size = new System.Drawing.Size(476, 266);
            this.chartReactions.TabIndex = 0;
            this.chartReactions.Text = "chart1";
            this.chartReactions.Click += new System.EventHandler(this.chartReactions_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 478);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Статистика по человеку";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "to excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "от";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 412);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(634, 412);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время события";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время реакции, минут";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(112, 70);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.IsVisibleInLegend = false;
            series3.Label = "#VAL{G7}";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(610, 337);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кнопкиToolStripMenuItem,
            this.бенфиллерыToolStripMenuItem,
            this.приемникToolStripMenuItem,
            this.кухниToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // кнопкиToolStripMenuItem
            // 
            this.кнопкиToolStripMenuItem.Name = "кнопкиToolStripMenuItem";
            this.кнопкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.кнопкиToolStripMenuItem.Text = "Кнопки";
            this.кнопкиToolStripMenuItem.Click += new System.EventHandler(this.кнопкиToolStripMenuItem_Click);
            // 
            // бенфиллерыToolStripMenuItem
            // 
            this.бенфиллерыToolStripMenuItem.Name = "бенфиллерыToolStripMenuItem";
            this.бенфиллерыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.бенфиллерыToolStripMenuItem.Text = "Официанты";
            this.бенфиллерыToolStripMenuItem.Click += new System.EventHandler(this.бенфиллерыToolStripMenuItem_Click);
            // 
            // приемникToolStripMenuItem
            // 
            this.приемникToolStripMenuItem.Name = "приемникToolStripMenuItem";
            this.приемникToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.приемникToolStripMenuItem.Text = "Приемник";
            this.приемникToolStripMenuItem.Click += new System.EventHandler(this.приемникToolStripMenuItem_Click);
            // 
            // кухниToolStripMenuItem
            // 
            this.кухниToolStripMenuItem.Name = "кухниToolStripMenuItem";
            this.кухниToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.кухниToolStripMenuItem.Text = "Кухни";
            this.кухниToolStripMenuItem.Click += new System.EventHandler(this.кухниToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 528);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Контроль времени вызовов официантов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControlStatistics.ResumeLayout(false);
            this.tabPageCalls.ResumeLayout(false);
            this.tabPageCalls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalls)).EndInit();
            this.tabPageTimes.ResumeLayout(false);
            this.tabPageTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReactions)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кнопкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бенфиллерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемникToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage tabPageCalls;
        private System.Windows.Forms.TabPage tabPageTimes;
        private System.Windows.Forms.ComboBox comboBoxCallsRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReactionsRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReactions;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кухниToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;

        public System.IO.Ports.SerialPort SerialPortMain
        {
            get { return serialPort1; }
            set { serialPort1 = value; }
        }
    }
}

