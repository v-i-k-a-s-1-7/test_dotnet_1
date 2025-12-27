using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    /// <summary>
    /// Provides the entry point for the Medicure Hospital billing application.
    /// </summary>
    /// <remarks>This class contains the application's main method, which presents a console-based menu for
    /// creating, viewing, and clearing patient bills. The application remains active until the user chooses to
    /// exit.</remarks>
    public class MedicMain
    {
        public static void Main(string[] args)
        {
            // Menu-driven interface
            int choice = 0;
            bool do_you_want_to_exit = true;
            PatientBill lastBill = null;

            // Loop until the user chooses to exit
            do
            {
                Console.WriteLine("================== Medicure Hospital ==================");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Bill(Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    // Create new bill
                    case 1:
                        lastBill = new PatientBill();

                        Console.WriteLine("(\"================== QuickMart Traders ==================\");");
                        Console.Write("Enter Bill Id: ");
                        lastBill.BillId = Console.ReadLine();

                        Console.Write("Enter Patient Name: ");
                        lastBill.PatientName = Console.ReadLine();

                        Console.Write("Does the patient have insurance? (yes/no): ");
                        string insuranceInput = Console.ReadLine().ToLower();
                        lastBill.HasInsurance = (insuranceInput == "yes");

                        Console.Write("Enter Consultation Fee: ");
                        lastBill.ConsultationFee = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter Lab Charges: ");
                        lastBill.LabCharges = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Medicine Charges: ");

                        lastBill.MedicineCharges = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine('\n');
                        Console.WriteLine("Bill created successfully.");
                        Console.WriteLine($"Gross Amount: {Math.Round(lastBill.GrossAmount,2)}");
                        Console.WriteLine($"Discount Amount: {Math.Round(lastBill.DiscountAmount,2)}");
                        Console.WriteLine($"Final Payable Amount: {Math.Round(lastBill.FinalPayable, 2)}");


                        break;

                    // View last bill
                    case 2:
                        if (lastBill != null)
                        {
                            Console.WriteLine("---------------Last Bill---------------");
                            Console.WriteLine($"Bill Id: {lastBill.BillId}");
                            Console.WriteLine($"Patient Name: {lastBill.PatientName}");
                            Console.WriteLine($"Has Insurance: {lastBill.HasInsurance}");
                            Console.WriteLine($"Consultation Fee: {lastBill.ConsultationFee}");
                            Console.WriteLine($"Lab Charges: {lastBill.LabCharges}");
                            Console.WriteLine($"Medicine Charges: {lastBill.MedicineCharges}");
                            Console.WriteLine($"Gross Amount: {Math.Round(lastBill.GrossAmount,2)}");
                            Console.WriteLine($"Discount Amount: {Math.Round(lastBill.DiscountAmount,2)}");
                            Console.WriteLine($"Final Payable Amount: {Math.Round(lastBill.FinalPayable,2)}");
                        }
                        else
                        {
                            Console.WriteLine("No bill available. Please create a new bill first.");
                        }
                        Console.WriteLine('\n');
                        break;

                    // Clear last bill
                    case 3:
                        lastBill = null;
                        Console.WriteLine("Last bill cleared.\n");
                        break;

                    //  Exit application
                    case 4:
                        Console.WriteLine("Thank you. Application closed normally");
                        do_you_want_to_exit = false;
                        break;

                    // Invalid choice
                    default:
                        Console.Write("Invalid choice. Please try again.\n");
                        break;
                }
            } while (do_you_want_to_exit);
        } } }

