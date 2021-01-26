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

namespace HelloGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sum();

            txtday.Text= sum().ToString();

        }
        private  int sum()
        {
            int receive = int.Parse(txtrece.Text);
            int pay = int.Parse(txtpay.Text);
            int item = int.Parse(txtitem.Text);
            int day =  item/(receive - pay);

            return day;

        }
    }
}
