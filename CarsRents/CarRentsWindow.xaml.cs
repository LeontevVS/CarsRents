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
    /// <summary>
    /// Логика взаимодействия для CarRentsWindow.xaml
    /// </summary>
    public partial class CarRentsWindow : Window
    {
        public CarRent rent;
        MainWindow _mw;

        public CarRentsWindow(MainWindow mw, CarRent rent = null)
        {
            _mw = mw;
            if (rent is null)
                this.rent = new CarRent() 
                { 
                    Id = 0, 
                    BeginDate = DateTime.Now, 
                    EndDate = DateTime.Now
                };
            else
                this.rent = rent;

            InitializeComponent();
            DataContext = this.rent;
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

            if (string.IsNullOrWhiteSpace(dpBeginDate.SelectedDate.ToString()))
                errors.AppendLine("Укажите Дату начала");
            if (string.IsNullOrWhiteSpace(dpBeginDate.SelectedDate.ToString()))
                errors.AppendLine("Укажите Дату окончания");
            if (string.IsNullOrWhiteSpace(tbDriverName.Text))
                errors.AppendLine("Укажите имя клиента");
            if (string.IsNullOrWhiteSpace(tbPassport.Text))
                errors.AppendLine("Укажите паспорт клиента");
            if (string.IsNullOrWhiteSpace(tbPrice.Text))
                errors.AppendLine("Укажите цену");
            if (string.IsNullOrWhiteSpace(tbDriverLicense.Text))
                errors.AppendLine("Укажите водительское удостоверение");
            if (string.IsNullOrWhiteSpace(tbCar.Text))
                errors.AppendLine("Укажите автомобиль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (rent.Id == 0)
                Context.GetContext().CarRents.Add(rent);

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
            _mw.UpdateCarRentsList();
        }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            CarChoiceWindow window = new CarChoiceWindow(this);
            window.Show();
        }
    }
}
