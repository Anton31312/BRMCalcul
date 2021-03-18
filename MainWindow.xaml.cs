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

namespace BRM_calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool gender;

        private void btnFemale_Click(object sender, RoutedEventArgs e)
        {
            gender = false;
            btnMale.IsEnabled = true;
            btnFemale.IsEnabled = false;
        }

        private void btnMale_Click(object sender, RoutedEventArgs e)
        {
            gender = true;
            btnMale.IsEnabled = false;
            btnFemale.IsEnabled = true;
        }

        private void tbAge_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= tbAge_GotFocus;
        }

        private void tbHeight_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= tbHeight_GotFocus;

        }

        private void tbWeight_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= tbWeight_GotFocus;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double bmr = 0;

            if (gender)
            {
                bmr = 66 + (13.7 * Convert.ToDouble(tbWeight.Text)) + (5 * Convert.ToDouble(tbHeight.Text)) - (6.8 * Convert.ToDouble(tbAge.Text));
            }

            else
            {
                bmr = 655 + (9.6 * Convert.ToDouble(tbWeight.Text)) + (1.8 * Convert.ToDouble(tbHeight.Text)) - (4.7 * Convert.ToDouble(tbAge.Text));
            }


            txtBMRRes.Text = txtBMRRes.Text + "\n" + bmr;
            txtSit.Text = txtSit.Text + "Сидячий образ: " + bmr * 1.2;
            txtLitAct.Text = txtLitAct.Text + "Маленькая активность: " + bmr * 1.375;
            txtMedAct.Text = txtMedAct.Text + "Средняя активность: " + bmr * 1.55;
            txtDifAct.Text = txtDifAct.Text + "Сильная активность: " + bmr * 1.725;
            txtMaxAct.Text = txtMaxAct.Text + "Максимальная активность: " + bmr * 1.9;
        }
    }
}
