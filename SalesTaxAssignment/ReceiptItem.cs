using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxAssignment
{
    public class ReceiptItem
    {
        public string Name { get; }
        public decimal PriceIncludingSalesTax { get; }

        public ReceiptItem(string name, decimal priceIncludingSalesTax)
        {
            Name = name;
            PriceIncludingSalesTax = Math.Round(priceIncludingSalesTax, 2);
        }
    }
}
