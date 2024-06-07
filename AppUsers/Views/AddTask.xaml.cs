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
                case "CorePlaces":
                    show_CorePlaces();
                    break;
            }
        }


        // Показ полей в зависимости от вида таблицы
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

        private void show_CorePlaces()
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
                    Place user1 = new Place(one_input.Text, two_input.Text);
                    db.Places.Add(user1);
                    db.SaveChanges();

                    PersonWindow windowAuth2 = new PersonWindow(PersonWindow._user_now);
                    windowAuth2.Show();
                    this.Close();
                    break;
                case "CorePlaces":
                    CorePlace user2 = new CorePlace(Convert.ToInt16(one_input.Text), Convert.ToInt16(two_input.Text), Convert.ToInt16(fife_input.Text), Convert.ToInt16(six_input.Text), three_input.Text, for_input.Text);
                    db.CorePlaces.Add(user2);
                    db.SaveChanges();

                    PersonWindow windowAuth3 = new PersonWindow(PersonWindow._user_now);
                    windowAuth3.Show();
                    this.Close();
                    break;
            }

        }
    }
}
