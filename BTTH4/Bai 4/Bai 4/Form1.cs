using System.Drawing.Text;
using System.Drawing;
namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFontAndSize();

        }
        private string currentFilePath = null;
        public Font resetFont = new Font("Tahoma", 14, FontStyle.Regular);
        // Hàm hỗ trợ để cập nhật trạng thái của Toolbar
        private void UpdateToolbarState(Font currentFont)
        {
            // Cập nhật ComboBox Font/Size
            toolStripComboBox1.Text = currentFont.FontFamily.Name;
            toolStripComboBox2.Text = currentFont.Size.ToString();

            // Cập nhật trạng thái nút B/I/U
            toolStripButton3.Checked = currentFont.Bold;
            toolStripButton4.Checked = currentFont.Italic;
            toolStripButton5.Checked = currentFont.Underline;
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionFont != null)
            {
                UpdateToolbarState(richTextBox1.SelectionFont);
            }
        }

        private void LoadFontAndSize()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            if (toolStripComboBox1.Items.Contains("Tahoma"))
            {
                toolStripComboBox1.Text = "Tahoma";
            }
            else
            {
                toolStripComboBox1.SelectedIndex = 0;
            }

            // Thiết lập tính năng tự động hoàn thành cho toolStripComboBox1:
            toolStripComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                toolStripComboBox2.Items.Add(size.ToString());
            }
            toolStripComboBox2.Text = "14";

            toolStripComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void điToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            if (richTextBox1.SelectionFont != null)
            {
                fontDialog.Font = richTextBox1.SelectionFont;
            }
            else
            {

                fontDialog.Font = resetFont;

            }
            fontDialog.Color = richTextBox1.SelectionColor;
            fontDialog.ShowEffects = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng Font và Color đã chọn
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;


                UpdateToolbarState(fontDialog.Font);

                richTextBox1.Focus();
            }


        }


        private void tạoVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = resetFont;
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
            //4.Cập nhật trạng thái hiển thị của các nút B / I / U và ComboBoxes
            UpdateToolbarState(resetFont);
            richTextBox1.Focus();
            currentFilePath = null;

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = resetFont;
            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
            //4.Cập nhật trạng thái hiển thị của các nút B / I / U và ComboBoxes
            UpdateToolbarState(resetFont);
            richTextBox1.Focus();
            currentFilePath = null;

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;



            Font newFont = new Font(toolStripComboBox1.Text, currentFont.Size, currentFont.Style);
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();


        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)

        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            float newSize = float.Parse(toolStripComboBox2.Text);


            Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();

        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;

            try
            {
                // Kiểm tra Font hợp lệ (như bạn đã làm)
                using (Font tempFont = new Font(toolStripComboBox1.Text, 8))
                {
                    // TẠO FONT MỚI: Giữ nguyên KÍCH THƯỚC và STYLE hiện tại
                    Font newFont = new Font(toolStripComboBox1.Text, currentFont.Size, currentFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Bold)
            {
                // Nếu đã đậm, TẮT chế độ đậm.
                newStyle = currentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                // Nếu chưa đậm, BẬT chế độ đậm.
                newStyle = currentFont.Style | FontStyle.Bold;
            }


            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
            toolStripButton3.Checked = newStyle.HasFlag(FontStyle.Bold);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Italic)
            {

                newStyle = currentFont.Style & ~FontStyle.Italic;
            }
            else
            {

                newStyle = currentFont.Style | FontStyle.Italic;
            }


            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
            toolStripButton4.Checked = newStyle.HasFlag(FontStyle.Italic);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Underline)
            {

                newStyle = currentFont.Style & ~FontStyle.Underline;
            }
            else
            {

                newStyle = currentFont.Style | FontStyle.Underline;
            }


            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newStyle
            );
            toolStripButton5.Checked = newStyle.HasFlag(FontStyle.Underline);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp văn bản để mở";
            openFileDialog.Filter = "Tệp tin Văn bản (*.rtf;*.txt)|*.rtf;*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn tệp tin đã chọn
                    string filePath = openFileDialog.FileName;

                    // Kiểm tra loại tệp tin để quyết định cách tải
                    if (filePath.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        // Tải tệp tin RTF (giữ nguyên định dạng)
                        richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Tải các tệp tin văn bản khác (ví dụ: .txt) dưới dạng Plain Text
                        richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    }

                    // Đặt lại con trỏ về đầu và xóa định dạng đang chọn
                    richTextBox1.Select(0, 0);

                    // Sau khi tải tệp mới, nên cập nhật trạng thái của thanh công cụ
                    // Gọi hàm xử lý SelectionChanged thủ công để cập nhật B/I/U và ComboBoxes
                    UpdateToolbarState(resetFont);
                    currentFilePath = filePath;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có vấn đề khi tải tệp
                    MessageBox.Show("Không thể mở tệp tin: " + ex.Message, "Lỗi Tải Tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveAsDocument()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Title = "Lưu tệp tin Rich Text Format";


            saveFileDialog.Filter = "Tệp tin Rich Text Format (*.rtf)|*.rtf|Tất cả tệp tin (*.*)|*.*";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn tệp tin mới đã chọn
                    string newFilePath = saveFileDialog.FileName;

                    // Lưu nội dung RichTextBox vào đường dẫn mới
                    richTextBox1.SaveFile(newFilePath, RichTextBoxStreamType.RichText);

                    // Cập nhật đường dẫn hiện tại để lần sau chỉ cần nhấn Lưu (Trường hợp A)
                    currentFilePath = newFilePath;

                    MessageBox.Show($"Đã lưu văn bản thành công vào đường dẫn:\n{newFilePath}",
                                    "Lưu Thành Công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu tệp tin: {ex.Message}",
                                    "Lỗi Lưu Tệp",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
        private void SaveDocument()
        {
            // 1. KIỂM TRA: Đây có phải là tệp tin ĐÃ MỞ/LƯU TRƯỚC ĐÓ KHÔNG?
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                // Trường hợp A: ĐÃ CÓ đường dẫn tệp tin (Đã mở hoặc đã lưu)
                try
                {
                    // Lưu trực tiếp nội dung RichTextBox vào đường dẫn đã có
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);

                    // Thông báo lưu thành công
                    MessageBox.Show($"Đã lưu văn bản thành công vào đường dẫn:\n{currentFilePath}",
                                    "Lưu Thành Công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu tệp tin: {ex.Message}",
                                    "Lỗi Lưu Tệp",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                // Trường hợp B: Tệp tin CHƯA BAO GIỜ được lưu (currentFilePath == null)
                // Hiển thị SaveFileDialog
                SaveAsDocument();
            }
        }

        private void lưuNộiDungVănBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
