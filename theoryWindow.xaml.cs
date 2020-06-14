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

using SharpGL;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для theoryWindow.xaml
    /// </summary>
    public partial class theoryWindow : Window
    {
        Figur figur = new Figur();
        int number_theme = 0;
        Sql_Command SC = new Sql_Command();
        General_Function GF = new General_Function();
        public theoryWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
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
            startPracticeWindow startPracticeWindow = new startPracticeWindow();
            startPracticeWindow.Show();
            this.Close();
            // this.Hide();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SC.Getting_Id_Theory(Ganeral_Variable.ID_Theme);
            Theme.Text = SC.Getting_Theory(Ganeral_Variable.Id_Theme[number_theme]);
			Theme_label.Content = SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]);

			switch (SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]))
			{
				case "Квадрат по сторонам":
					figur.square1(openGLControl, sender, e);
					break;
				case "Квадрат по диагонали":
					figur.square2(openGLControl, sender, e);
					break;
				case "Параллелограмм по васоте и стороне":
					figur.parallelogram1(openGLControl);
					break;
				case "Параллелограмм по диагонали и sin":
					figur.parallelogram2(openGLControl);
					break;
				case "Прямоугольник по сторонам":
					figur.rectangle(openGLControl);
					break;
				case "Ромб по стороне и sin":
					figur.rhombus1(openGLControl);
					break;
				case "Ромб по диагоналям":
					figur.priombus2(openGLControl);
					break;
				case "Ромб по стороне и высоте":
					figur.priombus3(openGLControl);
					break;
				case "Трапеция по основанию и высоте":
					figur.trapezoid(openGLControl);
					break;
				case "Треугольник по стороне и высоте":
					figur.triangle1(openGLControl);
					break;
				case "Треугольник по сторонам и sin":
					figur.triangle2(openGLControl);
					break;
				case "Треугольник по формуле Герона":
					figur.triangle3(openGLControl);
					break;
				case "Прямоугольный треугольник":
					figur.triangle4(openGLControl);
					break;
				case "Равносторонний треугольник":
					figur.triangle5(openGLControl);
					break;
				defalt: MessageBox.Show("Ненавижу блять вопросы");
					break;

			}
        }

        private void button_back_theme_Click(object sender, RoutedEventArgs e)
        {
            if (number_theme > 0)
            {
                number_theme--;
				Theme_label.Content = SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				Theme.Text = SC.Getting_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				switch (SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]))
				{
					case "Квадрат по сторонам":
						figur.square1(openGLControl, sender, e);
						break;
					case "Квадрат по диагонали":
						figur.square2(openGLControl, sender, e);
						break;
					case "Параллелограмм по васоте и стороне":
						figur.parallelogram1(openGLControl);
						break;
					case "Параллелограмм по диагонали и sin":
						figur.parallelogram2(openGLControl);
						break;
					case "Прямоугольник по сторонам":
						figur.rectangle(openGLControl);
						break;
					case "Ромб по стороне и sin":
						figur.rhombus1(openGLControl);
						break;
					case "Ромб по диагоналям":
						figur.priombus2(openGLControl);
						break;
					case "Ромб по стороне и высоте":
						figur.priombus3(openGLControl);
						break;
					case "Трапеция по основанию и высоте":
						figur.trapezoid(openGLControl);
						break;
					case "Треугольник по стороне и высоте":
						figur.triangle1(openGLControl);
						break;
					case "Треугольник по сторонам и sin":
						figur.triangle2(openGLControl);
						break;
					case "Треугольник по формуле Герона":
						figur.triangle3(openGLControl);
						break;
					case "Прямоугольный треугольник":
						figur.triangle4(openGLControl);
						break;
					case "Равносторонний треугольник":
						figur.triangle5(openGLControl);
						break;

					defalt: MessageBox.Show("Ненавижу блять вопросы");
						break;

				}
			} 
        }

        private void button_next_theme_Click(object sender, RoutedEventArgs e)
        {
            if (number_theme<Ganeral_Variable.Id_Theme.Count -1)
            {
                number_theme++;
				Theme_label.Content = SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				Theme.Text = SC.Getting_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				switch (SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]))
				{
					case "Квадрат по сторонам":
						openGLControl.Content = figur.square1(openGLControl, sender, e);
						break;
					case "Квадрат по диагонали":
						figur.square2(openGLControl, sender, e);
						break;
					case "Параллелограмм по васоте и стороне":
						figur.parallelogram1(openGLControl);
						break;
					case "Параллелограмм по диагонали и sin":
						figur.parallelogram2(openGLControl);
						break;
					case "Прямоугольник по сторонам":
						figur.rectangle(openGLControl);
						break;
					case "Ромб по стороне и sin":
						figur.rhombus1(openGLControl);
						break;
					case "Ромб по диагоналям":
						figur.priombus2(openGLControl);
						break;
					case "Ромб по стороне и высоте":
						figur.priombus3(openGLControl);
						break;
					case "Трапеция по основанию и высоте":
						figur.trapezoid(openGLControl);
						break;
					case "Треугольник по стороне и высоте":
						figur.triangle1(openGLControl);
						break;
					case "Треугольник по сторонам и sin":
						figur.triangle2(openGLControl);
						break;
					case "Треугольник по формуле Герона":
						figur.triangle3(openGLControl);
						break;
					case "Прямоугольный треугольник":
						figur.triangle4(openGLControl);
						break;
					case "Равносторонний треугольник":
						figur.triangle5(openGLControl);
						break;

					defalt: MessageBox.Show("Ненавижу блять вопросы");
						break;

				}
			}
        }
    }
}
