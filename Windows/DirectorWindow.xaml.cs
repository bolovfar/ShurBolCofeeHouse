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
using ShurBolCofeeHouse.Pages;

using ShurBolCofeeHouse.Classes;
using ShurBolCofeeHouse.DataBase;
using static ShurBolCofeeHouse.Classes.EntityClass;

namespace ShurBolCofeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для DirectorWindow.xaml
    /// </summary>
    public partial class DirectorWindow : Window
    {
        private string pageNow;
        public DirectorWindow()
        {
            InitializeComponent();
            DirectorFrame.Content = new ClientPage();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Content)
            {
                case "Продукты":
                    pageNow = "Продукты";
                    DirectorFrame.Content = new ProductPage();
                    break;
                case "Клиенты":
                    pageNow = "Клиенты";
                    DirectorFrame.Content = new ClientPage();
                    break;
                case "Сотрудники":
                    pageNow = "Сотрудники";
                    DirectorFrame.Content = new StaffPage();
                    break;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Name == "btnEdit") Change = true;

            switch (pageNow)
            {
                case "Клиенты":
                    AddEditClient clt = new AddEditClient();
                    clt.Show();
                    break;
                case "Сотрудники":
                    AddEditStaff aes = new AddEditStaff();
                    aes.Show();
                    break;
                case "Продукты":
                    AddEditProduct aep = new AddEditProduct();
                    aep.Show();
                    break;
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
