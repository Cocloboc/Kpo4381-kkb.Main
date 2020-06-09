using Kpo4381.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.Lib
{
    public static class AppGlobalSettings
    {
        private  static string _logPath = null;
        private static string _dataFileName = null;
        private static string _saveFileName = null;
        private static string _companyFactory = null;

        public static string LogPath 
        {
            get { return _logPath; }
        }

        public static string DataFileName
        {
            get { return _dataFileName; }
        }

        public static string SaveFileName
        {
            get { return _saveFileName; }
        }

        public static string CompanyFactory
        {
            get { return _companyFactory; }
        }

        public static void Initialize()
        {
            AppConfigUtility util = new AppConfigUtility();
            _logPath = util.AppSettings("logPath");
            _dataFileName = util.AppSettings("dataFileName");
            _saveFileName = util.AppSettings("saveFileName");
            _companyFactory = util.AppSettings("companyFactory");
        }

    }
}
