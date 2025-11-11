using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged    
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            myDataGrid.ItemsSource = danhSach;
            danhSach.CollectionChanged += (s, e) => UpdateTotal();
            danhSach.CollectionChanged += (s, e) => updateSTT();
            danhSach.Add(new TaiKhoan {  MaTaiKhoan = "TK001", TenKhachHang = "Nguyen Van A", DiaChi = "Ha Noi", SoTien ="10000" });
            danhSach.Add(new TaiKhoan { MaTaiKhoan = "TK002", TenKhachHang = "Tran Thi B", DiaChi = "Da Nang", SoTien = "10000" });
        }
        ObservableCollection<TaiKhoan> danhSach = new ObservableCollection<TaiKhoan>();
        private void UpdateTotal()
        {
            double sum = 0;

            foreach (var item in danhSach)
            {
                if (double.TryParse(item.SoTien, out double soTien))
                {
                    sum += soTien;
                }
            }

            ToTal = sum;
        }
        private void updateSTT()
        {
            danhSach[danhSach.Count - 1].STT = danhSach.Count ;
        }
        public class TaiKhoan
        {
            public int STT { get; set; }
            public string MaTaiKhoan { get; set; }
            public string TenKhachHang { get; set; }
            public string DiaChi { get; set; }
            public string SoTien { get; set; }
        }
       

       

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int soTT;
        public int STT
        {
            get => soTT;
            set
            {
                soTT = value;
                OnPropertyChanged();
            }
        }
        private string soTaiKhoan;
        public string SoTaiKhoan
        {
            get => soTaiKhoan;
            set
            {
                soTaiKhoan = value;
                OnPropertyChanged();
            }
        }
        private string tenKhachHang;
        public string TenKhachHang
        {
            get => tenKhachHang;
            set
            {
                tenKhachHang = value;
                OnPropertyChanged();
            }
        }
        private string diaChi;
        public string DiaChi
        {
            get => diaChi;
            set
            {
                diaChi = value;
                OnPropertyChanged();
            }
        }
        private string soTien;
        public string SoTien
        {
            get => soTien;
            set
            {
                soTien = value;
                OnPropertyChanged();
            }
        }
        private double total=0;
        public double ToTal
        {
            get => total;
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Keyboard.ClearFocus(); // Cập nhật các TextBox
                                   // Force cập nhật các TextBox đang focus vào property
                                   // Force update binding để TextBox đang focus được cập nhật
            SoTaiKhoanTextBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
            TenKhachHangTextBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
            DiaChiTextBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
            SoTienTextBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();

            int filledCount = 0;
            if (!string.IsNullOrWhiteSpace(SoTaiKhoan)) filledCount++;
            if (!string.IsNullOrWhiteSpace(TenKhachHang)) filledCount++;
            if (!string.IsNullOrWhiteSpace(DiaChi)) filledCount++;
            if (!string.IsNullOrWhiteSpace(SoTien)) filledCount++;

            if (filledCount == 4)
            {
                TaiKhoan tk = danhSach.FirstOrDefault(t => t.MaTaiKhoan == SoTaiKhoan);
                if (tk != null)
                {
                    tk.TenKhachHang = TenKhachHang;
                    tk.DiaChi = DiaChi;
                    tk.SoTien = SoTien;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    danhSach.Add(new TaiKhoan { MaTaiKhoan = SoTaiKhoan, TenKhachHang = TenKhachHang, DiaChi = DiaChi, SoTien = SoTien });
                    MessageBox.Show("Thêm dữ liệu mới thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }


      
        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            TaiKhoan selected = myDataGrid.SelectedItem as TaiKhoan;
            if (selected != null)
            {
                SoTaiKhoan = selected.MaTaiKhoan;
                TenKhachHang = selected.TenKhachHang;
                DiaChi = selected.DiaChi;
                SoTien = selected.SoTien;
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan tk = danhSach.FirstOrDefault(t => t.MaTaiKhoan == SoTaiKhoan);
            if (tk!=null)
            {
                MessageBoxResult isDelete = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (isDelete == MessageBoxResult.Yes)
                {
                    danhSach.Remove(tk);
                    SoTaiKhoan = TenKhachHang = DiaChi = SoTien = "";
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa");
            }
        }

        private void endProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTotal();
        }
    }
     
    }