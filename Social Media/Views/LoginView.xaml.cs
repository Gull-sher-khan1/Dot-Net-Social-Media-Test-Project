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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Social_Media.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        LinqToSqlDataClassesDataContext _dataContext;
        public LoginView(LinqToSqlDataClassesDataContext dc)
        {
            InitializeComponent();
            _dataContext = dc;
        }

        private void UserLogin(object sender, RoutedEventArgs e)
        {
            Person inputPerson = new Person()
            {
                Name = UserName.Text,
                Password = UserPassword.Password
            };
            if (inputPerson.Exists(_dataContext))
            {
                Window window = Window.GetWindow(this);
                MainWindow.LoggedInUser = inputPerson;
                // TODO: Add Home Page view
                window.Content = "";
            }
            else
            {
                MessageBox.Show("Wrong Name or Password");
            }
        }
        
        private void UserSignup(object sender, RoutedEventArgs e)
        {

        }
    }
}
