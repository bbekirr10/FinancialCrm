using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnListBilling_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateNewBilling_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = txtBillTitle.Text;
            bills.BillAmount = decimal.Parse(txtBillAmount.Text);
            bills.BillPeriod = txtBillPeriod.Text;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı...","Fatura Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteBilling_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var values = db.Bills.Find(id);
            db.Bills.Remove(values);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı...", "Fatura Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnUpdateBilling_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            var values = db.Bills.Find(id);
            values.BillTitle = txtBillTitle.Text;
            values.BillAmount = decimal.Parse(txtBillAmount.Text);
            values.BillPeriod = txtBillPeriod.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı...", "Fatura Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
            frm.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
