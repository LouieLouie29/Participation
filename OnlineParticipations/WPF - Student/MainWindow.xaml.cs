//Ed Louie
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

namespace WPF___Student
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
       

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {

            string FName, LName, FavColor, StudID;
            
            StudID = txtStudID.Text;
            FName = txtFName.Text;
            LName = txtLName.Text;
            FavColor = txtFavColor.Text;
            
            int StudIDAsTNumber = Convert.ToInt32(StudID);                       
                        

            lstStudent.Items.Add($"{FName} {LName} - {StudID} - {FavColor}");

            txtFavColor.Clear();
            txtStudID.Clear();
            txtFName.Clear();
            txtLName.Clear();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFavColor.Clear();
            txtStudID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            lstStudent.Items.Clear();
        }

        private void btnProcess_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void lstStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtFName_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
