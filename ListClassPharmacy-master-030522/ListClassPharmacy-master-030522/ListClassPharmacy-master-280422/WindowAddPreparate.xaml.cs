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
using ListClass.Classes;

namespace ListClass
{
    /// <summary>
    /// Логика взаимодействия для WindowAddPreparate.xaml
    /// </summary>
    public partial class WindowAddPreparate : Window
    {
        int mode = 0;
        public WindowAddPreparate(Pharmacy pharm)
        {
            InitializeComponent();
            if (pharm != null)
            {
                TxbName.Text = pharm.NamePreparate;
                TxbCount.Text = pharm.CountPreparate.ToString();
                TxbPrice.Text = pharm.PricePreparate.ToString();
                TxbMonth.Text = pharm.MonthPreparate.ToString();
                mode = 1;
                BtnAddPreparate.Content = "Редактировать";
            }
        }
        public WindowAddPreparate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// добавление и редактирование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPreparate_Click(object sender, RoutedEventArgs e)
        {if (mode == 0)
            {
                Pharmacy pharmacy = new Pharmacy()
                {
                    NamePreparate = TxbName.Text,
                    CountPreparate = int.Parse(TxbCount.Text),
                    PricePreparate = double.Parse(TxbPrice.Text),
                    MonthPreparate = int.Parse(TxbMonth.Text)
                };
                ConnectHelper.pharmacies.Add(pharmacy);
            }
            else
            {
                
                for (int i = 0; i < ConnectHelper.pharmacies.Count; i++)
                {
                    if (ConnectHelper.pharmacies[i].NamePreparate == TxbName.Text)
                    {
                        ConnectHelper.pharmacies[i].CountPreparate = int.Parse(TxbCount.Text);
                        ConnectHelper.pharmacies[i].PricePreparate = double.Parse(TxbPrice.Text);
                        ConnectHelper.pharmacies[i].MonthPreparate = int.Parse(TxbMonth.Text);
                    }

                }
            }
            ConnectHelper.SaveListToFile(@"ListPreparates.txt");
            this.Close();
        }
    }
}
