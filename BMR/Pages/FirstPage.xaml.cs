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


namespace BMR.Pages
{
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        List<string> genderList = new List<string>() { "Мужчина", "Женщина" };
        public double weight = 0;
        public double height = 0;
        public double year = 0;
        public string gender = "";
        public double BMRstr = 0;
        public FirstPage()
        {
            InitializeComponent();
            cmbGender.ItemsSource = genderList;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHeight.Text) && txtboxHeight.Text == "00см")
            {
                MessageBox.Show("Введите рост");
                return;
            }
            if (string.IsNullOrEmpty(txtboxWeight.Text) && txtboxWeight.Text == "00кг")
            {
                MessageBox.Show("Введите вес");
                return;
            }
            if(string.IsNullOrEmpty(txtboxYear.Text) && txtboxYear.Text == "00")
            {
                MessageBox.Show("Введите возраст");
                return;
            }
            if(cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Введите пол");
                return;
            }

            else
            {
                height = Convert.ToDouble(txtboxHeight.Text);
                weight= Convert.ToDouble(txtboxWeight.Text);
                year = Convert.ToDouble(txtboxYear.Text);
                gender = cmbGender.SelectedItem.ToString();

                if (gender == "Мужчина")
                {
                    BMRstr = 66 + (13.7 * weight) + (5 * height) - (6.8 * year);
                    Manager.MainFrame.Navigate(new SecondPage(BMRstr));
                }

                if (gender == "Женщина")
                {
                    BMRstr = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * year);
                    Manager.MainFrame.Navigate(new SecondPage(BMRstr));
                }

            }

        }




    

        private void txtboxWeight_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtboxWeight.Text == "00кг")
            {
                txtboxWeight.Clear();
                txtboxWeight.Foreground = Brushes.Black;
            }
        }

        private void txtboxWeight_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxWeight.Text))
            {
                txtboxWeight.Text = "00кг";
                txtboxWeight.Foreground = Brushes.Gray;
            }
        }

        private void txtboxHeight_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtboxHeight.Text == "00см")
            {
                txtboxHeight.Clear();
                txtboxHeight.Foreground = Brushes.Black;
            }
        }

        private void txtboxHeight_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHeight.Text))
            {
                txtboxHeight.Text = "00см";
                txtboxHeight.Foreground = Brushes.Gray;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtboxWeight.Text = "00кг";
            txtboxHeight.Text = "00см";
            txtboxHeight.Foreground = Brushes.Gray;
            txtboxWeight.Foreground = Brushes.Gray;
        }

        private void txtboxYear_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtboxYear.Text == "00")
            {
                txtboxYear.Clear();
                txtboxYear.Foreground = Brushes.Black;
            }
        }

        private void txtboxYear_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxYear.Text))
            {
                txtboxYear.Text = "00";
                txtboxYear.Foreground = Brushes.Gray;
            }
        }
    }
}
