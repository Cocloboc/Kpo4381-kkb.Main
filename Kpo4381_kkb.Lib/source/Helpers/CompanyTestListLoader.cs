using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public class CompanyTestListLoader: ICompanyListLoader
    {
        public CompanyTestListLoader()
        {
            this._companyList = new List<Company>();
            {
                Company company = new Company()
                {
                    Name = "Oracle",
                    Products = 1,
                    Sales = 2488000000,
                    MarketShare = 31.1d
                };
                _companyList.Add(company);
            }
            {
                Company company = new Company()
                {
                    Name = "IBM",
                    Products = 3,
                    Sales = 2392000000,
                    MarketShare = 29.9d
                };
                _companyList.Add(company);
            }
            {
                Company company = new Company()
                {
                    Name = "Microsoft",
                    Products = 2,
                    Sales = 1048000000,
                    MarketShare = 13.1d
                };
                _companyList.Add(company);
            }
        }

        private readonly string _dataFileName = "";
        private List<Company> _companyList = null;
        private LoadStatus _status = LoadStatus.None;
        public LoadStatus status
        {
            get { return _status; }
        }

        public List<Company> CompanyList
        {
            get { return _companyList; }
        }
    }
}
