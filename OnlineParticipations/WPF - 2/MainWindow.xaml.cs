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

namespace WPF___2
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

        private void rbOdd_Checked(object sender, RoutedEventArgs e)
        {
            int LimitO = Convert.ToInt32(txtbox.Text);
            int valO = 0;
            for (int i = 1; i <= LimitO; i = i + 2)
            {
                lstValues.Items.Add(i);
            }
        }

        private void rbEven_Checked(object sender, RoutedEventArgs e)
        {
            int LimitE = Convert.ToInt32(txtbox.Text);
            int valE = 0;
            for (int i = 2; i <= LimitE; i = i + 2)
            {
                lstValues.Items.Add(i);
            }
        }
    }
}
