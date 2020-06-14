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
    /// Логика взаимодействия для taskWindow.xaml
    /// </summary>
    public partial class taskWindow : Window
    {
        Sql_Command SC = new Sql_Command();
        int number_task = 0;
        public taskWindow()
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

        private void buttonReturn_Click(object sender, RoutedEventArgs e)
        {
            if (number_task < Ganeral_Variable.Id_Task.Count)
            {
                
                if(number_task<10)
                { number_task_label.Content = number_task_label.Content.ToString().Substring(0, number_task_label.Content.ToString().Length - 1); 
                }
                if (number_task >= 10 && number_task < 100)
                {
                    number_task_label.Content = number_task_label.Content.ToString().Substring(0, number_task_label.Content.ToString().Length - 2);
                }
                number_task_label.Content += Convert.ToString(number_task + 1);
                Task.Text = SC.Getting_Task(Ganeral_Variable.Id_Task[number_task]);
                Explanation_Вecision.Text = SC.Getting_Solution(Ganeral_Variable.Id_Task[number_task]);
                number_task++;

            }
            else
            {
                startWindow startWindow = new startWindow();
                startWindow.Show();
                this.Close();
                number_task = 0;
            }
            
        }

        private void Task_Loaded(object sender, RoutedEventArgs e)
        {
            number_task_label.Content += Convert.ToString(number_task + 1);
            SC.Getting_Id_Task(Ganeral_Variable.ID_Theme);
            Task.Text = SC.Getting_Task(Ganeral_Variable.Id_Task[number_task]);
            Explanation_Вecision.Text = SC.Getting_Solution(Ganeral_Variable.Id_Task[number_task]);
            number_task++;
        }
    }
}
