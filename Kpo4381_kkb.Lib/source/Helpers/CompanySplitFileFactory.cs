using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public class CompanySplitFileFactory: ICompanyFactory
    {
        public ICompanyListLoader CreateLoader()
        {
            return new CompanyListSplitFileLoader();
        }

        public ICompanyListSaver CreateSaver()
        {
            return new CompanyListSplitFileSaver();
        }
    }
}
