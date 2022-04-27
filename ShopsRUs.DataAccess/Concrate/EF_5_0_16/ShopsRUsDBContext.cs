using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Concrate.EF_5_0_16
{
    public class ShopsRUsDBContext:DbContext
    {
        public ShopsRUsDBContext()
        {

        }
        protected ShopsRUsDBContext(DbContextOptions options) : base(options) { }

        public ShopsRUsDBContext(DbContextOptions<ShopsRUsDBContext> options) : this((DbContextOptions)options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
