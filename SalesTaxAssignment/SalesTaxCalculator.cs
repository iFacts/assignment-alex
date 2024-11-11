using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxAssignment
{
    public static class SalesTaxCalculator
    {
        private const decimal SalesTaxRate = 0.15m;
        private const decimal ImportTaxRate = 0.10m;

        public static ReceiptDetails Process(params Item[] items)
        {
            var receiptItems = new List<ReceiptItem>();
            decimal totalSalesTax = 0m;
            decimal totalCost = 0m;

            foreach (var item in items)
            {
                decimal salesTax = CalculateSalesTax(item);
                decimal importTax = CalculateImportTax(item);
                decimal totalTax = salesTax + importTax;

                decimal priceWithTax = item.Price + totalTax;
                receiptItems.Add(new ReceiptItem(item.Name, priceWithTax));

                totalSalesTax += totalTax;
                totalCost += priceWithTax;
            }

            return new ReceiptDetails(receiptItems, totalSalesTax, totalCost);
        }

        private static decimal CalculateSalesTax(Item item)
        {
            if (item.Category == Category.Magazines || item.Category == Category.Food || item.Category == Category.Electronics)
                return 0m;

            return item.Price * SalesTaxRate;
        }

        private static decimal CalculateImportTax(Item item)
        {
            return item.IsImported ? item.Price * ImportTaxRate : 0m;
        }
    }
}
