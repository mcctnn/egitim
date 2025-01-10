using FinancialCrm.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var result = db.Bills.ToList();
            dataGridView1.DataSource = result;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var result = db.Bills.ToList();
            dataGridView1.DataSource = result;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title=tbxBillTitle.Text;
            decimal amount=decimal.Parse(tbxBillAmount.Text);
            string period=tbxBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK,MessageBoxIcon.Information);

            var result = db.Bills.ToList();
            dataGridView1.DataSource = result;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id =int.Parse(tbxBillId.Text);
            var deletedValue = db.Bills.Find(id);
            db.Bills.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var result = db.Bills.ToList();
            dataGridView1.DataSource = result;

        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxBillId.Text);
            string title = tbxBillTitle.Text;
            decimal amount = decimal.Parse(tbxBillAmount.Text);
            string period = tbxBillPeriod.Text;

            var result = db.Bills.Find(id);
            result.BillTitle = title;
            result.BillAmount = amount;
            result.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnFrmBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }
    }
}
