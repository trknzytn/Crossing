using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Business.Abstract;
using ShopsRUs.Business.Calculator;
using ShopsRUs.DataAccess.Concrate.Repo;
using ShopsRUs.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopsRUs.Business.Concrate
{
    public class InvoiceManager : IInvoiceManager
    {
        InvoiceRepository discountRepository;

        public InvoiceManager(InvoiceRepository discountRepository_)
        {
            discountRepository = discountRepository_;       
        }
        public Task AddAsync(Invoice entity)
        {
            return discountRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Invoice> entities)
        {
            return discountRepository.AddRangeAsync(entities);
        }

        public IEnumerable<Invoice> Find(Expression<Func<Invoice, bool>> predicate)
        {
            return discountRepository.Find(predicate);
        }

        public IEnumerable<Invoice> GetAll()
        {
            return discountRepository.GetAll();
        }

        public Task<IEnumerable<Invoice>> GetAllAsync()
        {
            return discountRepository.GetAllAsync();
        }

        public Invoice GetById(int id)
        {
            return discountRepository.GetById(id);
        }

        public ValueTask<Invoice> GetByIdAsync(int id)
        {
            return discountRepository.GetByIdAsync(id);
        }

        public void Remove(Invoice entity)
        {
            discountRepository.GetAll();
        }

        public void RemoveRange(IEnumerable<Invoice> entities)
        {
            discountRepository.GetAll();
        }

        public Task<Invoice> SingleOrDefaultAsync(Expression<Func<Invoice, bool>> predicate)
        {
            return discountRepository.SingleOrDefaultAsync(predicate);
        }

        public void Updata(Invoice entitiy)
        {
            discountRepository.Updata(entitiy);
        }





        public IEnumerable<Invoice> GetAll_MemoryCache(IMemoryCache memoryCache)
        {
            return discountRepository.GetAll_MemoryCache(memoryCache);
        }

        public Discount GetInvoiceDiscount(int userID, IMemoryCache memoryCache)
        {
            return discountRepository.GetUserDiscount(userID, memoryCache);
        }

        public void SetDataToMemory(IMemoryCache memoryCache)
        {
            discountRepository.SetDataToMemory(memoryCache);
        }

        public Invoice SetInvoiceDiscount(int invoiceID, IMemoryCache memoryCache)
        {
            Invoice invoice = discountRepository.GetInvoice(invoiceID, memoryCache);
            InvoiceCalculing invoiceCalculing = new InvoiceCalculing(invoice);

            if (invoice.Discount.DiscountAmount > 0)
            {
                invoiceCalculing.Calculator.CalculateInvoiceTotalAmount(invoice.Discount.AmountBasePercent);
            }

            return invoice;
        }

        public Invoice GetInvoice(int invoiceID, IMemoryCache memoryCache)
        {
            Invoice invoice = discountRepository.GetInvoice(invoiceID, memoryCache);
            return invoice;
        }
    }
}
