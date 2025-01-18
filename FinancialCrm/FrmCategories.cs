using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
      
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();
            categories.CategoryName = txtCategoryName.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi gerçekleşti...","Kategori Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeId = db.Categories.Find(id);
            db.Categories.Remove(removeId);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi gerçekleşti...", "Kategori Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;

            var values = db.Categories.Find(id);
            values.CategoryName = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi gerçekleşti...", "Kategori Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpending frmBilling = new FrmSpending();
            frmBilling.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
