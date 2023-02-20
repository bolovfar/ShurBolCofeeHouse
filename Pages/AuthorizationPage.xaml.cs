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
using ShurBolCofeeHouse.Classes;
using static ShurBolCofeeHouse.Classes.EntityClass;
using ShurBolCofeeHouse.Windows;
using ShurBolCofeeHouse.Pages;


namespace ShurBolCofeeHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void LbReg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Преход на окно регистрации.. Пока не работает, не видит фрейм.
            MessageBox.Show("Переход");
            //AuthRegFrame.Content = new RegistrationPage();
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            var authUser = Context.Client.ToList().Where(i => i.Login == tboxAuthLogin.Text && i.Password == tboxAuthPas.Text).FirstOrDefault();
            if (authUser != null)
            {
                MessageBox.Show("Успешно!");
                // переход на окно пользователя
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            
        }
    }
}
