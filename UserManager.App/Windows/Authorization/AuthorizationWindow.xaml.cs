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
using UserManager.Models.Table;

namespace UserManager.App.Windows.Authorization
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            InputLogin.Clear();
            InputPassword.Clear();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            var login = InputLogin.Text;
            var password = InputPassword.Password;
            var accounts = new TableAccount().GetTable();
            var account = accounts.Find(a => a.Login == login && a.Password == password);
            if (account is null)
            {
                MessageBox.Show("Неправельно ввели логин или пароль!!!", 
                    "Ошибка авторизации",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }else
            {
                MessageBox.Show("Вы успешно авторизовались!!", 
                    "Успешная авторизация", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Information);
            }
        }
    }
}
