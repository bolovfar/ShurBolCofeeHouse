using ShurBolCofeeHouse.Pages;
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

namespace ShurBolCofeeHouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LbReg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Переход на окно регистрации
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
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
