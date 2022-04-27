using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Abstract
{
    public interface IUserManager : IManager<User>
    {
        public IEnumerable<User> GetAll_MemoryCache(IMemoryCache memoryCache);

    }
}
