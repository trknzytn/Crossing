using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Abstract
{
    /// <summary>
    /// 0-Percent 1-PercentByAmount
    /// </summary>
    public interface IDiscountType
    {
        public int DiscountID { get; set; }
        public string DiscountTypeName { get; set; }
    }
}
