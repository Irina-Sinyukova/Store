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
using Store.Classes;
using System.IO;
using Microsoft.Win32;

namespace Store
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List<Shop> shops = new List<Shop>();
        public MainWindow()
        {
            InitializeComponent();
            ConnectHelper.shops.Add(new Shop("Молоко", 100, 100.90, "Магнит"));
            ConnectHelper.shops.Add(new Shop("Торт'Чародейка'", 200, 279.90, "Азбука вкуса"));
            ConnectHelper.shops.Add(new Shop("Масло", 255, 65.90, "Пятёрочка"));
            ConnectHelper.shops.Add(new Shop("Сыр", 99, 150.01, "Ашан"));
            ConnectHelper.shops.Add(new Shop("Курица", 58, 85.00, "Магнит"));
            ConnectHelper.shops.Add(new Shop("Сало", 50, 93.90, "Авоська"));
            ConnectHelper.shops.Add(new Shop("Печёнка", 75, 72.01, "Азбука вкуса"));
            ConnectHelper.shops.Add(new Shop("Рыба", 83, 79.00, "Ашан"));

            DtgListProduct.ItemsSource = ConnectHelper.shops;
            //shops.Add(new Shop("Молоко", 100, 100.90, "Магнит"));
            //shops.Add(new Shop("Торт'Чародейка'", 200, 279.90, "Азбука вкуса"));
            //shops.Add(new Shop("Масло", 255, 65.90, "Пятёрочка"));
            //shops.Add(new Shop("Сыр", 99, 150.01, "Ашан"));
            //shops.Add(new Shop("Курица", 58, 85.00, "Магнит"));
            //shops.Add(new Shop("Сало", 50, 93.90, "Авоська"));
            //shops.Add(new Shop("Печёнка", 75, 72.01, "Азбука вкуса"));
            //shops.Add(new Shop("Рыба", 83, 79.00, "Ашан"));
        }
        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            DtgListProduct.ItemsSource = ConnectHelper.shops.ToList();
            DtgListProduct.SelectedIndex = -1;

        }
        /// <summary>
        /// сортировка по алфавиту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbUp_Checked(object sender, RoutedEventArgs e)
        {
            DtgListProduct.ItemsSource = ConnectHelper.shops.OrderBy(x => x.NameProduct).ToList();
        }
        /// <summary>
        /// сортировка в обратном порядке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbDown_Checked(object sender, RoutedEventArgs e)
        {
            DtgListProduct.ItemsSource = ConnectHelper.shops.OrderByDescending(x => x.NameProduct).ToList();
        }
        /// <summary>
        /// поиск по названию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DtgListProduct.ItemsSource = ConnectHelper.shops.Where(x =>
                x.NameProduct.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();
        }

        /// <summary>
        /// фильтр по количеству
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (CmbFiltr.SelectedIndex == 0)
            {
                DtgListProduct.ItemsSource = ConnectHelper.shops.Where(x =>
                    x.CountProduct >= 0 && x.CountProduct <= 10).ToList();
                MessageBox.Show("Недостаточное количество препаратов на складе!",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                if (CmbFiltr.SelectedIndex == 1)
            {
                DtgListProduct.ItemsSource = ConnectHelper.shops.Where(x =>
                    x.CountProduct >= 11 && x.CountProduct <= 50).ToList();
                MessageBox.Show("Необходимо пополнить запасы препаратов в ближайшее время",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                DtgListProduct.ItemsSource = ConnectHelper.shops.Where(x =>
                   x.CountProduct >= 51).ToList();
                MessageBox.Show("Достаточное количество препаратов на складе!",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        


        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            DtgListProduct.ItemsSource = null;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)

        {
            AddProduct windowAdd = new AddProduct((sender as Button).DataContext as Shop);
            windowAdd.ShowDialog();
        }

        /// <summary>
        /// удаление записи с подтверждением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var resMessage = MessageBox.Show("Удалить запись?", "Подтверждение",
               MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resMessage == MessageBoxResult.Yes)
            {
                int ind = DtgListProduct.SelectedIndex;
                ConnectHelper.shops.RemoveAt(ind);
                DtgListProduct.ItemsSource = ConnectHelper.shops.ToList();
                ConnectHelper.SaveListToFile(@"ListProduct.txt");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddProduct windowAdd = new AddProduct();
            windowAdd.ShowDialog();
        }

        /// <summary>
        /// открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            //загрузка данных из файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ((bool)openFileDialog.ShowDialog())
            {
                // получаем выбранный файл
                ConnectHelper.fileName = openFileDialog.FileName;
                ConnectHelper.ReadListFromFile(ConnectHelper.fileName);
                //ConnectHelper.ReadListFromFile(@"ListProduct.txt");
            }
            else
                return;


            DtgListProduct.ItemsSource = ConnectHelper.shops.ToList();
        }
        /// <summary>
        /// сохранить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if ((bool)saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                ConnectHelper.SaveListToFile(file);
            }
        }
    }
}
