namespace BankSystemWF
{
    partial class TransferMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMoneyForm));
            this.accountsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transferBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountsList
            // 
            this.accountsList.BackColor = System.Drawing.Color.LightCyan;
            this.accountsList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.accountsList.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.accountsList.FormattingEnabled = true;
            this.accountsList.Location = new System.Drawing.Point(174, 69);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(162, 30);
            this.accountsList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose account:";
            // 
            // transferBox
            // 
            this.transferBox.BackColor = System.Drawing.Color.LightCyan;
            this.transferBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.transferBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.transferBox.Location = new System.Drawing.Point(174, 109);
            this.transferBox.Name = "transferBox";
            this.transferBox.Size = new System.Drawing.Size(162, 30);
            this.transferBox.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.backButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 42);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transfer amount:";
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.LightCyan;
            this.transferButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.transferButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.transferButton.Location = new System.Drawing.Point(208, 12);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(128, 42);
            this.transferButton.TabIndex = 14;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButtonClick);
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 174);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transferBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferMoneyForm";
            this.Text = "Transfer Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accountsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transferBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transferButton;
    }
}