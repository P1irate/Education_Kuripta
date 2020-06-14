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
    /// Логика взаимодействия для practiceWindow.xaml
    /// </summary>
    public partial class practiceWindow : Window
    {

        int number_task = 0;
        public practiceWindow()
        {
            InitializeComponent();

        }
        General_Function GF = new General_Function();
        Sql_Command SC = new Sql_Command();
        Ganeral_Variable GV = new Ganeral_Variable();
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

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {

            if (answer1.IsChecked == true)
            {
                Ganeral_Variable.User_Answer.Add(Convert.ToString(answer1.Content));
            }
            if (answer2.IsChecked == true)
            {
                Ganeral_Variable.User_Answer.Add(Convert.ToString(answer2.Content));
            }
            if (answer3.IsChecked == true)
            {
                Ganeral_Variable.User_Answer.Add(Convert.ToString(answer3.Content));
            }
            if (answer4.IsChecked == true)
            {
                Ganeral_Variable.User_Answer.Add(Convert.ToString(answer4.Content));
            }                                                                             
            if (number_task < Ganeral_Variable.Id_Task.Count)
            {
                if (number_task < 10)
                {
                    Number_task.Content = Number_task.Content.ToString().Substring(0, Number_task.Content.ToString().Length - 1);
                }
                if (number_task >= 10 && number_task < 100)
                {
                    Number_task.Content = Number_task.Content.ToString().Substring(0, Number_task.Content.ToString().Length - 2);
                }
                Number_task.Content += Convert.ToString(number_task + 1);
                Task.Text = SC.Getting_Task(Ganeral_Variable.Id_Task[number_task]);
                Ganeral_Variable.Сorrect_Answer.Add(SC.Getting_Answer(Ganeral_Variable.Id_Task[number_task]));
                GF.Answer(Ganeral_Variable.Id_Task[number_task], answer1, answer2, answer3, answer4);
                number_task++;

            }
            else
            {
                resultWindow resultWindow = new resultWindow();
                resultWindow.Show();
                this.Close();
                number_task = 0;
            }

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Ganeral_Variable.Сorrect_Answer.Clear();
            Ganeral_Variable.User_Answer.Clear();

            SC.Getting_Id_Task(Ganeral_Variable.ID_Theme);
            Number_task.Content += Convert.ToString(number_task + 1); 
            Task.Text = SC.Getting_Task(Ganeral_Variable.Id_Task[number_task]);
            Ganeral_Variable.Сorrect_Answer.Add(SC.Getting_Answer(Ganeral_Variable.Id_Task[number_task]));
            GF.Answer(Ganeral_Variable.Id_Task[number_task], answer1, answer2, answer3, answer4);
            number_task++;
        }
    }
}
