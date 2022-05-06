using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Classes
{
    public class Shop
    {//поля
        string nameProduct;
        int countProduct;
        double priceProduct;
        string shopProduct;

        //свойства
        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }
        public int CountProduct
        {
            get { return countProduct; }
            set { countProduct = value; }
        }
        public double PriceProduct
        {
            get { return priceProduct; }
            set { priceProduct = value; }
        }
        public string ShopProduct
        {
            get { return shopProduct; }
            set { shopProduct = value; }
        }
        //конструкторы
        public Shop()
        {
            nameProduct = "";
            countProduct = 0;
            priceProduct = 0.0;
            shopProduct = "";
        }
        public Shop(string name, int count, double price, string shop)
        {
            nameProduct = name;
            countProduct = count;
            priceProduct = price;
            shopProduct = shop;
        }
    }
}
