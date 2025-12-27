
namespace dotnet_test1
{
    public class Program
    {
        /// <summary>
        /// Serves as the entry point for the QuickMart Traders console application.
        /// </summary>
        /// <remarks>Displays a menu-driven interface for creating, viewing, and analyzing sales
        /// transactions. The application continues to prompt the user until the exit option is selected.</remarks>
        /// <param name="args">An array of command-line arguments supplied to the application. This parameter is not used.</param>
        static void Main(string[] args)
        {
            // Menu-driven interface
            int choice = 0;
            bool do_you_want_to_exit = true;
            SaleTransaction lastTransaction = null;

            // Loop until the user chooses to exit
            do
            {

                // Display menu options
                Console.WriteLine("================== QuickMart Traders ==================");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Transaction(Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                // Read user choice
                choice = int.Parse(Console.ReadLine());

                // Handle user choice
                switch (choice)
                {
                    // Create new transaction
                    case 1:
                        lastTransaction = new SaleTransaction();

                        Console.Write("Enter Invoice No: ");
                        lastTransaction.InvoiceNo = Console.ReadLine();

                        Console.Write("Enter Customer Name: ");
                        lastTransaction.CustomerName = Console.ReadLine();

                        Console.Write("Enter Item Name: ");
                        lastTransaction.ItemName = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        lastTransaction.Quantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter Purchase Amount: ");
                        lastTransaction.PurchaseAmount = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter Selling Amount: ");
                        lastTransaction.SellingAmount = decimal.Parse(Console.ReadLine());

                        Console.WriteLine('\n');
                        Console.WriteLine("Transaction created successfully.");
                        Console.WriteLine("Status: " + lastTransaction.ProfitOrLossStatus);
                        Console.WriteLine($"Profit/Loss Amount: {Math.Round(lastTransaction.ProfitOrLossAmount, 2)}");
                        Console.WriteLine($"Profit Margin (%): {Math.Round(lastTransaction.ProfitMarginPercentage,2)}" );


                        break;

                    // View last transaction
                    case 2:
                        if (lastTransaction != null)
                        {
                            Console.WriteLine($"Invoice No: {lastTransaction.InvoiceNo}");
                            Console.WriteLine($"Customer Name: {lastTransaction.CustomerName}");
                            Console.WriteLine($"Item Name: {lastTransaction.ItemName}");
                            Console.WriteLine($"Quantity: {lastTransaction.Quantity}");
                            Console.WriteLine($"Purchase Amount: {Math.Round(lastTransaction.PurchaseAmount,2)}");
                            Console.WriteLine($"Selling Amount: {Math.Round(lastTransaction.SellingAmount,2)}");
                            Console.WriteLine($"Profit/Loss Status: {lastTransaction.ProfitOrLossStatus}");
                            Console.WriteLine($"Profit/Loss Amount: {Math.Round(lastTransaction.ProfitOrLossAmount, 2)}");
                            Console.WriteLine($"Profit Margin Percentage: {Math.Round(lastTransaction.ProfitMarginPercentage, 2)}");
                        }
                        else
                        {
                            Console.WriteLine("No transaction available.");
                        }
                        break;

                    // Calculate profit/loss
                    case 3:
                        if (lastTransaction != null)
                        {
                            Console.WriteLine($"Recomputed Profit/Loss Status: {lastTransaction.ProfitOrLossStatus}");
                            Console.WriteLine($"Recomputed Profit/Loss Amount: {Math.Round(lastTransaction.ProfitOrLossAmount, 2)}");
                            Console.WriteLine($"Recomputed Profit Margin Percentage: {Math.Round(lastTransaction.ProfitMarginPercentage, 2)}");
                        }
                        else
                        {
                            Console.WriteLine("No transaction available to compute.");
                        }
                        break;

                    // Exit application
                    case 4:
                        Console.WriteLine("Thank you. Application closed normally");
                        do_you_want_to_exit = false;
                        break;

                    // Handle invalid choice
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            } while (do_you_want_to_exit);
        }
    }
}