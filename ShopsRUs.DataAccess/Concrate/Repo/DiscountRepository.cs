using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Concrate.Repo
{
    public class DiscountRepository : EntityRepository<Discount>, IDiscountRepository
    {
        DbContext context;
        public DiscountRepository(DbContext context_) : base(context_)
        {
            this.context = context_;
        }

        public IEnumerable<Discount> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            List<Discount> discounts = new List<Discount>()
            {
               new Discount()
                {
                      DiscountID = 0, DiscountType = new DiscountType(){ DiscountID = 0, DiscountTypeName="Percent" }, DiscountAmount=15, UserCategoryID = 0//Employee
                },
                new Discount()
                {
                     DiscountID = 1, DiscountType=new DiscountType(){ DiscountID = 0, DiscountTypeName="Percent"  }, DiscountAmount=10, UserCategoryID = 1//Affiliate
                },
                new Discount()
                {
                     DiscountID = 2, DiscountType=new DiscountType(){ DiscountID = 0, DiscountTypeName="Percent"  }, DiscountAmount=5, UserCategoryID = 2//Over2YearsUser
                },
                new Discount()
                {
                     DiscountID = 3, DiscountType=null, DiscountAmount=0, UserCategoryID = 3, IsBlocked = true//Groceries
                },
                new Discount()
                {
                     DiscountID = 4, DiscountType=new DiscountType(){ DiscountID = 1, DiscountTypeName="PercentBaseAmount" }, AmountBasePercent= 100, DiscountAmount=5, UserCategoryID = 4//Default
                }
            };
            return discounts;
        }

       
    }
}
