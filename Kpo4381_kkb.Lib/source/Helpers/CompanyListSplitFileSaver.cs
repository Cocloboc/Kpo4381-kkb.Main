using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    internal class CompanyListSplitFileSaver : ICompanyListSaver
    {
        public CompanyListSplitFileSaver()
        {
            _dataFileName = AppGlobalSettings.SaveFileName;
        }

        private readonly string _dataFileName = null;

        public void Save(List<Company> CompanyList)
        {
            List<string> companees = new List<string>();
            foreach (Company company in CompanyList)
            {
                companees.Add(company.Name + "|" + company.Products + "|" + company.Sales + "|" + company.MarketShare);
            }
            File.WriteAllLines(_dataFileName, companees);
        }

    }
}
