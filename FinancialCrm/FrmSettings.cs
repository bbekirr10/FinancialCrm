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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var values = db.Users.Find(id);
            values.UserName = txtUserName.Text;
            values.Password = txtPassword.Text;
            db.SaveChanges();
            MessageBox.Show("Mevcut Kullanıcı Adı ve Şifre Başarıyla Değiştirildi...","Kullanıcı Adı ve Şifre Değiştirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
