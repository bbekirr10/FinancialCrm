namespace FinancialCrm
{
    partial class FrmBankProcess
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankProcess = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnBankProcessUpdate = new System.Windows.Forms.Button();
            this.btnBankProcessDelete = new System.Windows.Forms.Button();
            this.btnAddNewProcess = new System.Windows.Forms.Button();
            this.btnBankProcessList = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.txtProcessDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankProcessId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbBankId = new System.Windows.Forms.ComboBox();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialCrmDbDataSet1 = new FinancialCrm.FinancialCrmDbDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.financialCrmDbDataSet = new FinancialCrm.FinancialCrmDbDataSet();
            this.bankProcessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankProcessesTableAdapter = new FinancialCrm.FinancialCrmDbDataSetTableAdapters.BankProcessesTableAdapter();
            this.banksTableAdapter = new FinancialCrm.FinancialCrmDbDataSet1TableAdapters.BanksTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankProcessesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 45);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "BANKA HAREKETLERİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankProcess);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(-2, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 504);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(13, 282);
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
            this.btnSettings.Location = new System.Drawing.Point(13, 245);
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
            this.btnDashboard.Location = new System.Drawing.Point(13, 208);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(138, 31);
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
            this.btnBankProcess.Location = new System.Drawing.Point(13, 171);
            this.btnBankProcess.Name = "btnBankProcess";
            this.btnBankProcess.Size = new System.Drawing.Size(138, 31);
            this.btnBankProcess.TabIndex = 5;
            this.btnBankProcess.Text = "Banka Hareketleri";
            this.btnBankProcess.UseVisualStyleBackColor = true;
            this.btnBankProcess.Click += new System.EventHandler(this.btnBankProcess_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(13, 134);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(138, 31);
            this.btnBillForm.TabIndex = 4;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = true;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(13, 97);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(138, 31);
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
            this.btnBanksForm.Location = new System.Drawing.Point(13, 60);
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
            this.btnCategories.Location = new System.Drawing.Point(13, 23);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(138, 31);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnBankProcessUpdate
            // 
            this.btnBankProcessUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessUpdate.Location = new System.Drawing.Point(448, 173);
            this.btnBankProcessUpdate.Name = "btnBankProcessUpdate";
            this.btnBankProcessUpdate.Size = new System.Drawing.Size(141, 52);
            this.btnBankProcessUpdate.TabIndex = 26;
            this.btnBankProcessUpdate.Text = "Banka Hareket\r\nGüncelleme";
            this.btnBankProcessUpdate.UseVisualStyleBackColor = true;
            this.btnBankProcessUpdate.Click += new System.EventHandler(this.btnBankProcessUpdate_Click);
            // 
            // btnBankProcessDelete
            // 
            this.btnBankProcessDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessDelete.Location = new System.Drawing.Point(294, 174);
            this.btnBankProcessDelete.Name = "btnBankProcessDelete";
            this.btnBankProcessDelete.Size = new System.Drawing.Size(151, 52);
            this.btnBankProcessDelete.TabIndex = 25;
            this.btnBankProcessDelete.Text = "Banka Hareket\r\nSilme";
            this.btnBankProcessDelete.UseVisualStyleBackColor = true;
            this.btnBankProcessDelete.Click += new System.EventHandler(this.btnBankProcessDelete_Click);
            // 
            // btnAddNewProcess
            // 
            this.btnAddNewProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewProcess.Location = new System.Drawing.Point(157, 174);
            this.btnAddNewProcess.Name = "btnAddNewProcess";
            this.btnAddNewProcess.Size = new System.Drawing.Size(134, 52);
            this.btnAddNewProcess.TabIndex = 24;
            this.btnAddNewProcess.Text = "Yeni Hareket";
            this.btnAddNewProcess.UseVisualStyleBackColor = true;
            this.btnAddNewProcess.Click += new System.EventHandler(this.btnAddNewProcess_Click);
            // 
            // btnBankProcessList
            // 
            this.btnBankProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessList.Location = new System.Drawing.Point(6, 173);
            this.btnBankProcessList.Name = "btnBankProcessList";
            this.btnBankProcessList.Size = new System.Drawing.Size(148, 52);
            this.btnBankProcessList.TabIndex = 23;
            this.btnBankProcessList.Text = "Banka Hareket Listesi";
            this.btnBankProcessList.UseVisualStyleBackColor = true;
            this.btnBankProcessList.Click += new System.EventHandler(this.btnBankProcessList_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(162, 115);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(329, 20);
            this.txtAmount.TabIndex = 22;
            // 
            // txtProcessType
            // 
            this.txtProcessType.Location = new System.Drawing.Point(162, 90);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(329, 20);
            this.txtProcessType.TabIndex = 21;
            // 
            // txtProcessDate
            // 
            this.txtProcessDate.Location = new System.Drawing.Point(162, 65);
            this.txtProcessDate.Name = "txtProcessDate";
            this.txtProcessDate.Size = new System.Drawing.Size(329, 20);
            this.txtProcessDate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "İşlem Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "İşlem Tarihi:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(329, 20);
            this.txtDescription.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Banka Hareket Id:";
            // 
            // txtBankProcessId
            // 
            this.txtBankProcessId.Location = new System.Drawing.Point(162, 14);
            this.txtBankProcessId.Name = "txtBankProcessId";
            this.txtBankProcessId.Size = new System.Drawing.Size(329, 20);
            this.txtBankProcessId.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbBankId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtBankProcessId);
            this.panel3.Controls.Add(this.btnBankProcessUpdate);
            this.panel3.Controls.Add(this.btnBankProcessDelete);
            this.panel3.Controls.Add(this.btnAddNewProcess);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.btnBankProcessList);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtProcessDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtProcessType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(183, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 233);
            this.panel3.TabIndex = 31;
            // 
            // cmbBankId
            // 
            this.cmbBankId.DataSource = this.banksBindingSource;
            this.cmbBankId.DisplayMember = "BankId";
            this.cmbBankId.FormattingEnabled = true;
            this.cmbBankId.Location = new System.Drawing.Point(163, 141);
            this.cmbBankId.Name = "cmbBankId";
            this.cmbBankId.Size = new System.Drawing.Size(121, 21);
            this.cmbBankId.TabIndex = 32;
            this.cmbBankId.ValueMember = "BankTitle";
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.financialCrmDbDataSet1;
            // 
            // financialCrmDbDataSet1
            // 
            this.financialCrmDbDataSet1.DataSetName = "FinancialCrmDbDataSet1";
            this.financialCrmDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(85, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Banka Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 229);
            this.dataGridView1.TabIndex = 32;
            // 
            // financialCrmDbDataSet
            // 
            this.financialCrmDbDataSet.DataSetName = "FinancialCrmDbDataSet";
            this.financialCrmDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankProcessesBindingSource
            // 
            this.bankProcessesBindingSource.DataMember = "BankProcesses";
            this.bankProcessesBindingSource.DataSource = this.financialCrmDbDataSet;
            // 
            // bankProcessesTableAdapter
            // 
            this.bankProcessesTableAdapter.ClearBeforeFill = true;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBankProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBankProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcess";
            this.Load += new System.EventHandler(this.FrmBankProcess_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialCrmDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankProcessesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankProcess;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnBankProcessUpdate;
        private System.Windows.Forms.Button btnBankProcessDelete;
        private System.Windows.Forms.Button btnAddNewProcess;
        private System.Windows.Forms.Button btnBankProcessList;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.TextBox txtProcessDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankProcessId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBankId;
        private FinancialCrmDbDataSet financialCrmDbDataSet;
        private System.Windows.Forms.BindingSource bankProcessesBindingSource;
        private FinancialCrmDbDataSetTableAdapters.BankProcessesTableAdapter bankProcessesTableAdapter;
        private FinancialCrmDbDataSet1 financialCrmDbDataSet1;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private FinancialCrmDbDataSet1TableAdapters.BanksTableAdapter banksTableAdapter;
    }
}