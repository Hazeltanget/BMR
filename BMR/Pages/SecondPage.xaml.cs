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
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        double BMR = 0;
        public List<string> activity = new List<string>() { "Сидячий образ", "Маленькая активность", "Средняя активность", "Сильная активность", "Максимальная активность" };
        public SecondPage()
        {
            InitializeComponent();
            cmbActivity.ItemsSource = activity;

            

        }

        public SecondPage(double BMRstr)
        {
            InitializeComponent();
            cmbActivity.ItemsSource = activity;
            cout.Text = BMRstr.ToString();
        }

        private void btnCalculateAct_Click(object sender, RoutedEventArgs e)
        {
            if (cmbActivity.SelectedItem.ToString() == "Сидячий образ")
            {
                BMR = Convert.ToDouble(cout.Text);
                BMR *= 1.2;
                cout.Text = BMR.ToString();
                btnCalculateAct.IsEnabled = false;
            }
            if (cmbActivity.SelectedItem.ToString() == "Маленькая активность")
            {
                BMR = Convert.ToDouble(cout.Text);
                BMR *= 1.375;
                cout.Text = BMR.ToString();
                btnCalculateAct.IsEnabled = false;
            }
            if(cmbActivity.SelectedItem.ToString() == "Средняя активность")
            {
                BMR = Convert.ToDouble(cout.Text);
                BMR *= 1.55;
                cout.Text = BMR.ToString();
                btnCalculateAct.IsEnabled = false;

            }
            if(cmbActivity.SelectedItem.ToString() == "Сильная активность")
            {
                BMR = Convert.ToDouble(cout.Text);
                BMR *= 1.725;
                cout.Text = BMR.ToString();
                btnCalculateAct.IsEnabled = false;
            }
            if(cmbActivity.SelectedItem.ToString() == "Максимальная активность")
            {
                BMR = Convert.ToDouble(cout.Text);
                BMR *= 1.9;
                cout.Text = BMR.ToString();
                btnCalculateAct.IsEnabled = false;
            }

            
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack(); 
        }
    }
}
