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
    /// Логика взаимодействия для Test4.xaml
    /// </summary>
    public partial class Test4 : Page
    {
        public Test4()
        {
            InitializeComponent();
        }

        private void Tester4_Click(object sender, RoutedEventArgs e)
        {
            ///Условие проверки правильных ответов: если выбран правильный ответ, то прибавляется один бал, и так проверяется каждый вопрос
            int a = 0, b = 0, c = 0, d = 0, h = 0;
            if (trusty1.IsChecked == true)
            {
                a = 1;
            }
            if (trusty2.IsChecked == true)
            {
                b = 1;
            }
            if (trusty3.IsChecked == true)
            {
                c = 1;
            }
            if (trusty4.IsChecked == true)
            {
                d = 1;
            }
            if (trusty5.IsChecked == true)
            {
                h = 1;
            }


            result4.Text = "Оценка: " + (a + b + c + d + h).ToString();//Строка с надписью Оценка: складывается со строкой в которой считаются правильные ответы и выводится их количество, конструкция попадает в поименованный Textblock
        }
    }
}
