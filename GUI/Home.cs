using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class Home : UserControl
    {
        BUS_room _bus_r = new BUS_room();
        BUS_Bill _bus_b = new BUS_Bill();
        public Home()
        {
            InitializeComponent();
            Load_chart();
            LoadPieChart();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pnStatus_Paint(object sender, PaintEventArgs e)
        {
            int roomCountY = _bus_r.CountRooms(1);
            int roomCountN = _bus_r.CountRooms(0);
            lbYes.Text = roomCountY.ToString();
            lbNo.Text = roomCountN.ToString();
            int totalRoomCount = roomCountY + roomCountN;
            int percentageY = 0;
            int percentageN = 0;
            if (totalRoomCount != 0)
            {
                percentageY = (int)((roomCountY / (float)totalRoomCount) * 100);
                percentageN = (int)((roomCountN / (float)totalRoomCount) * 100);
            }
            PhongYes.Value = percentageY;
            PhongNo.Value = percentageN;
        }
        private void Load_chart()
        {
            chartDoanhThu.Series.Clear();

            // Add series
            Series series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.SteelBlue,
                BorderColor = System.Drawing.Color.Black,
                BorderWidth = 2,
                IsValueShownAsLabel = true // Hiển thị giá trị cột
            };

            chartDoanhThu.Series.Add(series);

            // Get current year
            int currentYear = DateTime.Now.Year;

            // Add data to chart
            for (int month = 1; month <= 12; month++)
            {
                List<ThongKe> billDetails = _bus_b.LayHoaDonThongKe(month, currentYear);
                int totalRevenue = 0;

                foreach (var detail in billDetails)
                {
                    totalRevenue += detail.GiaTri;
                }

                // Add data point to chart
                series.Points.AddXY(month, totalRevenue); // Sử dụng số tháng thay vì "Tháng X"
            }

            // Configure chart area
            ChartArea chartArea = chartDoanhThu.ChartAreas[0];
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Doanh thu (VND)";
            chartArea.AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartArea.AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartArea.AxisY.LabelStyle.Format = "{0:C}"; // Định dạng số

            // Configure X-axis
            chartArea.AxisX.Interval = 1; // Đảm bảo mỗi tháng có một nhãn
            chartArea.AxisX.IntervalOffset = 1; // Khoảng cách giữa các nhãn
            chartArea.AxisX.LabelStyle.Angle = 0; // Góc nghiêng của nhãn

            // Add grid lines
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Add title
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new Title("Biểu đồ doanh thu theo tháng", Docking.Top, new Font("Arial", 16, FontStyle.Bold), System.Drawing.Color.Black));
        }

        private void cb_LocCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_LocCN.Text == "Doanh thu")
            {
                chartDoanhThu.Visible = true;
                chart_Pie.Visible = false;
            }
            else
            {
                chartDoanhThu.Visible = false;
                chart_Pie.Visible = true;
            }
        }
        private void LoadPieChart()
        {
            Dictionary<string, int> roomData = _bus_r.GetRoomCountByType();

            // Xóa dữ liệu cũ (nếu có)
            chart_Pie.Series.Clear();

            // Tạo Series mới với dạng biểu đồ tròn
            Series series = new Series
            {
                Name = "Rooms",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            chart_Pie.Series.Add(series);

            // Tổng số phòng để tính phần trăm
            int totalRooms = roomData.Values.Sum();

            // Thêm dữ liệu vào biểu đồ và hiển thị số lượng và phần trăm phòng trên biểu đồ
            foreach (var roomType in roomData)
            {
                // Tính tỷ lệ phần trăm cho mỗi loại phòng
                double percentage = (double)roomType.Value / totalRooms * 100;

                DataPoint point = new DataPoint();
                point.AxisLabel = roomType.Key;
                point.YValues = new double[] { roomType.Value };

                // Hiển thị cả số lượng phòng và tỷ lệ phần trăm trên từng phần của biểu đồ
                point.Label = $"{percentage:F2}%";  // Hiển thị tỉ lệ phần trăm (2 chữ số sau dấu thập phân)
                point.LegendText = $"{roomType.Key}: {roomType.Value}"; // Hiển thị trong chú thích (tên loại phòng và số lượng)

                series.Points.Add(point);
            }

            // Thiết lập các tùy chọn cho biểu đồ (hiển thị tỉ lệ phần trăm, v.v.)
            series["PieLabelStyle"] = "Outside"; // Đặt nhãn bên ngoài biểu đồ tròn
            series.BorderWidth = 1;
            series.BorderColor = System.Drawing.Color.Black;

            // Hiển thị chú thích cho các loại phòng
            chart_Pie.Legends[0].Enabled = true;

            // Tăng kích thước font cho nhãn (tỷ lệ phần trăm)
            series.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            // Tăng kích thước các phần của biểu đồ tròn (Pie chart)
            chart_Pie.ChartAreas[0].Area3DStyle.Enable3D = true; // Bật chế độ 3D (tùy chọn)
            chart_Pie.ChartAreas[0].Area3DStyle.Inclination = 30; // Điều chỉnh góc độ 3D (tùy chọn)
            chart_Pie.ChartAreas[0].BackColor = System.Drawing.Color.Transparent; // Làm nền trong suốt

            // Tăng kích thước của biểu đồ (phần bên trong)
            chart_Pie.ChartAreas[0].Position = new ElementPosition(0, 0, 90, 90); // Chiếm 90% diện tích của control
        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
