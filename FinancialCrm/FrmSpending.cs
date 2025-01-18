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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialCrmDbDataSet2.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.financialCrmDbDataSet2.Categories);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryId = int.Parse(cmbCategoryId.Text);

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = txtSpendingTitle.Text;
            spendings.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spendings.SpendingDate = DateTime.Parse(txtSpendingDate.Text);
            spendings.CategoryId = int.Parse(cmbCategoryId.Text);
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı...","Gider Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
           
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı...", "Gider Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryId = int.Parse(cmbCategoryId.Text);

            var values = db.Spendings.Find(id);
            values.SpendingTitle = txtSpendingTitle.Text;
            values.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            values.SpendingDate = DateTime.Parse(txtSpendingDate.Text);
            values.CategoryId = int.Parse(cmbCategoryId.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı...", "Gider Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Spendings.ToList();
            dataGridView1.DataSource = values2;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
