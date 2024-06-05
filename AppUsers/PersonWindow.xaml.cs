using ControlzEx.Standard;
using MahApps.Metro.Controls;
using System;
using System.Collections;
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
using System.Xml.Linq;

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        private ApplicationContext db;
        public static User _user_now;

        public PersonWindow(User user_now)
        {
            InitializeComponent();
            DataContext = this;
            db = new ApplicationContext();

            CurrentLoginTextBox.Text += user_now.Name;
            _user_now = user_now;

            if (user_now.Role == "s")
            {
                
            }
            else
            {

            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindows windowAuth = new AuthWindows();
            windowAuth.Show();
            this.Close();
        }

        

     

        private void WorkflowBtn(object sender, RoutedEventArgs e)
        {
            string need = "";
            switch (((Button)sender).Content)
            {
                case "Пункты":
                    need = "Cores";
                    break;
                case "Ископаемые":
                    need = "Places";
                    break;
                case "Месторождения":
                    need = "Cores_places";
                    break;
            }

            TODO windowAuth = new TODO(need);
            windowAuth.Show();
            this.Close();
        }
    }
}
