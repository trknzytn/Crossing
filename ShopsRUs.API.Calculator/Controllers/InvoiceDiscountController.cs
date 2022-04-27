using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ShopsRUs.Business.Concrate;
using ShopsRUs.DataAccess.Concrate.EF_5_0_16;
using ShopsRUs.DataAccess.Concrate.Repo;
using ShopsRUs.Model;
using System.Collections.Generic;

namespace ShopsRUs.CalculatorApi.Controllers
{
    /// <summary>
    /// employee=%30, affiliate=%10, over 2 years=%5 ,groceries%0 ,For every $100 over amount = %5
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceDiscountController : ControllerBase
    {
        IMemoryCache _memoryCache;
        public InvoiceDiscountController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        private readonly InvoiceManager invoiceManager = new InvoiceManager(new InvoiceRepository(new ShopsRUsDBContext()));

        [HttpGet("SetDataToMemory")]
        public void SetDataToMemory()
        {
            invoiceManager.SetDataToMemory(_memoryCache);
        }

        [HttpGet("GetInvoiceList")]
        public IEnumerable<Invoice> GetInvoiceList()
        {   
            var InvoiceList = invoiceManager.GetAll_MemoryCache(_memoryCache);
            return InvoiceList;
        }

        [HttpGet("SetInvoiceDiscount")]
        public Invoice SetInvoiceDiscount(int invoiceID)
        {
            var invoice = invoiceManager.SetInvoiceDiscount(invoiceID, _memoryCache);
            return invoice;
        }

        [HttpGet("GetInvoice")]
        public Invoice GetInvoice(int invoiceID)
        {
            var invoice = invoiceManager.GetInvoice(invoiceID, _memoryCache);
            return invoice;
        }





        [HttpGet("GetUserCategoryList")]
        public IEnumerable<UserCategory> GetUserCategoryList()
        {
            UserCategoryManager UserCategoryManager = new UserCategoryManager(new UserCategoryRepository(new ShopsRUsDBContext()));
            var UserCategoryList = UserCategoryManager.GetAll_MemoryCache(_memoryCache);
            return UserCategoryList;
        }

        [HttpGet("GetUserList")]
        public IEnumerable<User> GetUserList()
        {
            UserManager UserManager = new UserManager(new UserRepository(new ShopsRUsDBContext()));
            var UserList = UserManager.GetAll_MemoryCache(_memoryCache);
            return UserList;
        }


        [HttpGet("GetDiscountList")]
        public IEnumerable<Discount> GetDiscountList()
        {
            DiscountManager DiscountManager = new DiscountManager(new DiscountRepository(new ShopsRUsDBContext()));
            var DiscountList = DiscountManager.GetAll_MemoryCache(_memoryCache);
            return DiscountList;
        }

    }
}
