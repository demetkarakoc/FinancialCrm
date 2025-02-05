namespace FinancialCrm
{
    partial class FrmCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankTransactions = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnBillings = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategoriesId = new System.Windows.Forms.Label();
            this.txtCategoriesId = new System.Windows.Forms.TextBox();
            this.txtCategoriesName = new System.Windows.Forms.TextBox();
            this.lblCategoriesName = new System.Windows.Forms.Label();
            this.btnCategoriesList = new System.Windows.Forms.Button();
            this.btnCategoriesAdd = new System.Windows.Forms.Button();
            this.btnCategoriesDelete = new System.Windows.Forms.Button();
            this.btnCategoriesUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankTransactions);
            this.panel1.Controls.Add(this.btnExpenses);
            this.panel1.Controls.Add(this.btnBillings);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(2, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 554);
            this.panel1.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(38, 365);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSettings.Location = new System.Drawing.Point(38, 319);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(171, 40);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDashboard.Location = new System.Drawing.Point(38, 264);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(171, 40);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankTransactions
            // 
            this.btnBankTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransactions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBankTransactions.Location = new System.Drawing.Point(38, 218);
            this.btnBankTransactions.Name = "btnBankTransactions";
            this.btnBankTransactions.Size = new System.Drawing.Size(171, 40);
            this.btnBankTransactions.TabIndex = 5;
            this.btnBankTransactions.Text = "Banka Hareketleri";
            this.btnBankTransactions.UseVisualStyleBackColor = true;
            this.btnBankTransactions.Click += new System.EventHandler(this.btnBankTransactions_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpenses.Location = new System.Drawing.Point(38, 172);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(171, 40);
            this.btnExpenses.TabIndex = 4;
            this.btnExpenses.Text = "Giderler";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnBillings
            // 
            this.btnBillings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBillings.Location = new System.Drawing.Point(38, 126);
            this.btnBillings.Name = "btnBillings";
            this.btnBillings.Size = new System.Drawing.Size(171, 40);
            this.btnBillings.TabIndex = 3;
            this.btnBillings.Text = "Faturalar";
            this.btnBillings.UseVisualStyleBackColor = true;
            this.btnBillings.Click += new System.EventHandler(this.btnBillings_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBanks.Location = new System.Drawing.Point(38, 80);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(171, 40);
            this.btnBanks.TabIndex = 2;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategories.Location = new System.Drawing.Point(38, 34);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(171, 40);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.btnCategoriesUpdate);
            this.panel2.Controls.Add(this.btnCategoriesDelete);
            this.panel2.Controls.Add(this.btnCategoriesAdd);
            this.panel2.Controls.Add(this.btnCategoriesList);
            this.panel2.Controls.Add(this.txtCategoriesName);
            this.panel2.Controls.Add(this.lblCategoriesName);
            this.panel2.Controls.Add(this.txtCategoriesId);
            this.panel2.Controls.Add(this.lblCategoriesId);
            this.panel2.Location = new System.Drawing.Point(278, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 225);
            this.panel2.TabIndex = 7;
            // 
            // lblCategoriesId
            // 
            this.lblCategoriesId.AutoSize = true;
            this.lblCategoriesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoriesId.Location = new System.Drawing.Point(70, 38);
            this.lblCategoriesId.Name = "lblCategoriesId";
            this.lblCategoriesId.Size = new System.Drawing.Size(136, 29);
            this.lblCategoriesId.TabIndex = 0;
            this.lblCategoriesId.Text = "Kategori Id:";
            // 
            // txtCategoriesId
            // 
            this.txtCategoriesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoriesId.Location = new System.Drawing.Point(212, 38);
            this.txtCategoriesId.Name = "txtCategoriesId";
            this.txtCategoriesId.Size = new System.Drawing.Size(331, 30);
            this.txtCategoriesId.TabIndex = 1;
            // 
            // txtCategoriesName
            // 
            this.txtCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoriesName.Location = new System.Drawing.Point(212, 84);
            this.txtCategoriesName.Name = "txtCategoriesName";
            this.txtCategoriesName.Size = new System.Drawing.Size(331, 30);
            this.txtCategoriesName.TabIndex = 3;
            // 
            // lblCategoriesName
            // 
            this.lblCategoriesName.AutoSize = true;
            this.lblCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoriesName.Location = new System.Drawing.Point(55, 85);
            this.lblCategoriesName.Name = "lblCategoriesName";
            this.lblCategoriesName.Size = new System.Drawing.Size(151, 29);
            this.lblCategoriesName.TabIndex = 2;
            this.lblCategoriesName.Text = "Kategori Adı:";
            // 
            // btnCategoriesList
            // 
            this.btnCategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesList.Location = new System.Drawing.Point(75, 155);
            this.btnCategoriesList.Name = "btnCategoriesList";
            this.btnCategoriesList.Size = new System.Drawing.Size(164, 40);
            this.btnCategoriesList.TabIndex = 4;
            this.btnCategoriesList.Text = "Kategori Listele";
            this.btnCategoriesList.UseVisualStyleBackColor = true;
            this.btnCategoriesList.Click += new System.EventHandler(this.btnCategoriesList_Click);
            // 
            // btnCategoriesAdd
            // 
            this.btnCategoriesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesAdd.Location = new System.Drawing.Point(276, 155);
            this.btnCategoriesAdd.Name = "btnCategoriesAdd";
            this.btnCategoriesAdd.Size = new System.Drawing.Size(149, 40);
            this.btnCategoriesAdd.TabIndex = 5;
            this.btnCategoriesAdd.Text = "Kategori Ekle";
            this.btnCategoriesAdd.UseVisualStyleBackColor = true;
            this.btnCategoriesAdd.Click += new System.EventHandler(this.btnCategoriesAdd_Click);
            // 
            // btnCategoriesDelete
            // 
            this.btnCategoriesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesDelete.Location = new System.Drawing.Point(458, 155);
            this.btnCategoriesDelete.Name = "btnCategoriesDelete";
            this.btnCategoriesDelete.Size = new System.Drawing.Size(161, 40);
            this.btnCategoriesDelete.TabIndex = 6;
            this.btnCategoriesDelete.Text = "Kategori Sil";
            this.btnCategoriesDelete.UseVisualStyleBackColor = true;
            this.btnCategoriesDelete.Click += new System.EventHandler(this.btnCategoriesDelete_Click);
            // 
            // btnCategoriesUpdate
            // 
            this.btnCategoriesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesUpdate.Location = new System.Drawing.Point(662, 155);
            this.btnCategoriesUpdate.Name = "btnCategoriesUpdate";
            this.btnCategoriesUpdate.Size = new System.Drawing.Size(193, 40);
            this.btnCategoriesUpdate.TabIndex = 7;
            this.btnCategoriesUpdate.Text = "Kategori Güncelle";
            this.btnCategoriesUpdate.UseVisualStyleBackColor = true;
            this.btnCategoriesUpdate.Click += new System.EventHandler(this.btnCategoriesUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 323);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1173, 75);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori Formu";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 704);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankTransactions;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnBillings;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategoriesId;
        private System.Windows.Forms.Button btnCategoriesUpdate;
        private System.Windows.Forms.Button btnCategoriesDelete;
        private System.Windows.Forms.Button btnCategoriesAdd;
        private System.Windows.Forms.Button btnCategoriesList;
        private System.Windows.Forms.TextBox txtCategoriesName;
        private System.Windows.Forms.Label lblCategoriesName;
        private System.Windows.Forms.TextBox txtCategoriesId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}