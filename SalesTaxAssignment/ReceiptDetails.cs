using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxAssignment
{
    public class ReceiptDetails
    {
        public List<ReceiptItem> ReceiptItems { get; }
        public decimal SalesTax { get; }
        public decimal Total { get; }

        public ReceiptDetails(List<ReceiptItem> receiptItems, decimal salesTax, decimal total)
        {
            ReceiptItems = receiptItems;
            SalesTax = Math.Round(salesTax, 2);
            Total = Math.Round(total, 2);
        }
    }
}
