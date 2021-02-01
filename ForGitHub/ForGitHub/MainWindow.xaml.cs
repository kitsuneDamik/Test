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

namespace ForGitHub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateDegreeOf(object sender, RoutedEventArgs e)
        {
            double number;
            double degree;
            try
            {
                number = checked(Convert.ToDouble(tbNumber.Text));
                degree = checked(double.Parse(tbDegree.Text));
                tbResult.Text = $"Ответ: {number}^{degree} = {Math.Pow(number, degree)}";
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Недопустимое число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка при вводе данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
