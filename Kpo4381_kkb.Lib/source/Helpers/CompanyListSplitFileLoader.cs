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
        private readonly string _dataFileName = null;
        private List<Company> _companyList = null;
        public List<Company> CompanyList
        {
            get { return _companyList; }
        }

        private LoadStatus _status = LoadStatus.None;
        public LoadStatus status
        {
            get { return _status; }
        }

        public CompanyListSplitFileLoader()
        {
            _companyList = new List<Company>();
            _dataFileName = AppGlobalSettings.DataFileName;
            ReadFile();
        }
        private void ReadFile()
        {
            if (_dataFileName == null)
            {
                _status = LoadStatus.FileNameIsEmpty;
                throw new Exception("Отсутсвует имя файла");
            }
            if (!File.Exists(_dataFileName))
            {
                _status = LoadStatus.FileNotExists;
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
                _status = LoadStatus.Success;
            else
            {
                _status = LoadStatus.GeneralError;
                throw new Exception("Файл содержит некорректные данные");
            }
        }

        private Company tryConvertString(string row)
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
