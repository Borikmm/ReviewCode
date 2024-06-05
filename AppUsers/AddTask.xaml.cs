using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        private string _table_now;
        public AddTask(string table_now)
        {
            InitializeComponent();
            _table_now = table_now;

            var db = new ApplicationContext();

            switch (_table_now)
            {
                case "Cores":
                    show_cores();
                    break;
                case "Places":
                    show_places();
                    break;
                case "Cores_places":
                    show_cores_places();
                    break;
            }
        }



        private void show_cores()
        {
            one.Text = "Название руды";
            two.Text = "Цена";
            three.Text = "Единица измерения";
        }

        private void show_places()
        {
            one.Text = "Название пункта";
            two.Text = "Пропускная способность";
        }

        private void show_cores_places()
        {
            one.Text = "Код пункта";
            two.Text = "Код ископаемого";
            three.Text = "Дата открытия";
            forr.Text = "Дата закрытия";
            fife.Text = "Запасы";
            six.Text = "Себестоимость";
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();

            MessageBox.Show(_table_now);
            switch (_table_now)
            {
                case "Cores":
                    Core user = new Core(one_input.Text, two_input.Text, three_input.Text);
                    db.Cores.Add(user);
                    db.SaveChanges();

                    PersonWindow windowAuth = new PersonWindow(PersonWindow._user_now);
                    windowAuth.Show();
                    this.Close();
                    break;
                case "Places":
                    MessageBox.Show("wf");
                    Place user1 = new Place(one_input.Text, two_input.Text);
                    db.Places.Add(user1);
                    db.SaveChanges();

                    PersonWindow windowAuth2 = new PersonWindow(PersonWindow._user_now);
                    windowAuth2.Show();
                    this.Close();
                    break;
                case "Cores_places":
                    // string finish, string start, int roleid, int tableid, int number
                    Core_place user2 = new Core_place(Convert.ToInt16(one_input.Text), Convert.ToInt16(two_input.Text), Convert.ToInt16(fife_input.Text), Convert.ToInt16(six_input.Text), three_input.Text, for_input.Text);
                    db.Cores_places.Add(user2);
                    db.SaveChanges();

                    PersonWindow windowAuth3 = new PersonWindow(PersonWindow._user_now);
                    windowAuth3.Show();
                    this.Close();
                    break;
            }

        }
    }
}
