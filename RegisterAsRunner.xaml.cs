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
    /// Логика взаимодействия для RegisterAsRunner.xaml
    /// </summary>
    public partial class RegisterAsRunner : Window
    {
        public static string connectionStr = @"Data Source=PCSQLSTUD01;Initial Catalog = 10180030; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";

        public RegisterAsRunner()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

     /*   private void Email_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Email.Text = "";
            if (Email.Text == null)
            {
            Email.Text = "";
            Email.Foreground =  Foreground = Brushes.Black;
            }
            if(Email.Text != null)
            {
                Email.Foreground = Foreground = Brushes.Black;
            }
            
            
            
           // Email.Foreground = Foreground = Brushes.Gray;

        }

        */

        //private void Email_LostFocus(object sender, RoutedEventArgs e)
        //{
        //   // if(Email.Text == null)
        //  //  {
        //  //  Email.Text = "Enter your email address";
        //  //  }
            
        //    //Email.Foreground = Foreground = Brushes.Gray;
        //}

        //private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Email.Text = "Enter your email address";
        //    Password.Text = "Enter your password";
        //    RepeatPassword.Text = "Repeat your password";
        //}

        

        

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            bool hasBeenClicked = false;

            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void Email_GotFocus_1(object sender, RoutedEventArgs e)
        {
           Email.Visibility = Visibility.Hidden;
        }

        private void Email_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Email.Visibility = Visibility.Hidden;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            Password.Visibility = Visibility.Hidden;
        }

        private void Password_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Password.Visibility = Visibility.Hidden;
        }

        private void RepeatPassword_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RepeatPassword.Visibility = Visibility.Hidden;
        }

        private void RepeatPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            RepeatPassword.Visibility = Visibility.Hidden;
        }

        private void Name_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Name.Visibility = Visibility.Hidden;
        }

        private void LastName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LastName.Visibility = Visibility.Hidden;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.ShowDialog();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void ComboBox_MouseEnter(object sender, MouseEventArgs e)
        {

            
            ClassSQL.Query("SELECT * FROM Gender");

        }











        //  private void ClearClick(object sender, MouseButtonEventArgs e)
        //  {
        //        Ema.Clear();
        ////    textOut.Clear();
        //    textOut.Background = Background = Brushes.White;
        // }
    }
}
