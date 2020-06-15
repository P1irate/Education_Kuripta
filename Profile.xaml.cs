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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        Sql_Command SC = new Sql_Command();
        public Profile()
        {
            InitializeComponent();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SC.DisplayClientData(Data_Grid_Education_Group, Ganeral_Variable.ID_user);
            Avarable_ball.Content = "Средний балл: " +SC.Getting_average_mark_user(Ganeral_Variable.ID_user);
            Best_result.Content = "Лучший результат: " + SC.Getting_max_result_user(Ganeral_Variable.ID_user);
            All_test.Content = "Всего тестов " + SC.Getting_All_tests_user(Ganeral_Variable.ID_user);
        }
        private void buttonHide_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
