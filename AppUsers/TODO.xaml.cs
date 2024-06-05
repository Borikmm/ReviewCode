using ControlzEx.Standard;
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
using System.Xml;
using System.Xml.Linq;

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для TODO.xaml
    /// </summary>
    public partial class TODO : Window
    {
        ApplicationContext db;
        private string _table_now;
        public TODO(string table_now)
        {
            InitializeComponent();


            DataContext = this;
            db = new ApplicationContext();
            _table_now = table_now;


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



            var need1 = get_t(table_now);
            need1.Insert(0, "all");
            ComboGroups.ItemsSource = need1;

            update_workflow("all");
            //DGridUsers.ItemsSource = db.Workflows.ToList();
        }


        private void show_cores()
        {
            DGridCores.Visibility = Visibility.Visible;
            DGridCores.ItemsSource = db.Cores.ToList();
        }

        private void show_places()
        {
            DGridPlaces.Visibility = Visibility.Visible;
            DGridPlaces.ItemsSource = db.Places.ToList();
        }

        private void show_cores_places()
        {
            DGridCore_place.Visibility = Visibility.Visible;
            DGridCore_place.ItemsSource = db.Cores_places.ToList();
        }


        public static List<string> get_t(string name)
        {
            var db = new ApplicationContext();
            var need = new List<string>();

            switch (name)
            {
                case "Cores":
                    foreach (var t in db.Cores.ToList())
                    {
                        need.Add(t.Name);
                    }
                    break;
                case "Places":
                    {
                        foreach (var t in db.Places.ToList())
                        {
                            need.Add(t.Name);
                        }
                        break;
                    }
                case "Cores_places":
                    foreach (var t in db.Cores_places.ToList())
                    {
                        need.Add(t.Close);
                    }
                    break;
            }

 

            return need;
        }

        private void update_workflow(string name_table)
        {
            switch (name_table)
            {
                case "Cores":
                    DGridCores.ItemsSource = db.Cores.ToList();
                    return;
                case "Places":

                    DGridPlaces.ItemsSource = db.Places.ToList();
                    return;

                case "Cores_places":
                    DGridCore_place.ItemsSource = db.Cores_places.ToList();
                    return;
            }
        }

      

        private void AddTask(object sender, RoutedEventArgs e)
        {
            AddTask windowAuth = new AddTask(_table_now);
            windowAuth.Show();
            this.Close();
        }


        private void FindItem(string name)
        {

        }
    

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //update_workflow(ComboGroups.SelectedValue.ToString());
            //DGridUsers.Items.Refresh();
        }

        private void AddSubjects(object sender, RoutedEventArgs e)
        {

        }

        private void Add_workflow(object sender, RoutedEventArgs e)
        {
            AddTask windowAuth = new AddTask(_table_now);
            windowAuth.Show();
            this.Close();
        }

        private void DeleteBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_table_now)
                {
                    case "Cores":


                        Core need = DGridCores.SelectedItem as Core;
                        db = new ApplicationContext();

                        var ord = db.Cores.Where(c => c.id == need.id).FirstOrDefault();
                        db.Cores.Remove(ord);
                        db.SaveChanges();


                        DGridCores.ItemsSource = db.Cores.ToList();
                        return;
                    case "Places":
                        Place need1 = DGridPlaces.SelectedItem as Place;
                        db = new ApplicationContext();

                        var ord1 = db.Places.Where(c => c.id == need1.id).FirstOrDefault();
                        db.Places.Remove(ord1);
                        db.SaveChanges();


                        DGridPlaces.ItemsSource = db.Places.ToList();
                        return;

                    case "Cores_places":
                        Core_place need2 = DGridCores.SelectedItem as Core_place;
                        db = new ApplicationContext();

                        var ord2 = db.Cores_places.Where(c => c.id == need2.id).FirstOrDefault();
                        db.Cores_places.Remove(ord2);
                        db.SaveChanges();

                        DGridCore_place.ItemsSource = db.Cores_places.ToList();
                        return;
                }
            }
            catch { }
        }

        private void DataGridCell_Selected(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource.GetType() == typeof(DataGridCell))
            {
                // Starts the Edit on the row;
                System.Windows.Controls.DataGrid grd = (System.Windows.Controls.DataGrid)sender;
                grd.BeginEdit(e);
                grd.CancelEdit();
            }
        }

        private void DataGridCell_Selected2(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_table_now)
                {
                    case "Cores":


                        Core need = DGridCores.SelectedItem as Core;
                        db = new ApplicationContext();

                        var ord = db.Cores.Where(c => c.id == need.id).FirstOrDefault();
                        ord = need;
                        db.SaveChanges();



                        return;
                    case "Places":
                        Place need1 = DGridPlaces.SelectedItem as Place;
                        db = new ApplicationContext();

                        var ord1 = db.Places.Where(c => c.id == need1.id).FirstOrDefault();
                        ord1 = need1;
                        db.SaveChanges();


                        return;

                    case "Cores_places":
                        Core_place need2 = DGridCores.SelectedItem as Core_place;
                        db = new ApplicationContext();

                        var ord2 = db.Cores_places.Where(c => c.id == need2.id).FirstOrDefault();
                        ord2 = need2;
                        db.SaveChanges();

                        return;
                }
            }
            catch { }
        }
    }
}
