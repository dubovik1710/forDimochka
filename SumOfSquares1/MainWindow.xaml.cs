using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SumOfSquares1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
    }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            string a_string = Convert.ToString(a);
            string b_string = Convert.ToString(b);

            try
            {
                SumOfSquares obj = new SumOfSquares(a, b);
                string resultOfOperation = Convert.ToString(obj.Square(a_string, b_string));

                ResultBox.Text = resultOfOperation;
            }
            catch
            {
                MessageBox.Show("В поле для ввода значений имеются недопустимые символы. Поле принимает только целые числа.");
            }


}

        //private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (TextBox1.Text.
        //}
    }

    public class SumOfSquares
    {
        private double num1;
        private double num2;

        public SumOfSquares(double sumValue1, double sumValue2)
        {
            num1 = sumValue1;
            num2 = sumValue2;
        }

        public string GetInfo()
        {
            return $"Число 1: {num1}, число 2: {num2}";
        }

        public double Square (string data1, string data2)
        {
            
            if (int.TryParse(data1, out var x) && int.TryParse(data2, out var x1))
            {
                double r = Math.Pow(x, 2) + Math.Pow(x1, 2);
                return r;
            }
            else
            {
                MessageBox.Show("В поле для ввода значений имеются недопустимые символы. Поле принимает только целые числа.");
                return 0;
            }
        }

        public double Result()
        {
            
            return Math.Pow(num1, 2) + Math.Pow(num2, 2);
        }
    }
}
