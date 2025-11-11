using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Bai6
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private double lastValue = 0;
        private string currentOperator = "";
        private bool isNewEntry = false;
        private double currentValue = 0;

        private string stringDs = "";
        public string StringDs
        {
            get => stringDs;
            set
            {
                stringDs = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string key = btn.Content.ToString();

            // Xử lý nút số và dấu .
            if (char.IsDigit(key[0]) || key == ".")
            {
                if (isNewEntry)
                {
                    StringDs = "";
                    isNewEntry = false;
                }

                if (key == "." && StringDs.Contains(".")) return;
                StringDs += key;
                double.TryParse(StringDs, out currentValue);
                return;
            }

            switch (key)
            {
                case "Backspace":
                    if (StringDs.Length > 0)
                    {
                        StringDs = StringDs.Substring(0, StringDs.Length - 1);
                        double.TryParse(StringDs, out currentValue);
                    }
                    break;

                case "C":
                    StringDs = "";
                    lastValue = 0;
                    currentOperator = "";
                    currentValue = 0;
                    break;

                case "CE":
                    StringDs = "";
                    currentValue = 0;
                    break;

                case "+/-":
                    if (StringDs != "")
                    {
                        currentValue = -1 * double.Parse(StringDs);
                        StringDs = currentValue.ToString();
                    }
                    break;

                case "1/x":
                    if (currentValue != 0)
                    {
                        currentValue = 1 / currentValue;
                        StringDs = currentValue.ToString();
                    }
                    else
                    {
                        StringDs = "Cannot divide by zero";
                    }
                    break;

                case "sqrt":
                    if (currentValue >= 0)
                    {
                        currentValue = Math.Sqrt(currentValue);
                        StringDs = currentValue.ToString();
                    }
                    else
                    {
                        StringDs = "Invalid input";
                    }
                    break;

                case "%":
                    currentValue = (lastValue * currentValue) / 100;
                    StringDs = currentValue.ToString();
                    break;

                case "+":
                case "-":
                case "*":
                case "/":
                    if (!string.IsNullOrEmpty(currentOperator))
                        Calculate();
                    else
                        lastValue = currentValue;

                    currentOperator = key;
                    isNewEntry = true;
                    break;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            currentOperator = "";
        }

        private void Calculate()
        {
            try
            {
                switch (currentOperator)
                {
                    case "+": lastValue += currentValue; break;
                    case "-": lastValue -= currentValue; break;
                    case "*": lastValue *= currentValue; break;
                    case "/":
                        if (currentValue == 0)
                        {
                            StringDs = "Cannot divide by zero";
                            return;
                        }
                        lastValue /= currentValue;
                        break;
                }
                StringDs = lastValue.ToString();
                currentValue = lastValue;
                isNewEntry = true;
            }
            catch
            {
                StringDs = "Error";
            }
        }
    }
}
