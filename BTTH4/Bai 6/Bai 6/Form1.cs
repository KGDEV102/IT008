namespace Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resourceFolder = string.Empty;
        string destinationFolder = string.Empty;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var src = new FolderBrowserDialog();
            src.Description = "Chọn thư mục nguồn";
            if (src.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(src.SelectedPath))
            {
                resourceFolder = src.SelectedPath;
                textBox1.Text = resourceFolder;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var dest = new FolderBrowserDialog();
            dest.Description = "Chọn thư mục đích";
            if (dest.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dest.SelectedPath))
            {
                destinationFolder = dest.SelectedPath;
                textBox2.Text = destinationFolder;
            }
        }
        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            // Lấy tất cả các tệp trong thư mục nguồn (bao gồm cả thư mục con nếu dùng hàm đệ quy)
            string[] files = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);

            // Đặt giá trị tối đa cho ProgressBar bằng tổng số tệp
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = files.Length;
                progressBar1.Value = 0;
            });

            int fileCount = 0;
            foreach (string filePath in files)
            {
                // Tính toán đường dẫn tương đối để tái tạo cấu trúc thư mục
                string relativePath = filePath.Substring(sourceDir.Length).TrimStart('\\');
                string destFilePath = Path.Combine(destinationDir, relativePath);

                // Đảm bảo thư mục đích cho tệp này tồn tại
                string destFolder = Path.GetDirectoryName(destFilePath);
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                // Cập nhật tên tệp đang sao chép (Sử dụng Invoke vì đang ở luồng nền)
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = $"Đang Sao Chép: {destFilePath}";
                });

                // Sao chép tệp (sao chép đè nếu tệp đã tồn tại)
                File.Copy(filePath, destFilePath, true);

                // Tăng số lượng tệp đã sao chép và cập nhật ProgressBar
                fileCount++;
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = fileCount;
                });
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(resourceFolder) || !Directory.Exists(destinationFolder))
            {
                MessageBox.Show("Vui lòng chọn đúng thư mục nguồn và thư mục đích!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button3.Enabled = false;
          
            try
            {
                Task.Run(() => CopyDirectory(resourceFolder, destinationFolder));


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button3.Enabled = true;
                

            }
        }
    }
}
