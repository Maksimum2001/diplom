using Diplom.Страницы_учебных_материалов;
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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Отображение необходимой страницы на главном окне
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Str()); // Отображение страницы Str на главном окне приложения при запуске
            Help.MainFrame = MainFrame;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close(); //Функционал для кнопки закрытия приложения
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized; // Функционал для кнопки развёртывания приложения на весь экран
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Функционал для кнопки сворачивания приложения
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (this.WindowState == WindowState.Maximized) // В случае максимального состояния окна окно вернется в нормальное состояние и продолжит движение вслед за курсором
                {
                    this.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.Top = 3; // Щёлкнуть в любом месте, кроме страниц где вы хотите установить местоположение окна для возврата из максимального состояния
                }
                this.DragMove(); //Перетаскивание приложения по экрану
            }
        }
    }
}