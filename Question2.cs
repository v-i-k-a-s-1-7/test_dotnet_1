using System;

namespace Question2
{
    /// <summary>
    /// Represents a patient's bill, including consultation, laboratory, and medicine charges, as well as insurance
    /// discounts and the final payable amount.
    /// </summary>
    /// <remarks>Use this class to model and calculate the billing details for a patient visit, including
    /// automatic computation of gross amount, applicable insurance discount, and the final amount due. The discount is
    /// applied only if the patient has insurance.</remarks>
    public class PatientBill
    {
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public bool HasInsurance { get; set; }
        public decimal ConsultationFee { get; set; }
        public decimal LabCharges { get; set; }
        public decimal MedicineCharges { get; set; }

        /// <summary>
        /// Gets the total gross amount for the consultation, including consultation fee, laboratory charges, and
        /// medicine charges.
        /// </summary>
        public decimal GrossAmount
        {
            get
            {
                return ConsultationFee + LabCharges + MedicineCharges;
            }
        }

        /// <summary>
        /// gets the discount amount based on whether the patient has insurance.
        /// </summary>
        public decimal DiscountAmount
        {
            get
            {
                if (HasInsurance)
                {
                    return GrossAmount * 0.10m; // 10% discount for insured patients
                }
                return 0;
            }
        }

        /// <summary>
        /// Gets the final amount payable after applying discounts.
        /// </summary>
        public decimal FinalPayable
        {
            get
            {
                return GrossAmount - DiscountAmount;
            }
        }
    }
}
