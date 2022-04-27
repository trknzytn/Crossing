using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Abstract
{
    public interface IDiscount
    {
        public int DiscountID { get; set; }
        public int UserCategoryID { get; set; }
        public IDiscountType DiscountType { get; set; }//0-Percent 1-PercentByAmount
        public float DiscountAmount { get; set; }
        public float AmountBasePercent { get; set; }
        public bool IsBlocked { get; set; }
    }
}
