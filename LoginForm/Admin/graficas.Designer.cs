namespace LoginForm.Admin
{
    partial class graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart1 = new System.Windows.Forms.Button();
            this.btnChart3 = new System.Windows.Forms.Button();
            this.btnChart2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(60, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(523, 434);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnChart1
            // 
            this.btnChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChart1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChart1.FlatAppearance.BorderSize = 0;
            this.btnChart1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart1.ForeColor = System.Drawing.Color.White;
            this.btnChart1.Location = new System.Drawing.Point(704, 109);
            this.btnChart1.Name = "btnChart1";
            this.btnChart1.Size = new System.Drawing.Size(132, 64);
            this.btnChart1.TabIndex = 32;
            this.btnChart1.Text = "Mensajes / Tiempo";
            this.btnChart1.UseVisualStyleBackColor = false;
            this.btnChart1.Click += new System.EventHandler(this.btnChart1_Click);
            // 
            // btnChart3
            // 
            this.btnChart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnChart3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChart3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChart3.FlatAppearance.BorderSize = 0;
            this.btnChart3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChart3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart3.ForeColor = System.Drawing.Color.White;
            this.btnChart3.Location = new System.Drawing.Point(704, 294);
            this.btnChart3.Name = "btnChart3";
            this.btnChart3.Size = new System.Drawing.Size(132, 64);
            this.btnChart3.TabIndex = 33;
            this.btnChart3.Text = "Mensajes: Estudiantes - Maestros";
            this.btnChart3.UseVisualStyleBackColor = false;
            this.btnChart3.Click += new System.EventHandler(this.btnChart3_Click);
            // 
            // btnChart2
            // 
            this.btnChart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(152)))), ((int)(((byte)(213)))));
            this.btnChart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChart2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChart2.FlatAppearance.BorderSize = 0;
            this.btnChart2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart2.ForeColor = System.Drawing.Color.White;
            this.btnChart2.Location = new System.Drawing.Point(704, 207);
            this.btnChart2.Name = "btnChart2";
            this.btnChart2.Size = new System.Drawing.Size(132, 64);
            this.btnChart2.TabIndex = 34;
            this.btnChart2.Text = "Habilitados / Inhabilitados";
            this.btnChart2.UseVisualStyleBackColor = false;
            this.btnChart2.Click += new System.EventHandler(this.btnChart2_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(60, 40);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(523, 434);
            this.chart2.TabIndex = 35;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(60, 40);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(523, 434);
            this.chart3.TabIndex = 36;
            this.chart3.Text = "chart3";
            this.chart3.Visible = false;
            // 
            // graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnChart2);
            this.Controls.Add(this.btnChart3);
            this.Controls.Add(this.btnChart1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "graficas";
            this.Text = "grafico1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Button btnChart1;
        public System.Windows.Forms.Button btnChart3;
        public System.Windows.Forms.Button btnChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}