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
using System.Runtime.CompilerServices;

namespace Bai7
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
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        List<Button> selectedBtn = new List <Button>();
        List<Button> selectingBtn = new List<Button>();
        private double total;
        public double Total
        {
            get => total;
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            foreach (Button item in selectingBtn)
            {
                item.Background = Brushes.Yellow;
                selectedBtn.Add(item);
                
            }
          selectingBtn.Clear();
         
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            foreach (Button item in selectingBtn)
            {
                item.Background = Brushes.White; 
            }
            Total = 0;
         

        }

        private void endBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        

        private void chooseBtn_Click(object sender, RoutedEventArgs e)
        {

            Button btn = sender as Button;
            if (selectedBtn.Contains(btn))
            {
                MessageBox.Show("Vị trí này đã được bán");
                return;
            } 
           
            if (selectingBtn.Contains(btn))
            {
                selectingBtn.Remove(btn);
                btn.Background = Brushes.White;
            }
            else
            {
                btn.Background = Brushes.Blue;
                selectingBtn.Add(btn);
             
            }
            double sum = 0;
            foreach (var item in selectingBtn)
            {

               
                    sum += Convert.ToDouble(item.Tag);
            }
            Total = sum;

        }

         
        
    }
}