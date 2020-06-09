using Kpo4381.Lib;
using System.Collections.Generic;

namespace Kpo4381.Lib
{
    public interface ICompanyListLoader
    {
        List<Company> CompanyList { get; }
        LoadStatus status { get; }
    }
}