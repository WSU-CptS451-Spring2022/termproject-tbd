
namespace YelpApp_v1
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.checkinsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // checkinsChart
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.checkinsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.checkinsChart.Legends.Add(legend2);
            this.checkinsChart.Location = new System.Drawing.Point(12, 12);
            this.checkinsChart.Name = "checkinsChart";
            this.checkinsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "CheckIns";
            this.checkinsChart.Series.Add(series2);
            this.checkinsChart.Size = new System.Drawing.Size(810, 430);
            this.checkinsChart.TabIndex = 0;
            this.checkinsChart.Text = "checkinsChart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            title2.Name = "CheckIns by Month";
            title2.Text = "CheckIns by Month";
            this.checkinsChart.Titles.Add(title2);
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(331, 448);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(135, 46);
            this.checkinButton.TabIndex = 1;
            this.checkinButton.Text = "Check In";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 531);
            this.Controls.Add(this.checkinButton);
            this.Controls.Add(this.checkinsChart);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.checkinsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart checkinsChart;
        private System.Windows.Forms.Button checkinButton;
    }
}