namespace FinancialCrm
{
    partial class FrmBilling
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcess = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateBilling = new System.Windows.Forms.Button();
            this.btnDeleteBilling = new System.Windows.Forms.Button();
            this.btnCreateNewBilling = new System.Windows.Forms.Button();
            this.btnListBilling = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.financialCrmDbDataSet1 = new FinancialCrm.FinancialCrmDbDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(161)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "FATURA BİLGİLERİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnBankProcess);
            this.panel2.Controls.Add(this.btnSpendings);
            this.panel2.Controls.Add(this.btnBills);
            this.panel2.Controls.Add(this.btnBanksForm);
            this.panel2.Controls.Add(this.btnCategories);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 408);
            this.panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(16, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 31);
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
            this.btnSettings.Location = new System.Drawing.Point(16, 269);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(136, 31);
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
            this.btnDashboard.Location = new System.Drawing.Point(16, 232);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(136, 31);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankProcess
            // 
            this.btnBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcess.ForeColor = System.Drawing.Color.White;
            this.btnBankProcess.Location = new System.Drawing.Point(16, 195);
            this.btnBankProcess.Name = "btnBankProcess";
            this.btnBankProcess.Size = new System.Drawing.Size(136, 31);
            this.btnBankProcess.TabIndex = 5;
            this.btnBankProcess.Text = "Banka Hareketleri";
            this.btnBankProcess.UseVisualStyleBackColor = true;
            this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendings.ForeColor = System.Drawing.Color.White;
            this.btnSpendings.Location = new System.Drawing.Point(16, 158);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(136, 31);
            this.btnSpendings.TabIndex = 4;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.UseVisualStyleBackColor = true;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(16, 121);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(136, 31);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(16, 84);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(136, 31);
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
            this.btnCategories.Location = new System.Drawing.Point(16, 47);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(136, 31);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fatura Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miktar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Periyot:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.panel3.Controls.Add(this.btnUpdateBilling);
            this.panel3.Controls.Add(this.btnDeleteBilling);
            this.panel3.Controls.Add(this.btnCreateNewBilling);
            this.panel3.Controls.Add(this.btnListBilling);
            this.panel3.Controls.Add(this.txtBillPeriod);
            this.panel3.Controls.Add(this.txtBillAmount);
            this.panel3.Controls.Add(this.txtBillTitle);
            this.panel3.Controls.Add(this.txtBillId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(191, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 185);
            this.panel3.TabIndex = 7;
            // 
            // btnUpdateBilling
            // 
            this.btnUpdateBilling.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBilling.Location = new System.Drawing.Point(415, 143);
            this.btnUpdateBilling.Name = "btnUpdateBilling";
            this.btnUpdateBilling.Size = new System.Drawing.Size(141, 30);
            this.btnUpdateBilling.TabIndex = 15;
            this.btnUpdateBilling.Text = "Ödeme Güncelleme";
            this.btnUpdateBilling.UseVisualStyleBackColor = true;
            this.btnUpdateBilling.Click += new System.EventHandler(this.btnUpdateBilling_Click);
            // 
            // btnDeleteBilling
            // 
            this.btnDeleteBilling.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBilling.Location = new System.Drawing.Point(305, 143);
            this.btnDeleteBilling.Name = "btnDeleteBilling";
            this.btnDeleteBilling.Size = new System.Drawing.Size(104, 30);
            this.btnDeleteBilling.TabIndex = 14;
            this.btnDeleteBilling.Text = "Ödeme Sil";
            this.btnDeleteBilling.UseVisualStyleBackColor = true;
            this.btnDeleteBilling.Click += new System.EventHandler(this.btnDeleteBilling_Click);
            // 
            // btnCreateNewBilling
            // 
            this.btnCreateNewBilling.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateNewBilling.Location = new System.Drawing.Point(195, 143);
            this.btnCreateNewBilling.Name = "btnCreateNewBilling";
            this.btnCreateNewBilling.Size = new System.Drawing.Size(104, 30);
            this.btnCreateNewBilling.TabIndex = 13;
            this.btnCreateNewBilling.Text = "Yeni Ödeme";
            this.btnCreateNewBilling.UseVisualStyleBackColor = true;
            this.btnCreateNewBilling.Click += new System.EventHandler(this.btnCreateNewBilling_Click);
            // 
            // btnListBilling
            // 
            this.btnListBilling.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListBilling.Location = new System.Drawing.Point(82, 143);
            this.btnListBilling.Name = "btnListBilling";
            this.btnListBilling.Size = new System.Drawing.Size(104, 30);
            this.btnListBilling.TabIndex = 12;
            this.btnListBilling.Text = "Ödeme Listesi";
            this.btnListBilling.UseVisualStyleBackColor = true;
            this.btnListBilling.Click += new System.EventHandler(this.btnListBilling_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.Location = new System.Drawing.Point(150, 108);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(316, 20);
            this.txtBillPeriod.TabIndex = 11;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(150, 79);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(316, 20);
            this.txtBillAmount.TabIndex = 10;
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Location = new System.Drawing.Point(150, 50);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(316, 20);
            this.txtBillTitle.TabIndex = 9;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(150, 23);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(316, 20);
            this.txtBillId.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(121)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 194);
            this.dataGridView1.TabIndex = 8;
            // 
            // financialCrmDbDataSet1
            // 
            this.financialCrmDbDataSet1.DataSetName = "FinancialCrmDbDataSet";
            this.financialCrmDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(191, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 194);
            this.panel4.TabIndex = 9;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcess;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateBilling;
        private System.Windows.Forms.Button btnDeleteBilling;
        private System.Windows.Forms.Button btnCreateNewBilling;
        private System.Windows.Forms.Button btnListBilling;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FinancialCrmDbDataSet financialCrmDbDataSet1;
        private System.Windows.Forms.Panel panel4;
    }
}