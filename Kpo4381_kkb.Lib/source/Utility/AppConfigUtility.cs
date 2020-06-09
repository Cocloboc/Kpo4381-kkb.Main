using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4381.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            string settings = ConfigurationManager.AppSettings[name];
            if (settings != null)
                return settings;
            else
                return "";
        }
    }

}
