using ShopsRUs.Business.Abstract;
using ShopsRUs.Model.Abstract;

namespace ShopsRUs.Business.Calculator
{
    public class InvoiceCalculing
    {
        public IInvoice Invoice;
        public ICalculator Calculator;
        public InvoiceCalculing(IInvoice Invoice_)
        {
            Invoice = Invoice_;
            if (Invoice.Discount.DiscountType != null)
            {
                switch (Invoice.Discount.DiscountType.DiscountID)
                {
                    case 0:
                        Calculator = new InvoiceDiscountPercentCalculator() { Invoice = Invoice };
                        break;
                    case 1:
                        Calculator = new InvoiceDiscountPercentBaseMoneyCalculator() { Invoice = Invoice };
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Invoice.DiscountedAmount = Invoice.TotalAmount;
            }

        }



    }
}
