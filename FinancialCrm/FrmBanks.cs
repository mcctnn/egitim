using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities dbEntities=new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {

            //banka bakiyesi
            var ziraatBankBalance = dbEntities.Banks.Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();
            var garantiBankBalance = dbEntities.Banks.Where(x => x.BankTitle == "Garanti Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = dbEntities.Banks.Where(x => x.BankTitle == "İş Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text=ziraatBankBalance.ToString()+" ₺";
            lblGarantiBankBalance.Text = garantiBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";

            //banka hareketleri
            var bp1=dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bp1.Description + " "+ bp1.Amount+ " "+bp1.ProcessDate;

            var bp2 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bp2.Description + " " + bp2.Amount + " " + bp2.ProcessDate;

            var bp3 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bp3.Description + " " + bp3.Amount + " " + bp3.ProcessDate;

            var bp4 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bp4.Description + " " + bp4.Amount + " " + bp4.ProcessDate;

            var bp5 = dbEntities.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bp5.Description + " " + bp5.Amount + " " + bp5.ProcessDate;
        }

        private void btnFrmBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }
    }
}
