using Kpo4381.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4381.kkb.Main
{
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private Company _company = null;

        public Company employee { get { return _company; } }

        public void SetEmployee(Company company)
        {
            this._company = company;

        }
    }
}
