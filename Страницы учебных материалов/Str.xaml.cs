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

namespace Diplom.Страницы_учебных_материалов
{
    /// <summary>
    /// Логика взаимодействия для Str.xaml
    /// </summary>
    public partial class Str : Page
    {
        public Str()
        {
            InitializeComponent();
        }

        private void Tema1_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str1());
        }

        private void Tests1_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test1());
        }

        private void Tema2_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str2());
        }
        
        private void Tests2_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test2());
        }

        private void Tema3_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str3());
        }

        private void Tests3_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test3());
        }

        private void Tema4_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str4());
        }

        private void Tests4_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test4());
        }

        private void Tema5_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str5());
        }

        private void Tests5_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test5());
        }
    }
}
