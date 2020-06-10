using System.Collections.Generic;

namespace Kpo4381.Lib
{
    public interface ICompanyListLoader
    {
        List<Company> CompanyList { get; }
        Delegates.OnStatusChangedDelegate OnStatusChanged { get; }
        void ReadFile();
        LoadStatus status { get; }

        void SetOnStatusChanged(Delegates.OnStatusChangedDelegate onStatusChanged);
    }
}