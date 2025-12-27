using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_test1
{
    /// <summary>
    /// stores details of a sale transaction including invoice number, customer name, item name,
    /// </summary>
    public class SaleTransaction
    {
        public string InvoiceNo { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal SellingAmount { get; set; }

        // Calculates and returns the profit or loss status based on purchase and selling amounts
        public string ProfitOrLossStatus
        {
            get
            {
                decimal profitOrLoss = SellingAmount - PurchaseAmount;
                if (profitOrLoss > 0)
                {
                    return "Profit";
                }
                else if (profitOrLoss < 0)
                {
                    return "Loss";
                }
                else
                {
                    return "Break-even";
                }
            }
        }

        // Calculates and returns the profit or loss amount
        public decimal ProfitOrLossAmount
        {
            get
            {
                return SellingAmount - PurchaseAmount;
            }
        }

        // Calculates and returns the profit margin percentage
        public decimal ProfitMarginPercentage
        {
            get
            {
                if (PurchaseAmount == 0)
                {
                    return 0;
                }
                return (ProfitOrLossAmount / PurchaseAmount) * 100;
            }
        }
    }
}
