using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace PixelManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            AdminLogged adminLogged = new AdminLogged();
            adminLogged.Show();
            this.Close();
        }

        public async void Login(object sender, RoutedEventArgs e)
        {
            var responseString = await client.GetStringAsync("https://localhost:44303/api/Employee/" + TB_Login.Text + "/" + TB_Password.Password);
            if (responseString == "[]") L_LoginError.Visibility = Visibility.Visible;
            else
            {
                EmployeeLogged employeeLogged = new EmployeeLogged();
                employeeLogged.Show();
                this.Close();
            }

            //L_Auth.Content = responseString != "[]" ? "good" : "bad";
        }

    }
}
