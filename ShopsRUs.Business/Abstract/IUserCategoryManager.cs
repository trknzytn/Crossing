using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Abstract
{
    interface IUserCategoryManager : IManager<UserCategory>
    {
        public IEnumerable<UserCategory> GetAll_MemoryCache(IMemoryCache memoryCache);

    }
}
