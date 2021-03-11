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

namespace PrezzoQuantitàWPF
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrezzo.Text != "" || txtQuantità.Text != "")
            {
                try
                {
                    double p = double.Parse(txtPrezzo.Text);
                    int q = int.Parse(txtQuantità.Text);
                    double tot = p * q;
                    int s = int.Parse(txtSconto.Text);
                    if (q >= 20)
                    {
                        if (s >= 0 || s <= 100)
                        {
                            double temp = (s / 100) * tot;
                            double sconto = tot - temp;
                            lblOuputTotale.Content = sconto;
                        }
                        else
                        {
                            lblOuputTotale.Content = "Error";
                        }

                    }
                    else
                        lblOuputTotale.Content = tot;
                }
                catch (Exception ex)
                {
                    lblOuputTotale.Content = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Space empty", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
