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
    public class UserCategoryManager : IUserCategoryManager
    {
        UserCategoryRepository userCategoryRepository;
        public UserCategoryManager(UserCategoryRepository userCategoryRepository_)
        {
            userCategoryRepository = userCategoryRepository_;
        }

        public Task AddAsync(UserCategory entity)
        {
            return userCategoryRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<UserCategory> entities)
        {
            return userCategoryRepository.AddRangeAsync(entities);
        }

        public IEnumerable<UserCategory> Find(Expression<Func<UserCategory, bool>> predicate)
        {
            return userCategoryRepository.Find(predicate);
        }

        public IEnumerable<UserCategory> GetAll()
        {
            return userCategoryRepository.GetAll();
        }

        public Task<IEnumerable<UserCategory>> GetAllAsync()
        {
            return userCategoryRepository.GetAllAsync();
        }

        public UserCategory GetById(int id)
        {
            return userCategoryRepository.GetById(id);
        }

        public ValueTask<UserCategory> GetByIdAsync(int id)
        {
            return userCategoryRepository.GetByIdAsync(id);
        }

        public void Remove(UserCategory entity)
        {
            userCategoryRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<UserCategory> entities)
        {
            userCategoryRepository.RemoveRange(entities);
        }

        public Task<UserCategory> SingleOrDefaultAsync(Expression<Func<UserCategory, bool>> predicate)
        {
            return userCategoryRepository.SingleOrDefaultAsync(predicate);
        }

        public void Updata(UserCategory entitiy)
        {
            userCategoryRepository.Updata(entitiy);
        }

        public IEnumerable<UserCategory> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            return userCategoryRepository.GetAll_MemoryCache(memoryCache);
        }
    }
}
