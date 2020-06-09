using System.Collections.Generic;

namespace Kpo4381.Lib
{
    public interface ICompanyListSaver
    {
        void Save(List<Company> CompanyList);
    }
}