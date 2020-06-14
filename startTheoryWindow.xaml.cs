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
    /// Логика взаимодействия для startTheoryWindow.xaml
    /// </summary>
    public partial class startTheoryWindow : Window
    {
        Ganeral_Variable GV = new Ganeral_Variable();
        Sql_Command SC = new Sql_Command();
        public startTheoryWindow()
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

        private void buttonTheory_Click(object sender, RoutedEventArgs e)
        {
			string name_theame = Theory_Task.SelectedItem.ToString();
            Ganeral_Variable.ID_Theme = SC.Getting_Id_Theame(name_theame);
            theoryWindow theoryWindow = new theoryWindow();
            theoryWindow.Show();
            this.Close();
        }

        private void Theory_Task_Loaded(object sender, RoutedEventArgs e)
        {
            SC.Chapter(Theory_Task);
        }

        private void Theory_Task_SelectionChanged()
        {

        }

        private void buttoтReturn_Click(object sender, RoutedEventArgs e)
        {
            startWindow theoryWindow = new startWindow();
            theoryWindow.Show();
            this.Close();
        }
    }
}
