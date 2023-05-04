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
    /// Логика взаимодействия для AddEditProduct.xaml
    /// </summary>
    public partial class AddEditProduct : Window
    {
        public AddEditProduct()
        {
            InitializeComponent();

            if (Change == true)
            {
                Change = false;

                
                tbID.Text    = Context.Product.ToList().Where(i => i.IDProduct == IDChange).FirstOrDefault().IDProduct.ToString();
                tbName.Text  = Context.Product.ToList().Where(i => i.IDProduct == IDChange).FirstOrDefault().Name;
                tbCost.Text  = Context.Product.ToList().Where(i => i.IDProduct == IDChange).FirstOrDefault().Cost.ToString();
                tbDescr.Text = Context.Product.ToList().Where(i => i.IDProduct == IDChange).FirstOrDefault().Description;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Product prd = new Product();

            prd.IDProduct = Convert.ToInt32(tbID.Text);
            prd.Name = tbName.Text;
            prd.Cost = Convert.ToDecimal(tbCost.Text);
            prd.Description = tbDescr.Text;

            Context.Product.AddOrUpdate(prd);
            Context.SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
