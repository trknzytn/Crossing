using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopsRUs.CalculatorApi.Controllers;
using ShopsRUs.DataAccess.Abstract;
using ShopsRUs.DataAccess.Concrate.Repo;
using ShopsRUs.Model;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs_.MSTest
{
    [TestClass]
    public class ControllerTest
    {
        MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());
        public ControllerTest()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            cnt.SetDataToMemory();
        }




        [TestMethod]
        public void GetUserList_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.GetUserList();
            Assert.AreNotEqual(new List<User>(), result);
        }

        [TestMethod]
        public void GetUserCategoryList_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.GetUserCategoryList();
            Assert.AreNotEqual(new List<UserCategory>(), result);
        }

        [TestMethod]
        public void GetDiscountList_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.GetDiscountList();
            Assert.AreNotEqual(new List<Discount>(), result);
        }





        [TestMethod]
        public void GetInvoiceList_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.GetInvoiceList();
            Assert.AreNotEqual(new List<Invoice>(), result);
        }

        [TestMethod]
        public void GetInvoice_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.GetInvoice(5);
            Assert.AreNotEqual(new List<Invoice>(), result);
        }



        [TestMethod]
        public void SetInvoiceDiscount_Test()
        {
            InvoiceDiscountController cnt = new InvoiceDiscountController(memoryCache);
            var result = cnt.SetInvoiceDiscount(5);
            Assert.AreNotEqual(new List<Invoice>(), result);
        }




    }
}
