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
        public string Unit {   get; private set; }
        public decimal Quantity {  get; private set; }
        public decimal Price {  get; private set; }
        public decimal TotalPrice { get; private set; }

        public Items(string name, string unit, decimal count, decimal price)
        {
            Name = name;
            Unit = unit;
            Quantity = count;
            Price = price;
            TotalPrice = Math.Round(count * price,2);
        }
    }
}
