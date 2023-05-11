namespace BankSystemWF
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.topUpButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(7, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent transactions";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.backButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 46);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.LightCyan;
            this.historyButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.historyButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.historyButton.Location = new System.Drawing.Point(97, 241);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(241, 53);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "Operations history";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButtonClick);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.LightCyan;
            this.withdrawButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.withdrawButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.withdrawButton.Location = new System.Drawing.Point(97, 64);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(241, 53);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw money";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButtonClick);
            // 
            // topUpButton
            // 
            this.topUpButton.BackColor = System.Drawing.Color.LightCyan;
            this.topUpButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.topUpButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.topUpButton.Location = new System.Drawing.Point(97, 123);
            this.topUpButton.Name = "topUpButton";
            this.topUpButton.Size = new System.Drawing.Size(241, 53);
            this.topUpButton.TabIndex = 7;
            this.topUpButton.Text = "Top up";
            this.topUpButton.UseVisualStyleBackColor = false;
            this.topUpButton.Click += new System.EventHandler(this.topUpButtonClick);
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.LightCyan;
            this.transferButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.transferButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.transferButton.Location = new System.Drawing.Point(97, 182);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(241, 53);
            this.transferButton.TabIndex = 8;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(7, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.balanceLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.balanceLabel.Location = new System.Drawing.Point(199, 354);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 25);
            this.balanceLabel.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountName,
            this.AccountBalance});
            this.dataGridView1.GridColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.Location = new System.Drawing.Point(12, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(408, 120);
            this.dataGridView1.TabIndex = 11;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Operation Name";
            this.AccountName.MinimumWidth = 6;
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AccountBalance
            // 
            this.AccountBalance.HeaderText = "Sum";
            this.AccountBalance.MinimumWidth = 6;
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.ReadOnly = true;
            this.AccountBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // procentButton
            // 
            this.procentButton.BackColor = System.Drawing.Color.LightCyan;
            this.procentButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.procentButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.procentButton.Location = new System.Drawing.Point(97, 300);
            this.procentButton.Name = "procentButton";
            this.procentButton.Size = new System.Drawing.Size(241, 53);
            this.procentButton.TabIndex = 12;
            this.procentButton.Text = "Interest rate";
            this.procentButton.UseVisualStyleBackColor = false;
            this.procentButton.Click += new System.EventHandler(this.procentButtonClick);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.procentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.topUpButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.Text = "Raimzhanov Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button topUpButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.Button procentButton;
    }
}