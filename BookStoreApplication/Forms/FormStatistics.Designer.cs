namespace BookStoreApplication.Forms
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Count = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Revenue
            // 
            this.chart_Revenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend1);
            this.chart_Revenue.Location = new System.Drawing.Point(31, 26);
            this.chart_Revenue.Name = "chart_Revenue";
            this.chart_Revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            series1.YValuesPerPoint = 2;
            this.chart_Revenue.Series.Add(series1);
            this.chart_Revenue.Size = new System.Drawing.Size(1000, 400);
            this.chart_Revenue.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "Revenue chart for the last month";
            this.chart_Revenue.Titles.Add(title1);
            // 
            // chart_Count
            // 
            this.chart_Count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart_Count.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Count.Legends.Add(legend2);
            this.chart_Count.Location = new System.Drawing.Point(31, 445);
            this.chart_Count.Name = "chart_Count";
            this.chart_Count.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Count";
            series2.YValuesPerPoint = 2;
            this.chart_Count.Series.Add(series2);
            this.chart_Count.Size = new System.Drawing.Size(1000, 400);
            this.chart_Count.TabIndex = 1;
            title2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title";
            title2.Text = "Chart of the number of items sold in the last month";
            this.chart_Count.Titles.Add(title2);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 897);
            this.Controls.Add(this.chart_Count);
            this.Controls.Add(this.chart_Revenue);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Count;
    }
}