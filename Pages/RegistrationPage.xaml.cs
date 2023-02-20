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
using ShurBolCofeeHouse.DataBase;
using static ShurBolCofeeHouse.Classes.EntityClass;

namespace ShurBolCofeeHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            cmbGender.ItemsSource = Context.Gender.ToList();
            cmbGender.SelectedIndex = 0;
            cmbGender.DisplayMemberPath = "Name";

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            //Валидация
            if (string.IsNullOrEmpty(tboxRegLogin.Text))
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }

            //Проверка на уникальность
            var authUser = Context.Client.ToList().Where(i => i.Login == tboxRegLogin.Text).FirstOrDefault();
            if (authUser != null)
            {
                MessageBox.Show("Логин занят!");
                return;
            }

            //Добавление в БД

            DataBase.Client client = new DataBase.Client();
            client.IDGender = (cmbGender.SelectedItem as DataBase.Gender).IDGender;
            client.Login = tboxRegLogin.Text;
            client.Password = tboxRegLogin.Text;// исправить на PasswordBox
            client.FirstName = tboxRegFirstName.Text;
            client.LastName = tboxRegLastName.Text;
            client.Birthday = dpRegBirthday.SelectedDate.Value;
            client.Phone = tboxRegPhone.Text;
            client.Mail = tboxRegMail.Text;

            Context.Client.Add(client);
            Context.SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
