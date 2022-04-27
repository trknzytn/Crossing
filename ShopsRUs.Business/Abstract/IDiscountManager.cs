using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Abstract
{
    public interface IDiscountManager:IManager<Discount>
    {
        public IEnumerable<Discount> GetAll_MemoryCache(IMemoryCache memoryCache);
    }
}
