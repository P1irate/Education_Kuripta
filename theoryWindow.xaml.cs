using SharpGL.SceneGraph;
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
		private void openGLControl_OpenGLInitialized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
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
			imageSwap();
			
        }

        private void button_back_theme_Click(object sender, RoutedEventArgs e)
        {
            if (number_theme > 0)
            {
                number_theme--;
				Theme_label.Content = SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				Theme.Text = SC.Getting_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				imageSwap();

			}
		}

			private void button_next_theme_Click(object sender, RoutedEventArgs e)
        {
            if (number_theme<Ganeral_Variable.Id_Theme.Count -1)
            {
                number_theme++;
				Theme_label.Content = SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				Theme.Text = SC.Getting_Theory(Ganeral_Variable.Id_Theme[number_theme]);
				imageSwap();

			}
        }

		private void button_Return_theme_Click(object sender, RoutedEventArgs e)
		{
			startTheoryWindow startPracticeWindow = new startTheoryWindow();
			startPracticeWindow.Show();
			this.Close();
		}

	

		private void imageSwap()
		{
			switch (SC.Getting_Name_Theory(Ganeral_Variable.Id_Theme[number_theme]))
			{
				case "Квадрат по сторонам":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\кв1.jpg"));
					break;
				case "Квадрат по диагонали":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\кв2.jpg"));
					break;
				case "Параллелограмм по васоте и стороне":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\парам1.jpg"));
					break;
				case "Параллелограмм по диагонали и sin ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\парам2.jpg"));
					break;
				case "Прямоугольник по сторонам ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\пр.jpg"));
					break;
				case "Ромб по стороне и sin ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\р1.jpg"));
					break;
				case "Ромб по диагоналям ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\р2.jpg"));
					break;
				case "Ромб по стороне и высоте ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\р3.jpg"));
					break;
				case "Трапеция по основанию и высоте ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\трап.jpg"));
					break;
				case "Треугольник по стороне и высоте ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\тр1.jpg"));
					break;
				case "Треугольник по сторонам и sin ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\тр2.jpg"));
					break;
				case "Треугольник по формуле Герона ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\тр3.jpg"));
					break;
				case "Прямоугольный треугольник ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\тр4.jpg"));
					break;
				case "Равносторонний треугольник ":
					image.Source = new BitmapImage(new Uri("C:\\Users\\morko\\Source\\Repos\\P1irate\\Education_Kuripta\\pic\\тр5.jpg"));
					break;
				default:
					MessageBox.Show("Произошла непредвиденная ошибка");
					break;

			}
		}

	}
}
