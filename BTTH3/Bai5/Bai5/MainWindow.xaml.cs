using System.ComponentModel;
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
using System.ComponentModel;
using System.Windows;

namespace Bai5
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
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string? number1;
        public string? Number1
        {
            get => number1;
            set
            {
                if (number1 != value)
                {
                    number1 = value;
                    OnPropertyChanged(nameof(Number1)); 
                }
            }

        }

        private string? number2;
        public string? Number2
        {
            get => number2;
            set
            {
                if (number2 != value)
                {
                    number2 = value;
                    OnPropertyChanged(nameof(Number2));
                }
            }

        }

        private string? ans;
        public string? Ans
        {
            get => ans;
            set
            {
                if (ans != value)
                {
                    ans = value;
                    OnPropertyChanged(nameof(ans));
                }
            }

        }

        private void add(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Number1, out double n1) && double.TryParse(Number2, out double n2))
                Ans = (n1 + n2).ToString(); 
            else
                Ans = "Invalid";
        }

        private void sub(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Number1, out double n1) && double.TryParse(Number2, out double n2))
                Ans = (n1 - n2).ToString();
            else
                Ans = "Invalid";
        }

        private void multiply(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Number1, out double n1) && double.TryParse(Number2, out double n2))
                Ans = (n1 * n2).ToString();
            else
                Ans = "Invalid";
        }

        private void divide(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Number1, out double n1) && double.TryParse(Number2, out double n2))
            {
                if (n2 == 0)
                    Ans = "∞";
                else
                    Ans = (n1 / n2).ToString();
            }
            else
                Ans = "Invalid";
        }
    }
}
