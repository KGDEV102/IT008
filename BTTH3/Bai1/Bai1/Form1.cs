using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        private int eventCounter = 0;
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            LogEvent("Constructor: Form được khởi tạo");
            startTime = DateTime.Now;
        }

        // ==================== SỰ KIỆN KHỞI TẠO ====================

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("Load: Form được load vào bộ nhớ");
            UpdateStatus("Form đã load xong");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("Shown: Form hiển thị lần đầu tiên");
            UpdateStatus("Form đã hiển thị");
        }

        // ==================== SỰ KIỆN FOCUS ====================

        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("Activated: Form được kích hoạt (trở thành form chính)");
            UpdateStatus("Form đang active");
            // Đổi màu title khi active
            lblTitle.BackColor = Color.Navy;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            LogEvent("Deactivate: Form mất trạng thái kích hoạt");
            UpdateStatus("Form bị deactivate");
            // Đổi màu title khi không active
            lblTitle.BackColor = Color.Gray;
        }

        // ==================== SỰ KIỆN THAY ĐỔI ====================

        private void Form1_Move(object sender, EventArgs e)
        {
            LogEvent($"Move: Form di chuyển đến ({this.Location.X}, {this.Location.Y})");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            string state = this.WindowState.ToString();
            LogEvent($"Resize: Form thay đổi kích thước - State: {state}");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            LogEvent($"SizeChanged: Kích thước mới = {this.Width} x {this.Height}");

            // Hiển thị thông báo khi minimize
            if (this.WindowState == FormWindowState.Minimized)
            {
                UpdateStatus("Form đã minimize");
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                UpdateStatus("Form đã maximize");
            }
            else
            {
                UpdateStatus("Form ở trạng thái bình thường");
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            // Event này xảy ra rất nhiều khi di chuyển form
            // Chỉ log nếu cần
        }

        // ==================== SỰ KIỆN VẼ ====================

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            LogEvent("Paint: Form đang được vẽ lại");
        }

        // ==================== SỰ KIỆN ĐÓNG ====================

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent($"FormClosing: Form đang đóng - Lý do: {e.CloseReason}");

            // Hỏi xác nhận trước khi đóng
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // HỦY ĐÓNG FORM
                LogEvent("FormClosing: Người dùng hủy đóng form");
                UpdateStatus("Đã hủy đóng form");
            }
            else
            {
                // Tính thời gian hoạt động
                TimeSpan duration = DateTime.Now - startTime;
                LogEvent($"Form đã hoạt động: {duration.TotalSeconds:F2} giây");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEvent($"FormClosed: Form đã đóng - Lý do: {e.CloseReason}");
            // Lưu log ra file trước khi đóng (nếu cần)
            SaveLogToFile();
        }

        // ==================== XỬ LÝ NÚT CLICK ====================

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            LogEvent(">>> Người dùng click 'Mở Form Mới'");

            // Tạo form con
            Form childForm = new Form
            {
                Text = "Form Con - Dialog",
                Size = new Size(500, 350),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.White
            };

            // Thêm label vào form con
            Label lblChild = new Label
            {
                Text = "Đây là Form Con\n\n" +
                       "Hãy quan sát Log:\n" +
                       "- Form chính sẽ Deactivate\n" +
                       "- Khi đóng form này, Form chính sẽ Activate lại",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkBlue
            };

            childForm.Controls.Add(lblChild);

            LogEvent(">>> Gọi ShowDialog() - Form chính sẽ Deactivate");
            childForm.ShowDialog(); // Hiển thị dạng modal
            LogEvent(">>> Form con đã đóng - Form chính Activate lại");
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Xóa toàn bộ log?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                txtLog.Clear();
                eventCounter = 0;
                LogEvent("========== LOG ĐÃ ĐƯỢC XÓA ==========");
                UpdateStatus("Log đã được xóa");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            LogEvent(">>> Người dùng click nút Minimize");
            this.WindowState = FormWindowState.Minimized;
        }

        // ==================== HELPER METHODS ====================

        private void LogEvent(string message)
        {
            eventCounter++;
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logMessage = $"[{eventCounter:D3}] {timestamp} - {message}\r\n";

            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => txtLog.AppendText(logMessage)));
            }
            else
            {
                txtLog.AppendText(logMessage);
            }

            // Cuộn xuống dòng mới nhất
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void UpdateStatus(string status)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() => lblStatus.Text = status));
            }
            else
            {
                lblStatus.Text = status;
            }
        }

        private void SaveLogToFile()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = $"FormLifecycle_Log_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string filePath = System.IO.Path.Combine(desktopPath, fileName);

                System.IO.File.WriteAllText(filePath, txtLog.Text);
                // Không hiển thị MessageBox ở đây vì form đang đóng
            }
            catch (Exception ex)
            {
                // Log error nhưng không hiển thị UI
                Console.WriteLine($"Lỗi lưu file: {ex.Message}");
            }
        }

        // Dispose đã được định nghĩa trong Form1.Designer.cs
        // Không cần override lại ở đây
    }
}