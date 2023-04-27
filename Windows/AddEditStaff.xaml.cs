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
    /// Логика взаимодействия для AddEditStaff.xaml
    /// </summary>
    public partial class AddEditStaff : Window
    {
        public AddEditStaff()
        {
            InitializeComponent();
            cmbGender.ItemsSource = Context.Gender.ToList();
            cmbGender.SelectedIndex = 0;
            cmbGender.DisplayMemberPath = "Name";

            cmbPosition.ItemsSource = Context.Position.ToList();
            cmbPosition.SelectedIndex = 0;
            cmbPosition.DisplayMemberPath = "Name";

            if (Change == true)
            {
                Change = false;

                cmbGender.SelectedIndex = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().IDGender - 1;
                cmbPosition.SelectedIndex = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().IDPosition - 7;
                tbFirst.Text = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().FirstName;
                tbLast.Text = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().LastName;
                dpBirth.SelectedDate = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().Birthday;
                tbPhone.Text = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().Phone.ToString();
                tbLog.Text = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().Login.ToString();
                tbPass.Text = Context.Staff.ToList().Where(i => i.IDStaff == IDChange).FirstOrDefault().Password;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Staff stf = new Staff();

            stf.IDPosition = cmbPosition.SelectedIndex + 7;
            stf.IDGender = cmbGender.SelectedIndex + 1;
            stf.Login = tbLog.Text;
            stf.Password = tbPass.Text;
            stf.FirstName = tbFirst.Text;
            stf.LastName = tbLast.Text;
            stf.Birthday = dpBirth.SelectedDate.Value;
            stf.Phone = tbPhone.Text;

            Context.Staff.AddOrUpdate(stf);
            Context.SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
