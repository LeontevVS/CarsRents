using CarsRents;
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

namespace CarsRents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden;
            AuthorisationWindow authorization = new AuthorisationWindow(this);
            authorization.Show();
            UpdateCarsList();
            UpdateCarRentsList();
            UpdateUsersList();
        }

        public void UpdateCarsList() => DGridCars.ItemsSource = Context.GetContext().Cars.ToList();
        public void UpdateCarRentsList() => DGridRents.ItemsSource = Context.GetContext().CarRents.ToList();
        public void UpdateUsersList() => DGridUsers.ItemsSource = Context.GetContext().Users.ToList();

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            if (TabCtrl.SelectedItem == TabRents)
            {
                CarRentsWindow wind = new CarRentsWindow(this);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabCars)
            {
                CarWindow wind = new CarWindow(this);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabUsers)
            {
                UserWindow wind = new UserWindow(this);
                wind.Show();
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TabCtrl.SelectedItem == TabRents)
            {
                CarRentsWindow wind = new CarRentsWindow(this, DGridRents.SelectedItem as CarRent);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabCars)
            {
                CarWindow wind = new CarWindow(this, DGridCars.SelectedItem as Car);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabUsers)
            {
                UserWindow wind = new UserWindow(this, DGridUsers.SelectedItem as User);
                wind.Show();
            }
        }
    }
}
