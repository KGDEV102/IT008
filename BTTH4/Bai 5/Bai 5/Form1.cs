using System.ComponentModel;

namespace Bai_5
{
    public partial class Form1 : Form,INotifyPropertyChanged
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;

            toolStripTextBox1.TextBox.DataBindings.Add(new Binding("Text", this, nameof(TimKiem), true, DataSourceUpdateMode.OnPropertyChanged));
        }
        private string timkiem = string.Empty;

        // Exposed property with change notification
        public string TimKiem
        {
            get => timkiem;
            set
            {
                if (timkiem != value)
                {
                    timkiem = value;
                    OnPropertyChanged(nameof(TimKiem));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (formAdd form = new formAdd())
            {
                if (form.ShowDialog() == DialogResult.OK && form.NewSinhVien != null)
                {
                    var sv = form.NewSinhVien;
                    int stt = dataGridView1.Rows.Count + 1;
                    dataGridView1.Rows.Add(stt, sv.MaSoSinhVien, sv.TenSinhVien, sv.Khoa, sv.DiemTB);
                }
            }
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (formAdd form = new formAdd())
            {
                if (form.ShowDialog() == DialogResult.OK && form.NewSinhVien != null)
                {
                    var sv = form.NewSinhVien;
                    int stt = dataGridView1.Rows.Count + 1;
                    dataGridView1.Rows.Add(stt, sv.MaSoSinhVien, sv.TenSinhVien, sv.Khoa, sv.DiemTB);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Use the TimKiem property which is bound to the textbox
            string query = TimKiem?.Trim() ?? string.Empty;

            // Clear previous selection
            dataGridView1.ClearSelection();

            if (string.IsNullOrEmpty(query))
            {
                // nothing to search
                return;
            }

            // Find the first row where TenSV contains the query (case-insensitive)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var cell = row.Cells["TenSV"];
                if (cell?.Value == null) continue;

                string name = cell.Value.ToString()!;
                if (name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Select and scroll into view
                    row.Selected = true;
                    // Set current cell to ensure row is focused
                    dataGridView1.CurrentCell = row.Cells[0];
                    // Scroll so the found row is visible
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            // If no match found, nothing selected
        }
    }
}
