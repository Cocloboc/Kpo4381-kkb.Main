using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.kkb.Lib
{
    public class MockCompanyListCommand
    {
        public MockCompanyListCommand()
        {
            this._companyList = null;
        }

        private readonly string _dataFileName = "";
        private List<Company> _companyList = null;

        public List<Company> companyList
        {
            get { return _companyList; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
            throw new Exception("Неправильные входные данные");
            {              
                Company company = new Company()
                {
                    Name = "Oracle",
                    Products = 1,
                    Sales = 2488000000,
                    MarketShare = 31.1d
                };
                companyList.Add(company);
            }
            {
                Company company = new Company()
                {
                    Name = "IBM",
                    Products = 3,
                    Sales = 2392000000,
                    MarketShare = 29.9d
                };
                companyList.Add(company);
            }
            {
                Company company = new Company()
                {
                    Name = "Microsoft",
                    Products = 2,
                    Sales = 1048000000,
                    MarketShare = 13.1d
                };
                companyList.Add(company);
            }
        }
    }
}
