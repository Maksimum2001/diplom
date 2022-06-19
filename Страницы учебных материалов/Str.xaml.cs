using Diplom.Страницы_лабораторных_работ;
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
        /// <summary>
        /// переходы по клику к определённым страницам с помощью Frame и метода Navigate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Tema6_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str6());
        }

        private void Tests6_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test6());
        }

        private void Tema7_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str7());
        }

        private void Tests7_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test7());
        }

        private void Tema8_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str8());
        }

        private void Tests8_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test8());
        }

        private void Tema9_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str9());
        }

        private void Tests9_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test9());
        }

        private void Tema10_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Str10());
        }

        private void Tests10_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Test10());
        }

        private void Lab1_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab1());
        }

        private void Lab2_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab2());
        }

        private void Lab3_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab3());
        }

        private void Lab4_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab4());
        }

        private void Lab5_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab5());
        }

        private void Lab6_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab6());
        }

        private void Lab7_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab7());
        }

        private void Lab8_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new Lab8());
        }

        private void CP1_Click(object sender, RoutedEventArgs e)
        {
            Help.MainFrame.Navigate(new CP_1());
        }
    }
}
