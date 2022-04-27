using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
        IEnumerable<User> GetAll_MemoryCache(IMemoryCache memoryCache);
    }
}
