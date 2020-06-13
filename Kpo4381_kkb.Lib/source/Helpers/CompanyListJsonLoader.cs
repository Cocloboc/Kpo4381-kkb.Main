using Kpo4381.kkb.Lib.source.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public class CompanyListJsonLoader: ICompanyListLoader
    {
        public LoadStatus status { get; private set; } = LoadStatus.None;
        public Delegates.OnStatusChangedDelegate OnStatusChangedDelegate;
        private readonly string _dataFileName = null;
        private List<Company> _companyList = null;
        private Delegates.OnStatusChangedDelegate onStatusChanged = null;

        public CompanyListJsonLoader()
        {
            _dataFileName = AppGlobalSettings.DataJsonFileName == "" ? AppGlobalSettings.DataJsonFileName : "C:/Users/kirbe/source/repos/Kpo4381_kkb.Main/Kpo4381_kkb.Main/bin/Debug/companees.json";
            _companyList = new List<Company>();
        }

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

        public void ReadFile()
        {   if (_dataFileName == null)
            {
                status = LoadStatus.FileNameIsEmpty;
                onStatusChanged?.Invoke(status);
                throw new Exception("Имя файла не задано");
            }
            if (!File.Exists(_dataFileName))
            {
                status = LoadStatus.FileNotExists;
                onStatusChanged?.Invoke(status);
                throw new Exception("Файл не найден");
            }
            using (StreamReader file = File.OpenText(_dataFileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Company> companees = (List<Company>)serializer.Deserialize(file, typeof(List<Company>));
                _companyList = companees;            
            }
            if (_companyList == null || _companyList.Count == 0)
            {                 
                status = LoadStatus.GeneralError;
                onStatusChanged?.Invoke(status);
                throw new FileInvalidException();
            }
            else
            {
                status = LoadStatus.Success;
                onStatusChanged?.Invoke(status);
            }
        }
    }
}
