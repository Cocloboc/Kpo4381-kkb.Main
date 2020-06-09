using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public class CompanyTestFactory: ICompanyFactory
    {
        public ICompanyListLoader CreateLoader()
        {
            return new CompanyTestListLoader();
        }

        public ICompanyListSaver CreateSaver()
        {
            return new CompanyTestListSaver();
        }
    }
}
