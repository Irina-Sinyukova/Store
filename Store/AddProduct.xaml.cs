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
using Store.Classes;

namespace Store
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop()
            {
                NameProduct = TxbName.Text,
                CountProduct = int.Parse(TxbCount.Text),
                PriceProduct = double.Parse(TxbPrice.Text),
                ShopProduct = TxbShop.Text
            };
            ConnectHelper.shops.Add(shop);
            this.Close();
        }
    }
}
