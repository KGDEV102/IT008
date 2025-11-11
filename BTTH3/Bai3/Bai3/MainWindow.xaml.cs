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

namespace Bai3
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            byte r = (byte)rd.Next(0, 256);
            byte g = (byte)rd.Next(0, 256);
            byte b = (byte)rd.Next(0, 256);
            bgMain.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }
    }
}