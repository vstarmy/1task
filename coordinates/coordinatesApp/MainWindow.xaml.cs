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

namespace coordinatesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string s = "";
        int startIndex = 0;
        string x, y;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s = textBox.Text;
            startIndex = 0;
            x = s.Substring(startIndex, s.IndexOf(','));
            y = s.Substring(s.IndexOf(',') + 1);


            StreamWriter sw = new StreamWriter("file.txt");
            sw.WriteLine("X: {0} Y: {1} ", x, y);
            sw.Close();
            MessageBox.Show("Координаты записаны!");


        }

        public MainWindow()
        {
            InitializeComponent();
            FileStream file = new FileStream("file.txt", FileMode.Create);
            file.Close();
        }
    }
}
