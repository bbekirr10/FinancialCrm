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
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialCrmDbDataSet1.Banks' table. You can move, or remove it, as needed.
            this.banksTableAdapter.Fill(this.financialCrmDbDataSet1.Banks);
            // TODO: This line of code loads data into the 'financialCrmDbDataSet.BankProcesses' table. You can move, or remove it, as needed.
            this.bankProcessesTableAdapter.Fill(this.financialCrmDbDataSet.BankProcesses);


            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }


        private void btnAddNewProcess_Click(object sender, EventArgs e)
        {
           
            string description = txtDescription.Text;
            DateTime dateTime =Convert.ToDateTime (txtProcessDate.Text);
            string processType = txtProcessType.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int bankId = int.Parse(cmbBankId.Text);
           

            BankProcesses bankProcesses = new BankProcesses();

            bankProcesses.Description = txtDescription.Text;
            bankProcesses.ProcessData =Convert.ToDateTime( txtProcessDate.Text);
            bankProcesses.ProcessType = txtProcessType.Text;
            bankProcesses.Amount = decimal.Parse(txtAmount.Text);
            bankProcesses.BankId = bankId;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi gerçekleşti...", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;     

        }

        private void btnBankProcessDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var values = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(values);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi gerçekleşti...","Silme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            var values2 = db.BankProcesses.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBankProcessUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            string description = txtDescription.Text;
            DateTime dateTime = Convert.ToDateTime(txtProcessDate.Text);
            string processType = txtProcessType.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int bankId = int.Parse(cmbBankId.Text);

            var values = db.BankProcesses.Find(id);

            values.Description = txtDescription.Text;
            values.ProcessData = Convert.ToDateTime(txtProcessDate.Text);
            values.ProcessType = txtProcessType.Text;
            values.Amount = decimal.Parse(txtAmount.Text);
            values.BankId = bankId;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi gerçekleşti...", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.BankProcesses.ToList();
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

        private void btnBillForm_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBills_Click(object sender, EventArgs e)
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
