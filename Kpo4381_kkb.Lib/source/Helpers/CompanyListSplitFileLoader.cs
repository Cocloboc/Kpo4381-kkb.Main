using Kpo4381.kkb.Lib.source.Model;
using Kpo4381.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public enum LoadStatus 
    { 
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100 
    }
    public class CompanyListSplitFileLoader : ICompanyListLoader
    {
        public Delegates.OnStatusChangedDelegate OnStatusChangedDelegate;
        private readonly string _dataFileName = null;
        private List<Company> _companyList = null;
        private Delegates.OnStatusChangedDelegate onStatusChanged = null;

        public void SetOnStatusChanged(Delegates.OnStatusChangedDelegate onStatusChanged)
        {
            this.onStatusChanged = onStatusChanged;
        }
        public Delegates.OnStatusChangedDelegate OnStatusChanged
        {
            get { return onStatusChanged; }
        }
        public List<Company> CompanyList
        {
            get { return _companyList; }
        }

        public LoadStatus status { get; private set; } = LoadStatus.None;

        public CompanyListSplitFileLoader()
        {
            _companyList = new List<Company>();
            _dataFileName = AppGlobalSettings.DataFileName == "" ? AppGlobalSettings.DataFileName : "C:/Users/kirbe/source/repos/Kpo4381_kkb.Main/Kpo4381_kkb.Main/bin/Debug/Company.txt";
        }
        public void ReadFile()
        {
            if (_dataFileName == null)
            {
                status = LoadStatus.FileNameIsEmpty;
                onStatusChanged?.Invoke(status);
                throw new Exception("Отсутсвует имя файла");
            }
            if (!File.Exists(_dataFileName))
            {
                status = LoadStatus.FileNotExists;
                onStatusChanged?.Invoke(status);
                throw new Exception("Файл не существует");
            }
            string[] companees = File.ReadAllLines(_dataFileName);
            foreach (string row in companees)
            {
                try
                {
                    _companyList.Add(tryConvertString(row));
                }
                catch (Exception ex)
                {
                    LogUtility.ErrorLog(ex.Message);
                }
            }
            if (_companyList.Count > 0)
            {
                status = LoadStatus.Success;
                onStatusChanged?.Invoke(status);
            }
            else
            {
                status = LoadStatus.GeneralError;
                onStatusChanged?.Invoke(status);
                throw new FileInvalidException();
            }
        }

        public Company tryConvertString(string row)
        {
            string[] companyParams = row.Split('|');
            if (companyParams.Length < 4)
                throw new Exception("Недостаточно параметров");
            string Name = companyParams[0];
            int Products;
            uint Sales;
            double MarketShare;


            if (Name == null ||
                !int.TryParse(companyParams[1], out Products) ||
                !uint.TryParse(companyParams[2], out Sales) ||
                !double.TryParse(companyParams[3], out MarketShare))
            {
                throw new Exception("Параметры невалидны");
            }
            else
            {
                return new Company() { Name = Name, Products = Products, Sales = Sales, MarketShare = MarketShare };
            }
        }

    }
}
