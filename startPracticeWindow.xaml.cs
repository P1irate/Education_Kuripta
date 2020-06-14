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
    /// Логика взаимодействия для startPracticeWindow.xaml
    /// </summary>
    public partial class startPracticeWindow : Window
    {
        Sql_Command SC = new Sql_Command();
        Ganeral_Variable GV = new Ganeral_Variable();
        public startPracticeWindow()
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

        private void buttonPractice_Click(object sender, RoutedEventArgs e)
        {
            
            string name_theme = Practice_Theame.SelectedItem.ToString();

            Ganeral_Variable.ID_Theme = SC.Getting_Id_Theame(name_theme);           
            practiceWindow practiceWindow = new practiceWindow();
            practiceWindow.Show();
            this.Close();

        }

        private void Practice_Theame_Loaded(object sender, RoutedEventArgs e)
        {
            SC.Chapter(Practice_Theame);
        }
    }
}
