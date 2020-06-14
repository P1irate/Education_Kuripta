using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace test
{

    public class Sql_Command
    {
        Ganeral_Variable GV = new Ganeral_Variable();

        public string Getting_Task(int id_task)
        {
            string task = null;
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Task FROM Practice WHERE ID_P = " + id_task, connection);
                    task = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                
            }
            return clubOfHating63(task);
        }

        public double Getting_Answer(int id_task)
        {
            double answer = 0;
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Answer FROM Practice WHERE ID_P = " + id_task, connection);
                    answer = (double)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
            return answer;
        }
        public string Getting_Solution(int id_task)
        {
            string solution =null;
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Solution FROM Practice WHERE ID_P = " + id_task, connection);
                    solution = Convert.ToString(command.ExecuteScalar());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return clubOfHating63(solution);
        }

        public string Getting_Theory(int ID_Theory)
        {
            string Content = null;
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Content FROM Theory WHERE ID_T = " + ID_Theory, connection);
                    Content = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return clubOfHating63(Content);
            }
        }

        public Boolean Add_User(string name, string password)
        {
            Boolean answ = false ;
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                if (name != null && password != null )
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("insert into Users (UserName, UserPas) values(@UserName, @UserPas)", connection);
                        connection.Open();
                        cmd.Parameters.AddWithValue("@UserName", name);
                        cmd.Parameters.AddWithValue("@UserPas", password);
                        if (Find_User(name, password) == true)
                        {
                            MessageBox.Show("Такой пользователь уже существует ");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            answ = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    } 
                }
                else
                {
                    MessageBox.Show("Введите логин или пароль");
                }
            }
            return answ;
        }
        public Boolean Find_User(string name, string password)
        {
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT UserName FROM Users WHERE UserName = '" + name + "'", connection);           
                    SqlCommand command_pas = new SqlCommand("SELECT UserPas FROM Users WHERE UserPas = '" + password + "'", connection);
                    string name_temp = Convert.ToString(command.ExecuteScalar());
                    string pas_temp = Convert.ToString(command_pas.ExecuteScalar());
                    
                    if (name == name_temp)
                    {
						if ((password == pas_temp) && (password != null))
						{
							return true;
						}
                        else
                        {
							return false;
						}
                    }
                    else return false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                    
                }
                finally
                {
                    connection.Close();
                }
                
            }
        }

        public void Chapter(ListBox ListTheory)
        {
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
				try
				{
					connection.Open();
					ListBox lb = new ListBox();
					SqlCommand command = new SqlCommand("SELECT Name_Chapter FROM Chapter", connection);
					int i = 0;
					ListTheory.Items.Clear();
					SqlDataReader dataReader = command.ExecuteReader();
					if (dataReader.HasRows)
					{
						while (dataReader.Read())
						{
							ListTheory.Items.Add(dataReader.GetString(i));
						}
					}
				}
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
				{
                    connection.Close();
				}

            }

        }

        public int Getting_Id_Theame(string name)
        {
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID FROM Chapter WHERE Name_Chapter = '" + name + "'", connection);
                    int Id_Theme = Convert.ToInt32(command.ExecuteScalar());
                    return Id_Theme;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }               
            }
        }

        public void Getting_Id_Task(int ID)
        {

            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
					Random rnd = new Random();
					int i = 0;
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID_P FROM Practice WHERE ID = " + ID, connection);

                    if (Ganeral_Variable.Id_Task != null)
                    {
                        Ganeral_Variable.Id_Task.Clear();
                    }                   
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read() && i<20)
                        {
							if(rnd.Next(0, 3) == 1 || rnd.Next(0, 3) == 2)
							{
                                Ganeral_Variable.Id_Task.Add(dataReader.GetInt32(0));
								i++;
							}
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }
        public void Getting_Id_Theory(int ID)
        {

            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID_T FROM Theory WHERE ID = " + ID, connection);

                    if (Ganeral_Variable.Id_Theme != null)
                    {
                        Ganeral_Variable.Id_Theme.Clear();
                    }
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Ganeral_Variable.Id_Theme.Add(dataReader.GetInt32(0));
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        public string Getting_Name_Theory(int ID_Theory)
		{
			using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand command = new SqlCommand("SELECT Name_Theory FROM Theory WHERE ID_T = " + ID_Theory, connection);		        
					string name = (string)command.ExecuteScalar();
					connection.Close();
					return name;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return null;
				}
				finally
				{
					connection.Close();
				}


			}
		}
        public void Getting_Id_user(string user_log,string user_pas)
        {
            using (SqlConnection connection = new SqlConnection(GV.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select UserID From Users WHERE UserName = '"+user_log+"' and UserPas = '"+user_pas+"'", connection);
                    Ganeral_Variable.ID_user = (int)command.ExecuteScalar();
                    connection.Close();
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        public string clubOfHating63(string text)
        {
			string resText = "";
            foreach (char c in text)
            {
                if (c != '?') resText += c;
            }
            if(text.Last() == '?') resText += text.Last();
            return resText;
        }

        
    }

}
