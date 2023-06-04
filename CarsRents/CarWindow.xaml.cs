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
    public partial class CarWindow : Window
    {
        Car _car;
        MainWindow _mw;

        public CarWindow(MainWindow mw, Car car = null)
        {
            _mw = mw;
            if (car is null)
                _car = new Car() { Id = 0 };
            else
                _car = car;

            DataContext = _car;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
        }

        private bool Save()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(tbModel.Text))
                errors.AppendLine("Укажите модель");
            if (string.IsNullOrWhiteSpace(tbLicensePlate.Text))
                errors.AppendLine("Укажите гос. номер");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (_car.Id == 0)
                Context.GetContext().Cars.Add(_car);

            try
            {
                Context.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
        {
            if (Save())
                Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mw.UpdateCarsList();
        }
    }
}
