using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Abstract
{
    public interface IInvoiceManager:IManager<Invoice>
    {
        public IEnumerable<Invoice> GetAll_MemoryCache(IMemoryCache memoryCache);
        public Discount GetInvoiceDiscount(int userID, IMemoryCache memoryCache);

        public Invoice SetInvoiceDiscount(int invoiceID, IMemoryCache memoryCache);
    }
}
