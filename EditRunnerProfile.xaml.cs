using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace MarathonDEGTYANNIKOVIN3802
{
    /// <summary>
    /// Логика взаимодействия для EditRunnerProfile.xaml
    /// </summary>
    public partial class EditRunnerProfile : Window
    {
        public static string connectionStr = @"Data Source=PCSQLSTUD01;Initial Catalog = 10180030; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";
        public EditRunnerProfile()
        {
            InitializeComponent();
            fill_CB();
        }

        private void RunnerEdit_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        void fill_CB()
        {

            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand sql = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = sql.ExecuteReader();
            ClassSQL.Query("select * from Gender");
            while (reader.Read())
            {
                string Gender = reader.GetString(1);
                ComboBoxGender.Items.Add(Gender);
            }
            connection.Close();
        }
    }
}
