using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Business.Abstract;
using ShopsRUs.DataAccess.Concrate.Repo;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Business.Concrate
{
    public class DiscountManager : IDiscountManager
    {
        DiscountRepository discountRepository;
        public DiscountManager(DiscountRepository discountRepository_)
        {
            discountRepository = discountRepository_;
        }
        public Task AddAsync(Discount entity)
        {
            return discountRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Discount> entities)
        {
            return discountRepository.AddRangeAsync(entities);
        }

        public IEnumerable<Discount> Find(Expression<Func<Discount, bool>> predicate)
        {
            return discountRepository.Find(predicate);
        }

        public IEnumerable<Discount> GetAll()
        {
            return discountRepository.GetAll();
        }

        public Task<IEnumerable<Discount>> GetAllAsync()
        {
            return discountRepository.GetAllAsync();
        }

        public Discount GetById(int id)
        {
            return discountRepository.GetById(id);
        }

        public ValueTask<Discount> GetByIdAsync(int id)
        {
            return discountRepository.GetByIdAsync(id);
        }

        public void Remove(Discount entity)
        {
            discountRepository.GetAll();
        }

        public void RemoveRange(IEnumerable<Discount> entities)
        {
            discountRepository.GetAll();
        }

        public Task<Discount> SingleOrDefaultAsync(Expression<Func<Discount, bool>> predicate)
        {
            return discountRepository.SingleOrDefaultAsync(predicate);
        }

        public void Updata(Discount entitiy)
        {
            discountRepository.Updata(entitiy);
        }


        public IEnumerable<Discount> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            return discountRepository.GetAll_MemoryCache(memoryCache);
        }


    }
}
