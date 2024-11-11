using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxAssignment
{
    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public Category Category { get; }
        public bool IsImported { get; }

        public Item(string name, decimal price, Category category = Category.General)
        {
            Name = name;
            Price = price;
            Category = category;
            IsImported = false;
        }

        public Item(string name, decimal price, Category category, bool isImported)
        {
            Name = name;
            Price = price;
            Category = category;
            IsImported = isImported;
        }

        public Item(string name, decimal price, bool isImported)
        {
            Name = name;
            Price = price;
            Category = Category.General;
            IsImported = isImported;
        }

    }
}
