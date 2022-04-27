using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.DataAccess.Abstract
{
    public interface IInvoiceRepository : IEntityRepository<Invoice>
    {
        public IEnumerable<Invoice> GetAll_MemoryCache(IMemoryCache memoryCache);
        public Discount GetUserDiscount(int userID, IMemoryCache memoryCache);
        public Invoice GetInvoice(int invoiceID, IMemoryCache memoryCache);

    }
}
