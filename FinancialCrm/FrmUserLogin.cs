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
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (db.Users.Select(x=>x.UserName==txtUserName.Text).FirstOrDefault() && db.Users.Select(x=>x.Password==txtPassword.Text).FirstOrDefault())
            {
                MessageBox.Show("Giriş başarılı. Banka Menüsüne yönlendiriliyorsunuz...");
                FrmCategories frm = new FrmCategories();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız tekrar deneyin...");
            }
        }
    }
}
