using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopsRUs.Business.Concrate;
using ShopsRUs.CalculatorApi.Controllers;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.DataAccess.Concrate.Repo;
using ShopsRUs.Model;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs_.MSTest
{
    [TestClass]
    public class InvoiceManagerTest
    {
        MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public InvoiceManagerTest()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            cnt.SetDataToMemory();
        }


        [TestMethod]
        public void GetInvoiceList_Test()
        {
            var mock = new Mock<IInvoiceRepository>();
            mock.Setup(p => p.GetAll_MemoryCache(memoryCache));
        }

        [TestMethod]
        public void GetInvoiceList_Test2()
        {
            var mock = new Mock<IInvoiceRepository>();
            mock.Setup(p => p.GetAll_MemoryCache(memoryCache));
        }


    }
}
