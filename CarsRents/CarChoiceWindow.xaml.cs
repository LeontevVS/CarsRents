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
using System.Windows.Shapes;

namespace CarsRents
{
    public partial class CarChoiceWindow : Window
    {
        CarRentsWindow _crw;

        public CarChoiceWindow(CarRentsWindow crw)
        {
            InitializeComponent();
            UpdateCarsList();
            _crw = crw;
        }

        public void UpdateCarsList() => DGridCars.ItemsSource = Context.GetContext().Cars.ToList();

        private void SetSelectedCar()
        {
            Car car = DGridCars.SelectedItem as Car;
            _crw.rent.Car = car;
            _crw.rent.CarId = car.Id;
            _crw.tbCar.Text = car.Model;
            Close();
        }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            if (!(DGridCars.SelectedItem is null))
                SetSelectedCar();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SetSelectedCar();
        }
    }
}
