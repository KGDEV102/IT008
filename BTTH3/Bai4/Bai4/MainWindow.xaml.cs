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
using System.Windows.Media;           // Brush
using WinForms = System.Windows.Forms; // Alias WinForms để dùng ColorDialog

namespace Bai4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Color_Click(object sender, RoutedEventArgs e)
        {
            var colorDialog = new WinForms.ColorDialog();
           

            if (colorDialog.ShowDialog() == WinForms.DialogResult.OK)
            {
                var color = colorDialog.Color;
                var brush = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
                this.Background = brush;
            }

        }
    }
    
}