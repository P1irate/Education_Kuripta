using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace test
{
    public class General_Function
    {
		Sql_Command SC = new Sql_Command();
		public void Answer(int id_task, RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4)
		{
			int rand = 0;
			double answer= SC.Getting_Answer(id_task);

			Random rnd = new Random();
			rand = rnd.Next(1,5);
			switch (rand)
			{
				case 1:
					r1.Content = answer;
					do
					{
						r2.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 1);
						r3.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 2);
						r4.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 0);
					}
					while  ((r2.Content == r1.Content) || (r2.Content == r3.Content) || (r2.Content == r4.Content) ||
					(r3.Content == r4.Content) || (r3.Content == r1.Content));;
					break;
				case 2:
					r2.Content = answer;
					do
					{
						r4.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 1);
						r1.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 2);
						r3.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 0);
					}
					while ((r2.Content == r1.Content) || (r2.Content == r3.Content) || (r2.Content == r4.Content) ||
					(r3.Content == r4.Content) || (r3.Content == r1.Content));
					break;
				case 3:
					r3.Content = answer;
					do
					{
						r1.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 1);
						r2.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 2);
						r4.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 0);
					}
					while ((r2.Content == r1.Content) || (r2.Content == r3.Content) || (r2.Content == r4.Content) ||
					(r3.Content == r4.Content) || (r3.Content == r1.Content));
					break;
				case 4:
					r4.Content = answer;
					do
					{
						r1.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 1);
						r3.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 2);
						r2.Content = Math.Round(rnd.NextDouble() * ((answer + 20) - (answer - 20) + (answer - 20)), 0);
					}
					while ((r2.Content == r1.Content) || (r2.Content == r3.Content) || (r2.Content == r4.Content) ||
					(r3.Content == r4.Content) || (r3.Content == r1.Content));
					break;
				default: break;
			}
			


		}



    }
}
