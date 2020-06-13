using System;
using Kpo4381.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyTests
{
    [TestClass]
    public class ReadTests
    {
        [TestMethod]
        public void GetCompaneesFromJsonTest()
        {
            ICompanyListLoader loader = new CompanyListJsonLoader();
            loader.ReadFile();
            Company TestCompany = new Company() { Name = "IBM", Products = 1, MarketShare = 10, Sales = 10000 };
            Assert.AreEqual(loader.CompanyList[0].Name, TestCompany.Name);
            Assert.AreEqual(loader.CompanyList[0].Sales, TestCompany.Sales);
            Assert.AreEqual(loader.CompanyList[0].Products, TestCompany.Products);
            Assert.AreEqual(loader.CompanyList[0].MarketShare, TestCompany.MarketShare);
        }
        [TestMethod]
        public void GetCompaneesFromSplitFileTest()
        {
            ICompanyListLoader loader = new CompanyListSplitFileLoader();
            loader.ReadFile();
            Company TestCompany = new Company() { Name = "IBM", Products = 1, MarketShare = 10, Sales = 10000 };
            Assert.AreEqual(loader.CompanyList[0].Name, TestCompany.Name);
            Assert.AreEqual(loader.CompanyList[0].Sales, TestCompany.Sales);
            Assert.AreEqual(loader.CompanyList[0].Products, TestCompany.Products);
            Assert.AreEqual(loader.CompanyList[0].MarketShare, TestCompany.MarketShare);
        }


    }
}
