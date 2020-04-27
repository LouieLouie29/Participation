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
using System.IO;

namespace WPF___Student_Prob._2
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

        

        private void btnTextEntry_Click(object sender, RoutedEventArgs e)
        {
            string path = @"studentdataRandom10Rows.csv";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                Console.WriteLine("No File Found");
                return;
            }

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);

            int size = readText.Length - 1;
            Console.WriteLine(size);

            string[] id = new string[size];
            string[] firstName = new string[size];
            string[] lastName = new string[size];
            string[] faveColor = new string[size];

            int counter = 0;
            string[] temp;
            foreach (string s in readText)
            {
                if (counter != 0)
                {
                    temp = s.Split(',');
                    //Console.WriteLine(index +":");
                    id[counter - 1] = temp[0];
                    //Console.WriteLine(id[index]);
                    firstName[counter - 1] = temp[1];
                    //Console.WriteLine(firstName[index]);
                    lastName[counter - 1] = temp[2];
                    //Console.WriteLine(lastName[index]);
                    faveColor[counter - 1] = temp[3];
                    //Console.WriteLine(faveColor[index]);
                }
                counter++;
            }

            string FName, LName, FavColor, StudID;
            

            for (int i = 0; i < size; i++)
            {
                StudID = id[i];
                FName = firstName[i];
                LName = lastName[i];
                FavColor = faveColor[i];

                

                lstStudent.Items.Add($"{FName} {LName} - {StudID} - {FavColor}");
            }
        }

        private void btnRan100_Click(object sender, RoutedEventArgs e)
        {
            string path = @"studentdataRandom100Rows.csv";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                Console.WriteLine("No File Found");
                return;
            }

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);

            int size = readText.Length - 1;
            Console.WriteLine(size);

            string[] id = new string[size];
            string[] firstName = new string[size];
            string[] lastName = new string[size];
            string[] faveColor = new string[size];

            int counter = 0;
            string[] temp;
            foreach (string s in readText)
            {
                if (counter != 0)
                {
                    temp = s.Split(',');
                    //Console.WriteLine(index +":");
                    id[counter - 1] = temp[0];
                    //Console.WriteLine(id[index]);
                    firstName[counter - 1] = temp[1];
                    //Console.WriteLine(firstName[index]);
                    lastName[counter - 1] = temp[2];
                    //Console.WriteLine(lastName[index]);
                    faveColor[counter - 1] = temp[3];
                    //Console.WriteLine(faveColor[index]);
                }
                counter++;
            }

            string FName, LName, FavColor, StudID;


            for (int i = 0; i < size; i++)
            {
                StudID = id[i];
                FName = firstName[i];
                LName = lastName[i];
                FavColor = faveColor[i];



                lstStudent.Items.Add($"{FName} {LName} - {StudID} - {FavColor}");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstStudent.Items.Clear();
        }
    }
}
