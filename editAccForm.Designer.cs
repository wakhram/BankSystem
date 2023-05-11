namespace BankSystemWF
{
    partial class editAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAccForm));
            this.backButton = new System.Windows.Forms.Button();
            this.nameEditBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceEditBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.backButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.backButton.Location = new System.Drawing.Point(11, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 34);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // nameEditBox
            // 
            this.nameEditBox.BackColor = System.Drawing.Color.LightCyan;
            this.nameEditBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nameEditBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.nameEditBox.Location = new System.Drawing.Point(187, 54);
            this.nameEditBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameEditBox.Name = "nameEditBox";
            this.nameEditBox.Size = new System.Drawing.Size(122, 30);
            this.nameEditBox.TabIndex = 14;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LightCyan;
            this.editButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.editButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.editButton.Location = new System.Drawing.Point(213, 11);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 34);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "New name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "New balance:";
            // 
            // balanceEditBox
            // 
            this.balanceEditBox.BackColor = System.Drawing.Color.LightCyan;
            this.balanceEditBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.balanceEditBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.balanceEditBox.Location = new System.Drawing.Point(187, 89);
            this.balanceEditBox.Margin = new System.Windows.Forms.Padding(2);
            this.balanceEditBox.Name = "balanceEditBox";
            this.balanceEditBox.Size = new System.Drawing.Size(122, 30);
            this.balanceEditBox.TabIndex = 18;
            // 
            // editAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 133);
            this.Controls.Add(this.balanceEditBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.nameEditBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editAccForm";
            this.Text = "editAccForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox nameEditBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balanceEditBox;
    }
}