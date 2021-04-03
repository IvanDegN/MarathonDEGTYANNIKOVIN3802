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

namespace MarathonDEGTYANNIKOVIN3802
{
    /// <summary>
    /// Логика взаимодействия для RegisterAsRunner.xaml
    /// </summary>
    public partial class RegisterAsRunner : Window
    {
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

        private void Password_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Password.Text = "";
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            Password.Text = "Enter your password";
        }

        private void RepeatPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            RepeatPassword.Text = "";
        }

        private void RepeatPassword_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RepeatPassword.Text = "";
        }

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





        //  private void ClearClick(object sender, MouseButtonEventArgs e)
        //  {
        //        Ema.Clear();
        ////    textOut.Clear();
        //    textOut.Background = Background = Brushes.White;
        // }
    }
}
