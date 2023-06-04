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
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        private MainWindow _mainWindow;
        private List<User> _users = Context.GetContext().Users.ToList();

        public AuthorisationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Close();
            Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = _users.Find(x => x.Login == tbName.Text);
            if (user == null || pbPassword.Password != user.Password)
            {
                MessageBox.Show("Неверно введены имя или пароль");
            }
            else
            {
                _mainWindow.Visibility = Visibility.Visible;
                Close();
            }
        }
    }
}
