using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Dto
{
    public class DiscountTypeDto : IDiscountType
    {
        public int DiscountID { get; set; }
        public string DiscountTypeName { get; set; }
    }
}
