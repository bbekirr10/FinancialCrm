namespace FinancialCrm
{
    partial class FrmSpending
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategoryId = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialCrmDbDataSet2 = new FinancialCrm.FinancialCrmDbDataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateSpending = new System.Windows.Forms.Button();
            this.btnRemoveSpending = new System.Windows.Forms.Button();
            this.btnCreateSpending = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.txtSpendingDate = new System.Windows.Forms.TextBox();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriesTableAdapter = new FinancialCrm.FinancialCrmDbDataSet2TableAdapters.CategoriesTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(-1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 449);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(22, 280);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(138, 31);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(22, 243);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(138, 31);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(22, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(22, 169);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(138, 31);
            this.btnBillForm.TabIndex = 4;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(22, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(22, 95);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(138, 31);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(22, 58);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(138, 31);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategoryId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUpdateSpending);
            this.panel2.Controls.Add(this.btnRemoveSpending);
            this.panel2.Controls.Add(this.btnCreateSpending);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Controls.Add(this.txtSpendingDate);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(204, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 196);
            this.panel2.TabIndex = 2;
            // 
            // cmbCategoryId
            // 
            this.cmbCategoryId.DataSource = this.categoriesBindingSource;
            this.cmbCategoryId.DisplayMember = "CategoryId";
            this.cmbCategoryId.FormattingEnabled = true;
            this.cmbCategoryId.Location = new System.Drawing.Point(109, 127);
            this.cmbCategoryId.Name = "cmbCategoryId";
            this.cmbCategoryId.Size = new System.Drawing.Size(218, 21);
            this.cmbCategoryId.TabIndex = 16;
            this.cmbCategoryId.ValueMember = "CategoryName";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.financialCrmDbDataSet2;
            // 
            // financialCrmDbDataSet2
            // 
            this.financialCrmDbDataSet2.DataSetName = "FinancialCrmDbDataSet2";
            this.financialCrmDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "CategoryId:";
            // 
            // btnUpdateSpending
            // 
            this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpending.Location = new System.Drawing.Point(534, 159);
            this.btnUpdateSpending.Name = "btnUpdateSpending";
            this.btnUpdateSpending.Size = new System.Drawing.Size(134, 32);
            this.btnUpdateSpending.TabIndex = 14;
            this.btnUpdateSpending.Text = "Gider Güncelleme";
            this.btnUpdateSpending.UseVisualStyleBackColor = true;
            this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnRemoveSpending
            // 
            this.btnRemoveSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpending.Location = new System.Drawing.Point(388, 159);
            this.btnRemoveSpending.Name = "btnRemoveSpending";
            this.btnRemoveSpending.Size = new System.Drawing.Size(134, 32);
            this.btnRemoveSpending.TabIndex = 13;
            this.btnRemoveSpending.Text = "Gider Silme";
            this.btnRemoveSpending.UseVisualStyleBackColor = true;
            this.btnRemoveSpending.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnCreateSpending
            // 
            this.btnCreateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpending.Location = new System.Drawing.Point(242, 159);
            this.btnCreateSpending.Name = "btnCreateSpending";
            this.btnCreateSpending.Size = new System.Drawing.Size(134, 32);
            this.btnCreateSpending.TabIndex = 12;
            this.btnCreateSpending.Text = "Yeni Giderler";
            this.btnCreateSpending.UseVisualStyleBackColor = true;
            this.btnCreateSpending.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.Location = new System.Drawing.Point(82, 159);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(148, 32);
            this.btnSpendingList.TabIndex = 11;
            this.btnSpendingList.Text = "Gider Listesi";
            this.btnSpendingList.UseVisualStyleBackColor = true;
            this.btnSpendingList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // txtSpendingDate
            // 
            this.txtSpendingDate.Location = new System.Drawing.Point(109, 101);
            this.txtSpendingDate.Name = "txtSpendingDate";
            this.txtSpendingDate.Size = new System.Drawing.Size(559, 20);
            this.txtSpendingDate.TabIndex = 10;
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.Location = new System.Drawing.Point(109, 75);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(559, 20);
            this.txtSpendingAmount.TabIndex = 9;
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.Location = new System.Drawing.Point(109, 49);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(559, 20);
            this.txtSpendingTitle.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlık:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.Location = new System.Drawing.Point(109, 23);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(559, 20);
            this.txtSpendingId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gider Id:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(204, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 229);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 229);
            this.dataGridView1.TabIndex = 5;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 49);
            this.panel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(417, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "GİDERLER";
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(146)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(958, 493);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Payment Form";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.TextBox txtSpendingDate;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSpending;
        private System.Windows.Forms.Button btnRemoveSpending;
        private System.Windows.Forms.Button btnCreateSpending;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoryId;
        private FinancialCrmDbDataSet2 financialCrmDbDataSet2;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private FinancialCrmDbDataSet2TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
    }
}