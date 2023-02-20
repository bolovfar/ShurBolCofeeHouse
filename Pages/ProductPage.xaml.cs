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


using static ShurBolCofeeHouse.Classes.EntityClass;
using ShurBolCofeeHouse.Windows;
using ShurBolCofeeHouse.DataBase;

namespace ShurBolCofeeHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            GetProduct();
        }

        private void GetProduct() 
        {
            List<Product> stuffList = new List<Product>();

            stuffList = Context.Product.ToList();

            lvProdList.ItemsSource = stuffList;
        }
    }
}
