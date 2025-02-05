using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmTransactions : Form
    {
        public FrmTransactions()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = (from process in db.BankProcesses
                          join banks in db.TblBanks
                          on process.BankId equals banks.BankId
                          select new { 
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();

            dataGridView1.DataSource = values;                   
                          
        }


        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            FrmSpendings  frm = new FrmSpendings();
            frm.Show();
            this.Hide();

        }

        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            FrmTransactions frm = new FrmTransactions();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            int BankName = int.Parse(txtBank.ToString());
            string type = txtType.Text;

            BankProcesses BankProcesses = new BankProcesses();
            BankProcesses.Description = description;
            BankProcesses.ProcessDate = date;
            BankProcesses.Amount = amount;
            BankProcesses.ProcessType = type;
            BankProcesses.BankId = BankName;
            db.BankProcesses.Add(BankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.TblBanks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankId,
                              process.Description,
                              process.Amount,
                              process.BankProcessId,
                              process.ProcessType,
                              BankName = banks.BankTitle
                          }).ToList();

            dataGridView1.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem Silindi", "Banka Hareket Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = (from process in db.BankProcesses
                          join banks in db.TblBanks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle

                          }).ToList();

            dataGridView1.DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBId.Text);
            string description = txtDescription.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            int BankName = int.Parse(txtBank.ToString());
            string type = txtType.Text;



            var BankProcesses = db.BankProcesses.Find(id);
            BankProcesses.Description = description;
            BankProcesses.Amount = amount;
            BankProcesses.ProcessDate = date;
            BankProcesses.ProcessType = type;
            BankProcesses.BankId = BankName;
            db.SaveChanges();
            MessageBox.Show("İşlem Güncellendi", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.TblBanks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.Amount,
                              process.ProcessDate,
                              process.ProcessType,
                              BankName = banks.BankTitle
                          }).ToList();

            dataGridView1.DataSource = values;
            

        }
    }
}
