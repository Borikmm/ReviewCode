using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        List<string> logins;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            logins = new List<string>() { };
            foreach (User user in users)
            {
                logins.Add(user.Name);
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string role = TextBoxRole.Text.Trim();
            if(login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Логин должен быть не меньше 5 символов!";
                TextBoxLogin.Background = Brushes.DarkRed;
                return;
            }
            else if (role.Length < 5)
            {
                TextBoxRole.ToolTip = "Роля должен быть не меньше 5 символов!";
                TextBoxRole.Background = Brushes.DarkRed;
                return;
            }
            else
            {
                TextBoxLogin.ToolTip = " ";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxRole.ToolTip = " ";
                TextBoxRole.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегистрировались!");

                User user = new User(login, role);
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void Auth_Button_Click(object sender, RoutedEventArgs e)
        {
            AuthWindows windowAuth = new AuthWindows();
            windowAuth.Show();
            this.Close();
        }
    }
}
