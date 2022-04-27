using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Dto
{
    /// <summary>
    /// employee=%30, affiliate=%10, over 2 years=%5 ,groceries%0 ,For every $100 over amount = %5
    /// </summary>
    public partial class DiscountDto:IDiscount
    {
        public int DiscountID { get; set; }
        public int UserCategoryID { get; set; }
        public float DiscountAmount { get; set; }
        public float AmountBasePercent { get; set; }
        public IDiscountType DiscountType { get; set; }//0-Percent 1-PercentByAmount
        public bool IsBlocked { get; set; }

    }
}
