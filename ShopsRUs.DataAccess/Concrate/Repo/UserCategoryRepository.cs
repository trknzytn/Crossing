using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Concrate.Repo
{
    public class UserCategoryRepository : EntityRepository<UserCategory>, IUserCategoryRepository
    {
        DbContext context;
        public UserCategoryRepository(DbContext context_) : base(context_)
        {
            this.context = context_;
        }

        public IEnumerable<UserCategory> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            var userCategories = new List<UserCategory>()
            {
                new UserCategory()
                {
                     UserCategoryID=0, UserCategoryName="Employee"
                },
                new UserCategory()
                {
                     UserCategoryID=1, UserCategoryName="Affiliate"
                },
                new UserCategory()
                {
                     UserCategoryID=2, UserCategoryName="Over2YearsUser"
                },
                new UserCategory()
                {
                     UserCategoryID=3, UserCategoryName="Groceries"
                },
                new UserCategory()
                {
                     UserCategoryID=4, UserCategoryName="Default"
                }
            };
            return userCategories;
        }

    }
}
