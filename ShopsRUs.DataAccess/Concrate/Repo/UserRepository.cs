using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Concrate.Repo
{
    public class UserRepository : EntityRepository<User>, IUserRepository
    {
        DbContext context;
        public UserRepository(DbContext context_) : base(context_)
        {
            this.context = context_;
        }

        public IEnumerable<User> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName = "tests",
                    SurUserName = "test",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 0,
                            UserCategoryName = "Over2YearsUser"
                        },
                        new UserCategory()
                        {
                            UserCategoryID = 2,
                            UserCategoryName = "Affiliate"
                        }
                    },
                    UserID = 0
                },
                new User()
                {
                    UserName = "tests",
                    SurUserName = "test",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 4,
                            UserCategoryName = "Default"
                        }
                    },
                    UserID = 1
                },
                new User()
                {
                    UserName = "tests",
                    SurUserName = "test",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                         new UserCategory()
                        {
                            UserCategoryID = 4,
                            UserCategoryName = "Default"
                        }
                    },
                    UserID = 2
                },
                new User()
                {
                    UserName = "tests",
                    SurUserName = "test",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 4,
                            UserCategoryName = "Default"
                        }
                    },
                    UserID = 3
                },
                new User()
                {
                    UserName = "tests",
                    SurUserName = "test",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 0,
                            UserCategoryName = "Employee"
                        }
                    },
                    UserID = 4
                },
            };

            return users;
        }

    }
}
