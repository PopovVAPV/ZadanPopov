using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanPopov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            try
            {
                connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StudentEval; Integrated Security = SSPI;");
                connection.Open();
                Out.Text = "Сервер подключен";
            }
            catch
            {
                Out.Text = "Не удалось подключиться";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Close();
                Out.Text = "Сервер отключен";
            }
            catch
            {
                Out.Text = "Не удалось отключиться";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT * FROM Eval";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT FIO FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT SrEval FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
         sqlDataReader.Close();
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string number = Convert.ToString(Ind.Text);
            string Select1 = @"SELECT MinSrEval FROM Eval WHERE SrEval > " + number;
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT DISTINCT MinSrEval FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Vivod.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Vivod.Text += sqlDataReader[i] + "\t";
                }
                Vivod.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT DISTINCT MIN(SrEval) FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT DISTINCT MAX(SrEval) FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string Select1 = @"SELECT DISTINCT COUNTTTTT(SrEval) FROM Eval ";
            SqlCommand command = new SqlCommand(Select1, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            Viv.Text = "";
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    Viv.Text += sqlDataReader[i] + "\t";
                }
                Viv.Text += "\n";

            }
            sqlDataReader.Close();
        }
    }
}
