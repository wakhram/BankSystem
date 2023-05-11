namespace BankSystemWF
{
    partial class createAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createAccForm));
            this.label2 = new System.Windows.Forms.Label();
            this.startBalance = new System.Windows.Forms.TextBox();
            this.createButton2 = new System.Windows.Forms.Button();
            this.questionPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starting balance:";
            // 
            // startBalance
            // 
            this.startBalance.BackColor = System.Drawing.Color.LightCyan;
            this.startBalance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.startBalance.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.startBalance.Location = new System.Drawing.Point(139, 65);
            this.startBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startBalance.Name = "startBalance";
            this.startBalance.Size = new System.Drawing.Size(174, 30);
            this.startBalance.TabIndex = 3;
            // 
            // createButton2
            // 
            this.createButton2.BackColor = System.Drawing.Color.LightCyan;
            this.createButton2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.createButton2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.createButton2.Location = new System.Drawing.Point(89, 119);
            this.createButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createButton2.Name = "createButton2";
            this.createButton2.Size = new System.Drawing.Size(140, 37);
            this.createButton2.TabIndex = 4;
            this.createButton2.Text = "Create";
            this.createButton2.UseVisualStyleBackColor = false;
            this.createButton2.Click += new System.EventHandler(this.createButton2Click);
            // 
            // questionPicture
            // 
            this.questionPicture.BackColor = System.Drawing.Color.Transparent;
            this.questionPicture.ErrorImage = null;
            this.questionPicture.Image = ((System.Drawing.Image)(resources.GetObject("questionPicture.Image")));
            this.questionPicture.Location = new System.Drawing.Point(290, 119);
            this.questionPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionPicture.Name = "questionPicture";
            this.questionPicture.Size = new System.Drawing.Size(34, 44);
            this.questionPicture.TabIndex = 5;
            this.questionPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "The bank issues the account";
            // 
            // createAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionPicture);
            this.Controls.Add(this.createButton2);
            this.Controls.Add(this.startBalance);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createAccForm";
            this.Text = "Create a new account";
            this.Load += new System.EventHandler(this.createAccForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startBalance;
        private System.Windows.Forms.Button createButton2;
        private System.Windows.Forms.PictureBox questionPicture;
        private System.Windows.Forms.Label label1;
    }
}