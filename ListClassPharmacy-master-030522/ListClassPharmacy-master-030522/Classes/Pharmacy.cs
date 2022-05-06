using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass.Classes
{/// <summary>
/// класс, описывающий предметную область Аптека 
/// </summary>
   public class Pharmacy
    {//поля
        string namePreparate;
        int countPreparate;
        double pricePreparate;
        int monthPreparate;

        //свойства
        public string NamePreparate 
        { 
            get { return namePreparate; }
            set { namePreparate = value; } 
        }
        public int CountPreparate
        {
            get { return countPreparate; }
            set { countPreparate = value; }
        }
        public double PricePreparate
        {
            get { return pricePreparate; }
            set { pricePreparate = value; }
        }
        public int MonthPreparate
        {
            get { return monthPreparate; }
            set { monthPreparate = value; }
        }
        //конструкторы
        public Pharmacy()
        {
            namePreparate = "";
            countPreparate = 0;
            pricePreparate = 0.0;
            monthPreparate = 0;
        }
        public Pharmacy(string name, int count, double price, int month)
        {
            namePreparate = name;
            countPreparate = count;
            pricePreparate = price;
            monthPreparate = month;
        }

    }
}
