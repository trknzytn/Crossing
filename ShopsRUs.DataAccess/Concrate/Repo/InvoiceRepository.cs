using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs.DataAccess.Concrate.Repo
{
    public class InvoiceRepository : EntityRepository<Invoice>, IInvoiceRepository
    {
        DbContext context;
        public InvoiceRepository(DbContext context_) : base(context_)
        {
            this.context = context_;
        }

        public void SetDataToMemory(IMemoryCache memoryCache)
        {
            UserCategoryRepository userCategoryRepository = new UserCategoryRepository(context);
            var userCategories = userCategoryRepository.GetAll_MemoryCache(memoryCache);

            UserRepository userRepository = new UserRepository(context);
            var users = userRepository.GetAll_MemoryCache(memoryCache);

            DiscountRepository discountRepository = new DiscountRepository(context);
            var discounts = discountRepository.GetAll_MemoryCache(memoryCache);



            const string userCategoriesKey = "userCategoriesKey";
            memoryCache.Set(userCategoriesKey, userCategories, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(3600),
                Priority = CacheItemPriority.Normal
            });

            const string usersKey = "usersKey";
            memoryCache.Set(usersKey, users, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(3600),
                Priority = CacheItemPriority.Normal
            });

            const string discountsKey = "discountsKey";
            memoryCache.Set(discountsKey, discounts, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(3600),
                Priority = CacheItemPriority.Normal
            });



            List<Invoice> InvoiceList = new List<Invoice>()
            {
                new Invoice()
                {
                    InvoiceID = 0,
                    InvoiceDate = DateTime.Now,
                    UserID = 0,
                    User = new User()
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
                    TotalAmount = 150,
                    Discount = GetUserDiscount(0,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                },
                new Invoice()
                {
                    InvoiceID = 1,
                    InvoiceDate = DateTime.Now,
                    UserID = 1,
                    User = new User()
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
                    TotalAmount = 150,
                    Discount = GetUserDiscount(1,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                },
                new Invoice()
                {
                    InvoiceID = 2,
                    InvoiceDate = DateTime.Now,
                    UserID = 4,
                    User = new User()
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
                    TotalAmount = 150,
                    Discount = GetUserDiscount(4,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                },
                new Invoice()
                {
                    InvoiceID = 3,
                    InvoiceDate = DateTime.Now,
                    UserID = 2,
                    User = new User()
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
                    TotalAmount = 150,
                    Discount = GetUserDiscount(2,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                },
                new Invoice()
                {
                    InvoiceID = 4,
                    InvoiceDate = DateTime.Now,
                    UserID = 5,
                    User = new User()
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
                    TotalAmount = 150,
                    Discount = GetUserDiscount(5,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                },
                new Invoice()
                {
                    InvoiceID = 5,
                    InvoiceDate = DateTime.Now,
                    UserID = 6,
                    User = new User()
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
                    },
                    TotalAmount = 150,
                    Discount = GetUserDiscount(6,memoryCache),
                    DiscountAmount = 0,
                    DiscountedAmount = 0
                }
            };

            const string InvoiceListKey = "InvoiceListKey";
            memoryCache.Set(InvoiceListKey, InvoiceList, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(3600),
                Priority = CacheItemPriority.Normal
            });

        }

        public IEnumerable<Invoice> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            List<Invoice> Invoices = new List<Invoice>();
            memoryCache.TryGetValue("InvoiceListKey", out Invoices);
            return Invoices;
        }

        public Discount GetUserDiscount(int userID, IMemoryCache memoryCache)
        {
            var users = new List<User>();
            memoryCache.TryGetValue("usersKey", out users);

            var discounts = new List<Discount>();
            memoryCache.TryGetValue("discountsKey", out discounts);

            User user = users.Where(x => x.UserID == userID).FirstOrDefault();
            var userCategoriIdList = user.UserCategories.Select(x=>x.UserCategoryID).ToList();
            var userDiscounts = discounts.Where(t => userCategoriIdList.Contains(t.UserCategoryID)).ToList();
            var blocedUserDiscount = userDiscounts.Where(x=>x.IsBlocked == true).ToList();


            Discount discount = new Discount();
            if (userDiscounts.Count>0 && blocedUserDiscount.Count==0)
            {
                float discountAmount = userDiscounts.Max(z => z.DiscountAmount);
                var discount_ = discounts.Where(x => userCategoriIdList.Contains(x.UserCategoryID) && x.DiscountAmount == discountAmount);
                discount = discount_.FirstOrDefault();
            }
            else
            {
                discount = blocedUserDiscount.FirstOrDefault();
            }
            return discount;
        }

        public Invoice GetInvoice(int invoiceID, IMemoryCache memoryCache)
        {
            List<Invoice> InvoiceList = new List<Invoice>();
            memoryCache.TryGetValue("InvoiceListKey", out InvoiceList);
            Invoice invoice = InvoiceList.Where(x => x.InvoiceID == invoiceID).FirstOrDefault();
            return invoice;
        }



    }
}
