using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    public class Items
    {
        public string Name {  get; private set; }
        public double Quantity {  get; private set; }
        public string Cost { get; private set; }
        public double TotalPrice { get; private set; }


        public Items(string name, string unit, double count, double price)
        {
            Name = name;
            Quantity = count;
            TotalPrice = Math.Round(count * price,2);
            Cost = $"{price} per {unit}";
        }
    }
}
