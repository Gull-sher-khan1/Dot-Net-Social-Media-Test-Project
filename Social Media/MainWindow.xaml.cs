using Social_Media.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Social_Media
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Person LoggedInUser { get; set; }
        public LinqToSqlDataClassesDataContext _dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Social_Media.Properties.Settings.SocialMediaConnectionString"].ConnectionString;
            _dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            if(LoggedInUser == null)
            {
                MainContent.Content = new LoginView(_dataContext);
            }
        }
    }
}
