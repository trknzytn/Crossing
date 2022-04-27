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
                    UserName = "tests0",
                    SurUserName = "test0",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 2,
                            UserCategoryName = "Over2YearsUser"
                        },
                        new UserCategory()
                        {
                            UserCategoryID = 1,
                            UserCategoryName = "Affiliate"
                        }
                    },
                    UserID = 0
                },
                new User()
                {
                    UserName = "tests1",
                    SurUserName = "test1",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 2,
                            UserCategoryName = "Over2YearsUser"
                        },
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
                    UserName = "tests2",
                    SurUserName = "test2",
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
                    UserName = "tests3",
                    SurUserName = "test3",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 2,
                            UserCategoryName = "Over2YearsUser"
                        },
                        new UserCategory()
                        {
                            UserCategoryID = 0,
                            UserCategoryName = "Employee"
                        }
                    },
                    UserID = 3
                },
                new User()
                {
                    UserName = "tests4",
                    SurUserName = "test4",
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
                new User()
                {
                    UserName = "tests5",
                    SurUserName = "test5",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 3,
                            UserCategoryName = "Groceries"
                        }
                    },
                    UserID = 5
                },
                new User()
                {
                    UserName = "tests6",
                    SurUserName = "test6",
                    CreateDate = DateTime.Now,
                    UserCategories = new List<UserCategory>()
                    {
                        new UserCategory()
                        {
                            UserCategoryID = 2,
                            UserCategoryName = "Over2YearsUser"
                        },
                        new UserCategory()
                        {
                            UserCategoryID = 3,
                            UserCategoryName = "Groceries"
                        }
                    },
                    UserID = 6
                }
            };

            return users;
        }

    }
}
