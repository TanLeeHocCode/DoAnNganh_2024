
namespace GUI
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PhongYes = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pnStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbYes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PhongNo = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnHome = new Guna.UI2.WinForms.Guna2Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_LocCN = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnStatus.SuspendLayout();
            this.pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pie)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PhongYes
            // 
            this.PhongYes.Animated = true;
            this.PhongYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.PhongYes.FillThickness = 18;
            this.PhongYes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhongYes.ForeColor = System.Drawing.Color.Black;
            this.PhongYes.Location = new System.Drawing.Point(39, 264);
            this.PhongYes.Minimum = 0;
            this.PhongYes.Name = "PhongYes";
            this.PhongYes.ProgressColor = System.Drawing.Color.Navy;
            this.PhongYes.ProgressColor2 = System.Drawing.Color.Red;
            this.PhongYes.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.PhongYes.ProgressThickness = 18;
            this.PhongYes.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PhongYes.ShowText = true;
            this.PhongYes.Size = new System.Drawing.Size(170, 170);
            this.PhongYes.TabIndex = 0;
            this.PhongYes.Value = 53;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(178)))), ((int)(((byte)(152)))));
            this.pnStatus.Controls.Add(this.lbNo);
            this.pnStatus.Controls.Add(this.lbYes);
            this.pnStatus.Controls.Add(this.guna2HtmlLabel1);
            this.pnStatus.Controls.Add(this.guna2HtmlLabel3);
            this.pnStatus.Controls.Add(this.guna2HtmlLabel2);
            this.pnStatus.Controls.Add(this.PhongNo);
            this.pnStatus.Controls.Add(this.PhongYes);
            this.pnStatus.Location = new System.Drawing.Point(933, 97);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(522, 471);
            this.pnStatus.TabIndex = 1;
            this.pnStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnStatus_Paint);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = false;
            this.lbNo.BackColor = System.Drawing.Color.White;
            this.lbNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNo.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.ForeColor = System.Drawing.Color.Navy;
            this.lbNo.Location = new System.Drawing.Point(380, 183);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(83, 75);
            this.lbNo.TabIndex = 1;
            this.lbNo.Tag = "";
            this.lbNo.Text = null;
            this.lbNo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYes
            // 
            this.lbYes.AutoSize = false;
            this.lbYes.BackColor = System.Drawing.Color.White;
            this.lbYes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbYes.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYes.ForeColor = System.Drawing.Color.Navy;
            this.lbYes.Location = new System.Drawing.Point(85, 183);
            this.lbYes.Name = "lbYes";
            this.lbYes.Size = new System.Drawing.Size(83, 75);
            this.lbYes.TabIndex = 1;
            this.lbYes.Tag = "";
            this.lbYes.Text = null;
            this.lbYes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(29, 137);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(213, 29);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Số phòng đã cho thuê:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(522, 90);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "DỮ LIỆU PHÒNG";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(313, 137);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(199, 29);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Số phòng còn trống:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhongNo
            // 
            this.PhongNo.Animated = true;
            this.PhongNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.PhongNo.FillThickness = 18;
            this.PhongNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhongNo.ForeColor = System.Drawing.Color.Black;
            this.PhongNo.Location = new System.Drawing.Point(331, 264);
            this.PhongNo.Minimum = 0;
            this.PhongNo.Name = "PhongNo";
            this.PhongNo.ProgressColor = System.Drawing.Color.Yellow;
            this.PhongNo.ProgressColor2 = System.Drawing.Color.Gray;
            this.PhongNo.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.PhongNo.ProgressThickness = 18;
            this.PhongNo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PhongNo.ShowText = true;
            this.PhongNo.Size = new System.Drawing.Size(170, 170);
            this.PhongNo.TabIndex = 0;
            this.PhongNo.Value = 12;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.pnStatus;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.chartDoanhThu);
            this.pnHome.Controls.Add(this.chart_Pie);
            this.pnHome.Location = new System.Drawing.Point(3, 97);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(913, 541);
            this.pnHome.TabIndex = 2;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(913, 541);
            this.chartDoanhThu.TabIndex = 4;
            this.chartDoanhThu.Text = "chart1";
            this.chartDoanhThu.Click += new System.EventHandler(this.chartDoanhThu_Click);
            // 
            // chart_Pie
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Pie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Pie.Legends.Add(legend2);
            this.chart_Pie.Location = new System.Drawing.Point(3, 0);
            this.chart_Pie.Name = "chart_Pie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Pie.Series.Add(series2);
            this.chart_Pie.Size = new System.Drawing.Size(910, 541);
            this.chart_Pie.SuppressExceptions = true;
            this.chart_Pie.TabIndex = 5;
            this.chart_Pie.Text = "chart1";
            // 
            // cb_LocCN
            // 
            this.cb_LocCN.AutoRoundedCorners = true;
            this.cb_LocCN.BackColor = System.Drawing.Color.Transparent;
            this.cb_LocCN.BorderRadius = 17;
            this.cb_LocCN.DisplayMember = "9";
            this.cb_LocCN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LocCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LocCN.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_LocCN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_LocCN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_LocCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_LocCN.ItemHeight = 30;
            this.cb_LocCN.Items.AddRange(new object[] {
            "Doanh thu",
            "Phòng"});
            this.cb_LocCN.Location = new System.Drawing.Point(159, 38);
            this.cb_LocCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_LocCN.Name = "cb_LocCN";
            this.cb_LocCN.Size = new System.Drawing.Size(179, 36);
            this.cb_LocCN.TabIndex = 59;
            this.cb_LocCN.ValueMember = "9";
            this.cb_LocCN.SelectedIndexChanged += new System.EventHandler(this.cb_LocCN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Thống kê:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.cb_LocCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnStatus);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1513, 650);
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnStatus.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PhongYes;
        private Guna.UI2.WinForms.Guna2Panel pnStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbYes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PhongNo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel pnHome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Guna.UI2.WinForms.Guna2ComboBox cb_LocCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pie;
    }
}
