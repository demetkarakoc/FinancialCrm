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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();


        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.TblBills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCategoriesList_Click(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList(); 
            dataGridView1.DataSource = values;
        }

        private void btnCategoriesAdd_Click(object sender, EventArgs e)
        {
            string Name = txtCategoriesName.Text;
            TblCategory categories = new TblCategory();
            categories.CategoryName = Name;
            db.TblCategory.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori ekleme başarılı", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.TblBills.ToList() ;
            dataGridView1.DataSource = values;
        }

        private void btnCategoriesDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoriesId.Text);
            var removeValue = db.TblCategory.Find(id);
            db.TblCategory.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information );
            var values = db.TblBills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCategoriesUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoriesId.Text) ;
            string name = txtCategoriesName.Text;
            var categories = db.TblCategory.Find( id);
            categories.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori güncellendi", "Kategori Formu",MessageBoxButtons.OK, MessageBoxIcon.Information );
            var values = db.TblBills.ToList();
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
    }
}
