using ShopsRUs.Business.Abstract;
using ShopsRUs.Model;
using ShopsRUs.Model.Abstract;
using ShopsRUs.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopsRUs.Business.Calculator
{
    /// <summary>
    /// employee=%30, affiliate=%10, over 2 years=%5 ,groceries%0 ,For every $100 over amount = %5
    /// </summary>
    public class InvoiceDiscountPercentCalculator : ICalculator
    {
        public IInvoice Invoice { get; set; }

        public float CalculateInvoiceTotalAmount(float amount)
        {
            float sonuc = 0;
            sonuc = Invoice.TotalAmount * Invoice.Discount.DiscountAmount / 100;
            Invoice.DiscountAmount = sonuc;
            Invoice.DiscountedAmount= Invoice.TotalAmount- Invoice.DiscountAmount;
            return sonuc;
        }


    }




  

}
