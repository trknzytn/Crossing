using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model
{
    public class Invoice : IInvoice
    {
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }


        public int DiscountID { get; set; }
        public int UserID { get; set; }
        public IUser User { get; set; }
        public IDiscount Discount { get; set; }


        public float TotalAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float DiscountedAmount { get; set; }
    }
}
