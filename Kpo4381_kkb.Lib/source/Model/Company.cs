using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.kkb.Lib
{
    public class Company
    {
        public string Name { get; set; }
        public int Products { get; set; }
        public uint Sales { get; set; }
        public double MarketShare { get; set; }

        public Company()
        {
            Name = "";
            Products = 0;
            Sales = 0;
            MarketShare = 0d;
        }
    }
}
