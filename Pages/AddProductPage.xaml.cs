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
using Microsoft.Win32;
using System.IO;

namespace ShurBolCofeeHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        private string pathPhoto = null;

        public AddProductPage()
        {
            InitializeComponent();

  
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = tboxAddProdName.Text;
            product.Description = tboxAddProdDesc.Text;
            if (pathPhoto != null)
            {
                product.Picture = File.ReadAllBytes(pathPhoto).ToString();
            }

            Context.Product.Add(product);

            Context.SaveChanges();
            MessageBox.Show("OK");
        }

        private void btnAddImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                imgAddProd.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
        }
    }
}
