using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Store.Classes
{/// <summary>
/// вспомогательный класс
/// </summary>
    class ConnectHelper
    {
        public static List<Shop> shops = new List<Shop>();

        public static string fileName;

        public static void ReadListFromFile(string filename)
        {
            try
            {
                StreamReader streamReader = new StreamReader(filename, Encoding.UTF8);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] items = line.Split(';');
                    Shop shop = new Shop()
                    {
                        NameProduct = items[0].Trim(),
                        CountProduct = int.Parse(items[1].Trim()),
                        PriceProduct = double.Parse(items[2].Trim()),
                        ShopProduct = items[3].Trim()
                    };
                    shops.Add(shop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        public static void SaveListToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, false, Encoding.UTF8);
            foreach (Shop sh in shops)
            {
                streamWriter.WriteLine($"{sh.NameProduct};{sh.CountProduct};{sh.PriceProduct};{sh.ShopProduct}");
            }
            streamWriter.Close();
        }

    }
}
