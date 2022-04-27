using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Abstract
{
    public interface IUserCategoryRepository : IEntityRepository<UserCategory>
    {
        IEnumerable<UserCategory> GetAll_MemoryCache(IMemoryCache memoryCache);
    }
}
