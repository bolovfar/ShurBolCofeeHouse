using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
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

namespace ShurBolCofeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditClient.xaml
    /// </summary>
    public partial class AddEditClient : Window
    {
        public AddEditClient()
        {
            InitializeComponent();
            cmbGender.ItemsSource = Context.Gender.ToList();
            cmbGender.SelectedIndex = 0;
            cmbGender.DisplayMemberPath = "Name";

            if (Change == true)
            {
                Change = false;
                
                tbID.Text               = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().IDClient.ToString();
                cmbGender.SelectedIndex = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().IDGender - 1;
                tbEmail.Text            = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().Mail;
                tbFirst.Text            = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().FirstName;
                tbLast.Text             = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().LastName;
                dpBirth.SelectedDate    = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().Birthday;
                tbPhone.Text            = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().Phone.ToString();
                tbLog.Text              = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().Login.ToString();
                tbPass.Text             = Context.Client.ToList().Where(i => i.IDClient == IDChange).FirstOrDefault().Password;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Client clt = new Client();
            MessageBox.Show(Convert.ToInt32(tbID.Text).ToString());
            clt.IDClient = Convert.ToInt32(tbID.Text);
            clt.IDGender = cmbGender.SelectedIndex + 1;
            clt.Login = tbLog.Text;
            clt.Password = tbPass.Text;
            clt.FirstName = tbFirst.Text;
            clt.LastName = tbLast.Text;
            clt.Birthday = dpBirth.SelectedDate.Value;
            clt.Phone = tbPhone.Text;
            clt.Mail = tbEmail.Text;

            Context.Client.AddOrUpdate(clt);
            Context.SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
