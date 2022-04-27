using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Abstract
{
    public interface ICalculator
    {
        public float CalculateInvoiceTotalAmount(float amount);
    }
}
