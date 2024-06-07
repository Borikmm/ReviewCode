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
                case "CorePlaces":
                    show_CorePlaces();
                    break;
            }
            update_table("all");
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

        private void show_CorePlaces()
        {
            DGridCore_place.Visibility = Visibility.Visible;
            //DGridCore_place.ItemsSource = db.CorePlaces.ToList();
        }

        private void update_table(string name_table)
        {
            switch (name_table)
            {
                case "Cores":
                    DGridCores.ItemsSource = db.Cores.ToList();
                    return;
                case "Places":

                    DGridPlaces.ItemsSource = db.Places.ToList();
                    return;

                case "CorePlaces":
                    DGridCore_place.ItemsSource = db.CorePlaces.ToList();
                    return;
            }
        }

      

        private void AddItem(object sender, RoutedEventArgs e)
        {
            AddTask windowAuth = new AddTask(_table_now);
            windowAuth.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {

            PersonWindow windowAuth = new PersonWindow(PersonWindow._user_now);
            windowAuth.Show();
            this.Close();
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

                    case "CorePlaces":
                        CorePlace need2 = DGridCores.SelectedItem as CorePlace;
                        db = new ApplicationContext();

                        var ord2 = db.CorePlaces.Where(c => c.id == need2.id).FirstOrDefault();
                        db.CorePlaces.Remove(ord2);
                        db.SaveChanges();

                        DGridCore_place.ItemsSource = db.CorePlaces.ToList();
                        return;
                }
            }
            catch { }
        }

    

        private void DGridRoles_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

            switch (_table_now)
            {
                case "Cores":

                    
                    var editedRole = DGridCores.SelectedItem as Core; // Получаем отредактированный объект Role

                    if (editedRole != null)
                    {
                        db = new ApplicationContext();
                        var existingRole = db.Cores.Find(editedRole.id); // Находим редактируемую роль в базе данных
                        if (existingRole != null)
                        {


                            existingRole.Name = editedRole.Name; // Обновляем имя роли
                                                                 // Другие обновления полей, если необходимо

                            // Копируем другие значения из editedRole в existingRole
                            existingRole.Price = editedRole.Price;
                            existingRole.NumberFind = editedRole.NumberFind;
                            db.SaveChanges(); // Сохраняем изменения в базе данных
                        }
                    }



                    break;
                case "Places":
                    var editedRole1 = DGridPlaces.SelectedItem as Place; // Получаем отредактированный объект Role

                    if (editedRole1 != null)
                    {
                        db = new ApplicationContext();
                        var existingRole1 = db.Places.Find(editedRole1.id); // Находим редактируемую роль в базе данных
                        if (existingRole1 != null)
                        {


                            existingRole1.Name = editedRole1.Name; // Обновляем имя роли
                                                                 // Другие обновления полей, если необходимо

                            // Копируем другие значения из editedRole в existingRole
                            existingRole1.BandWidth = editedRole1.BandWidth;

                            db.SaveChanges(); // Сохраняем изменения в базе данных
                        }
                    }


                    break;

                case "CorePlaces":
                    var editedRole2 = DGridCore_place.SelectedItem as CorePlace; // Получаем отредактированный объект Role

                    if (editedRole2 != null)
                    {
                        db = new ApplicationContext();
                        var existingRole2 = db.CorePlaces.Find(editedRole2.id); // Находим редактируемую роль в базе данных
                        if (existingRole2 != null)
                        {


                            existingRole2.Storage = editedRole2.Storage; // Обновляем имя роли
                                                                 // Другие обновления полей, если необходимо

                            // Копируем другие значения из editedRole в existingRole
                            existingRole2.Open = editedRole2.Open;
                            existingRole2.Close = editedRole2.Close;
                            existingRole2.OurselfPrice = editedRole2.OurselfPrice;
                            existingRole2.CoreId = editedRole2.CoreId;
                            existingRole2.PlaceId = editedRole2.PlaceId;

                            db.SaveChanges(); // Сохраняем изменения в базе данных
                        }
                    }

                    break;
            }
        }
        // Метод который вызывается в зависимости от текста внутри поля
        private void TxtSearch_TextChanged(object sender, RoutedEventArgs e)
        {

            switch (_table_now)
            {
                case "Cores":

                    db = new ApplicationContext();
                    if (txtSearch.Text != "Поиск по названию...")
                    {

                        string searchText = txtSearch.Text.ToLower();

                        DGridCores.ItemsSource = db.Cores.ToList().Where(role => role.Name.ToLower().Contains(searchText)).ToList();
                    }
                    else
                    {
                        DGridCores.ItemsSource = db.Cores.ToList();
                    }
                    return;
                case "Places":
                    db = new ApplicationContext();
                    if (txtSearch.Text != "Поиск по названию...")
                    {

                        string searchText = txtSearch.Text.ToLower();

                        DGridPlaces.ItemsSource = db.Places.ToList().Where(role => role.Name.ToLower().Contains(searchText)).ToList();
                    }
                    else
                    {
                        DGridPlaces.ItemsSource = db.Places.ToList();
                    }
                    return;

                case "CorePlaces":
                    db = new ApplicationContext();
                    if (txtSearch.Text != "Поиск по названию...")
                    {

                        string searchText = txtSearch.Text.ToLower();

                        DGridCore_place.ItemsSource = db.CorePlaces.ToList().Where(role => role.Close.ToLower().Contains(searchText)).ToList();
                    }
                    else
                    {
                        DGridCore_place.ItemsSource = db.CorePlaces.ToList();
                    }
                    return;
            }



        }

        private void LostFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "Поиск по названию...";
        }

        private void SetFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
