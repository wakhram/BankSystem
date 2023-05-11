namespace BankSystemWF
{
    partial class WithdrawMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawMoneyForm));
            this.backButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.backButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.LightCyan;
            this.withdrawButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.withdrawButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.withdrawButton.Location = new System.Drawing.Point(246, 12);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(131, 42);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Withdrawal amount:";
            // 
            // withdrawBox
            // 
            this.withdrawBox.BackColor = System.Drawing.Color.LightCyan;
            this.withdrawBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.withdrawBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.withdrawBox.Location = new System.Drawing.Point(206, 65);
            this.withdrawBox.Name = "withdrawBox";
            this.withdrawBox.Size = new System.Drawing.Size(171, 30);
            this.withdrawBox.TabIndex = 8;
            // 
            // WithdrawMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 124);
            this.Controls.Add(this.withdrawBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WithdrawMoneyForm";
            this.Text = "Withdraw Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox withdrawBox;
    }
}