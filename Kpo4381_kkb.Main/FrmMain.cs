using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4381.Utility;
using Kpo4381.Lib;

namespace Kpo4381.kkb.Main
{
    public partial class FrmMain : Form
    {
        private List<Company> companyList = null;
        private BindingSource bsCompanies = new BindingSource();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void nmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //ICompanyListLoader loader = new CompanyListSplitFileLoader(AppGlobalSettings.DataFileName);
                ICompanyListLoader loader = IoCLoader.container.Resolve<ICompanyListLoader>();
                companyList = loader.CompanyList;
                bsCompanies.DataSource = companyList;
                dgvCompanies.DataSource = bsCompanies;
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }

        private void mnOpenCompany_Click(object sender, EventArgs e)
        {
            //lab1
            FrmCompany frmCompany = new FrmCompany();
            Company company = (bsCompanies.Current as Company);
            frmCompany.SetEmployee(company);
            frmCompany.ShowDialog();
        }

        private void mmSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("logPath: " + AppGlobalSettings.LogPath + " DataFilePath: " + AppGlobalSettings.DataFileName);
        }
    }
}
