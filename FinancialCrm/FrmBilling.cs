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
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string billTitle = txtBillTitle.Text;
            decimal billAmount =decimal.Parse(txtBillAmount.Text);
            string billPeriod = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = billTitle;
            bills.BillAmount = billAmount;
            bills.BillPeriod = billPeriod;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Bill Payment has been successfully added to the system.","Bill Payment",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            var values = db.Bills.ToList();
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
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Bill Payment has been successfully deleted from the system.", "Bill Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string billTitle = txtBillTitle.Text;
            decimal billAmount = decimal.Parse(txtBillAmount.Text);
            string billPeriod = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var values = db.Bills.Find(id);
            values.BillTitle = billTitle;
            values.BillAmount = billAmount;
            values.BillPeriod = billPeriod;
            db.SaveChanges();
            MessageBox.Show("Bill Payment has been successfully updated.", "Bill Update",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
   
        }
    }
}
