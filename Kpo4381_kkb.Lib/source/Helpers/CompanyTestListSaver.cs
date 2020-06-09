using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    class CompanyTestListSaver: ICompanyListSaver
    {
        public CompanyTestListSaver()
        {
            _dataFileName = AppGlobalSettings.SaveFileName;
        }

        private readonly string _dataFileName = null;
        public void Save(List<Company> CompanyList)
        {

        }
    }
}
