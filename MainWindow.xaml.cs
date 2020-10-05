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

namespace HeightConverter
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

        private void ConvertCmBtnClick(object sender, RoutedEventArgs e)
        {
            TextBox cm = enteredCm;
            double inches = 0;
            try
            {
                inches = Convert.ToDouble(cm.Text) / 2.54;
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            TextBox inchTextBox = enteredInch;
            inchTextBox.Text = Math.Round(inches, 2) + "";
        }

        private void ConvertInchBtnClick(object sender, RoutedEventArgs e)
        {
            TextBox inch = enteredInch;
            double cm = 0;
            try
            {
                cm = Convert.ToDouble(inch.Text) * 2.54;
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            TextBox cmTextBox = enteredCm;
            cmTextBox.Text = Math.Round(cm, 2) + "";
        }
    }
}
