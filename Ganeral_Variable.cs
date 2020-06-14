using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace test
{

    
    public class Ganeral_Variable
    {
        public String ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public static string UserName;
        public string UserPas;
        public static List<double> Сorrect_Answer = new List<double> {0};
        public static List<string> User_Answer = new List<string> {null};
        public static string Theory;
        public string Task;
        public string Solution;
        public bool Login_Permission;
        public static int ID_Theme;
        public static List<int> Id_Theme = new List<int> { 0 };
        public static List<int> Id_Task = new List<int> {1};
       

    }
}
