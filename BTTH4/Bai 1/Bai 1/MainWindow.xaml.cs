using System;
using System.Windows;
using System.Windows.Input;

namespace Bai_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainGrid.Focus();          
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            string button = e.ChangedButton.ToString();
            Point position = e.GetPosition(this);
            txtInfo.Text = $"Bạn vừa nhấn nút chuột: {button}\nTọa độ: X={position.X}, Y={position.Y}";
            e.Handled = true;          
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int keyCode = KeyInterop.VirtualKeyFromKey(e.Key);
            char asciiChar = '\0';
            try
            {
                asciiChar = Convert.ToChar(keyCode);
            }
            catch { }

            txtInfo.Text = $"Bạn vừa nhấn phím: {e.Key}\nKeyCode: {keyCode}\nASCII: {(asciiChar == '\0' ? "Không xác định" : asciiChar.ToString())}";
            e.Handled = true;
        }
    }
}
