using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyTests
{
    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void TestCatsFacts()
        {
            string fact = CompanyUtils.GetCompleteInfo();
            Assert.IsNotNull(fact);
        }
        [TestMethod]
        public void TestProfitFromChars()
        {
            Company TestCompany = new Company { Name = "IBM", Products = 1, MarketShare = 10, Sales = 3000 };
            double profit = CompanyUtils.GetProfitFromEveryChar(TestCompany);
            Assert.AreEqual(1000d, profit);
        }


        [TestMethod]
        public void TestWhoAmI()
        {
            Company TestCompany = new Company { Name = "IBM", Products = 1, MarketShare = 10, Sales = 3000 };
            Company returnedCompany = CompanyUtils.WhoAmI(TestCompany);
            Assert.AreEqual(TestCompany.Name, returnedCompany.Name);
        }

    }
}
