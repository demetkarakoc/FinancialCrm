using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = (from spending in db.TblSpending
                          join category in db.TblCategory
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingDate,
                              spending.SpendingAmount,
                              CategoryName = category.CategoryName,
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
            FrmSpendings frm = new FrmSpendings();
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

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = (from spending in db.TblSpending
                          join category in db.TblCategory
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingDate,
                              spending.SpendingAmount,
                              CategoryName = category.CategoryName
                          }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date=Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(txtSpendingCategory.ToString());

            TblSpending spendings = new TblSpending();
            spendings.SpendingTitle = title;
            spendings.SpendingDate = date;
            spendings.SpendingAmount = amount;
            spendings.CategoryId = categoryName;
            db.TblSpending.Add(spendings);  
            db.SaveChanges();
            MessageBox.Show("Başarılı bir şekilde eklendi", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.TblSpending
                          join category in db.TblCategory
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingTitle,
                              spending.SpendingDate,
                              spending.SpendingAmount,
                              spending.SpendingId,
                              CategoryName = category.CategoryName
                          }).ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.TblSpending.Find(id);
            db.TblSpending.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama silindi", "Gider Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.TblSpending
                          join category in db.TblCategory
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingDate,
                              spending.SpendingAmount,
                              CategoryName = category.CategoryName
                          }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(txtSpendingCategory.ToString());


            var spendings = db.TblSpending.Find(id);
            spendings.SpendingTitle = title;
            spendings.SpendingDate = date;
            spendings.SpendingAmount = amount;
            spendings.CategoryId = categoryName;
            db.SaveChanges();
            MessageBox.Show("Harcama Güncellendi", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.TblSpending
                          join category in db.TblCategory
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingDate,
                              spending.SpendingAmount,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;  

        }
    }
}
