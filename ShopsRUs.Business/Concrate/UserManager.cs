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
    public class UserManager : IUserManager
    {
        UserRepository userRepository;
        public UserManager(UserRepository userRepository_)
        {
            userRepository= userRepository_;
        }
        public Task AddAsync(User entity)
        {
            return userRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<User> entities)
        {
            return userRepository.AddRangeAsync(entities);
        }

        public IEnumerable<User> Find(Expression<Func<User, bool>> predicate)
        {
            return userRepository.Find(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return userRepository.GetAllAsync();
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public ValueTask<User> GetByIdAsync(int id)
        {
            return userRepository.GetByIdAsync(id);
        }

        public void Remove(User entity)
        {
             userRepository.GetAll();
        }

        public void RemoveRange(IEnumerable<User> entities)
        {
             userRepository.GetAll();
        }

        public Task<User> SingleOrDefaultAsync(Expression<Func<User, bool>> predicate)
        {
            return userRepository.SingleOrDefaultAsync(predicate);
        }

        public void Updata(User entitiy)
        {
             userRepository.Updata(entitiy);
        }



        public IEnumerable<User> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            return userRepository.GetAll_MemoryCache(memoryCache);
        }


    }
}
