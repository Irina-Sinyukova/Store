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
        int mode;
        public AddProduct()
        {
            InitializeComponent();
            mode = 0;
        }

        public AddProduct(Shop prod)
        {
            InitializeComponent();
            TxbName.Text = prod.NameProduct;
            TxbCount.Text = prod.CountProduct.ToString();
            TxbPrice.Text = prod.PriceProduct.ToString();
            TxbShop.Text = prod.ShopProduct.ToString();
            mode = 1;
            BtnAddProduct.Content = "Сохранить";
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                try
                {
                    Shop shop = new Shop()
                    {
                        NameProduct = TxbName.Text,
                        CountProduct = int.Parse(TxbCount.Text),
                        PriceProduct = double.Parse(TxbPrice.Text),
                        ShopProduct = TxbShop.Text
                    };
                    ConnectHelper.shops.Add(shop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }
            else
            {
                try
                {
                    for (int i = 0; i < ConnectHelper.shops.Count; i++)
                    {
                        if (ConnectHelper.shops[i].NameProduct == TxbName.Text)
                        {
                            ConnectHelper.shops[i].CountProduct = int.Parse(TxbCount.Text);
                            ConnectHelper.shops[i].PriceProduct = double.Parse(TxbPrice.Text);
                            ConnectHelper.shops[i].ShopProduct = TxbShop.Text;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }

            ConnectHelper.SaveListToFile(@"ListProduct.txt");
            this.Close();
        }
    }
}
