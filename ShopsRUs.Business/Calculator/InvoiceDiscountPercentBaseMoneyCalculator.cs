using ShopsRUs.Business.Abstract;
using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Calculator
{
    public class InvoiceDiscountPercentBaseMoneyCalculator : ICalculator
    {
        public IInvoice Invoice { get; set; }
        public float CalculateInvoiceTotalAmount(float amount)//varsayılan 100 lük ama değişik olabilir-debug test için formül kısaltılmadı
        {
            float kalan_mod = Invoice.TotalAmount % (float)amount;
            float indirim_uygulanacak_tutar = Invoice.TotalAmount - kalan_mod;
            float indirim_tutar = indirim_uygulanacak_tutar * Invoice.Discount.DiscountAmount / 100;
            float indirimli_tutar = indirim_uygulanacak_tutar - indirim_tutar;
            float son_tutar = indirimli_tutar + kalan_mod;

            Invoice.DiscountAmount = indirim_tutar;
            Invoice.DiscountedAmount = son_tutar;

            return son_tutar;
        }
    }
}
