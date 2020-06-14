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
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для resultWindow.xaml
    /// </summary>
    public partial class resultWindow : Window
    {
        public resultWindow()
        {
            InitializeComponent();
        }
        private void buttonHide_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, RoutedEventArgs e)
        {
            helpWindow helpWindow = new helpWindow();
            helpWindow.Show();
        }

        private void buttonTask_Click(object sender, RoutedEventArgs e)
        {
            taskWindow taskWindow = new taskWindow();
            taskWindow.Show();
            this.Close();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            User_Answer.ItemsSource = Ganeral_Variable.User_Answer;
            True_Answer.ItemsSource = Ganeral_Variable.Сorrect_Answer;
            int all_answer_true =0 ;
            int all_ball = 0 ;
            for (int i = 0; i < Ganeral_Variable.User_Answer.Count; i++)
            {
                if (Ganeral_Variable.User_Answer[i] == Ganeral_Variable.Сorrect_Answer[i].ToString())
                {
                    all_answer_true++;
                    if (i<=5)
                    {
                        all_ball +=2;
                    }
                    if (i>5 &&i<=10)
                    {
                        all_ball +=5;
                    }
                    if (i > 10 && i <= 15)
                    {
                        all_ball +=6;
                    }
                    if (i > 15 && i <= 20)
                    {
                        all_ball += 7;
                    }
                }
            }
            label_all_result_answer.Content = "Решено верно "+all_answer_true+" из 20";
            label_ball.Content = "Набрано "+all_ball+" из 100";
        }
    }
}
