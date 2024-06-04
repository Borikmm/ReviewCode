using System;
using System.Collections.Generic;
using System.Linq;
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

        }

        private void show_places()
        {

        }

        private void show_cores_places()
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();


            if (Groups.Text is null || nameSubject.Text is null || nameTeacher.Text is null || Hours.Text is null)
            {
                MessageBox.Show("Какие то поля пустые(");
                return;
            }

            int result;
            
            if (!int.TryParse(Hours.Text, out result))
            {
                MessageBox.Show("Часы должны быть числом");
                return;
            }


/*            switch (_table_now)
            {
                case "Cores":
                    Core user = new Core(Groups.Text, nameSubject.Text, nameTeacher.Text, Hours.Text);
                    db.Cores.Add(user);
                    db.SaveChanges();

                    TODO windowAuth = new TODO(_table_now);
                    windowAuth.Show();
                    this.Close();
                    return;
                case "Places":
                    Place user1 = new Place(Groups.Text, nameSubject.Text, nameTeacher.Text, Hours.Text);
                    db.Places.Add(user1);
                    db.SaveChanges();

                    TODO windowAuth1 = new TODO(_table_now);
                    windowAuth1.Show();
                    this.Close();
                    return;
                case "Cores_places":
                    Core_place user2 = new Core_place(Groups.Text, nameSubject.Text, nameTeacher.Text, Hours.Text);
                    db.Cores_places.Add(user2);
                    db.SaveChanges();

                    TODO windowAuth2 = new TODO(_table_now);
                    windowAuth2.Show();
                    this.Close();
                    return;
            }
*/
        }
    }
}
