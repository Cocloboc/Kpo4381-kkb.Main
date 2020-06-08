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
using Kpo4381.kkb.Lib;

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
                MockCompanyListCommand mock = new MockCompanyListCommand();
                mock.Execute();
                bsCompanies.DataSource = companyList;
                dgvCompanies.DataSource = bsCompanies;
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
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
    }
}
