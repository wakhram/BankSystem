namespace BankSystemWF
{
    partial class addProcentInterestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProcentInterestForm));
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.periodsList = new System.Windows.Forms.ComboBox();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newInterestBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightCyan;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.addButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.addButton.Location = new System.Drawing.Point(223, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 42);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButtonClear);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Interest rate:";
            // 
            // periodsList
            // 
            this.periodsList.BackColor = System.Drawing.Color.LightCyan;
            this.periodsList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.periodsList.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.periodsList.FormattingEnabled = true;
            this.periodsList.Location = new System.Drawing.Point(189, 170);
            this.periodsList.Name = "periodsList";
            this.periodsList.Size = new System.Drawing.Size(162, 30);
            this.periodsList.TabIndex = 15;
            // 
            // interestBox
            // 
            this.interestBox.BackColor = System.Drawing.Color.LightCyan;
            this.interestBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.interestBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.interestBox.Location = new System.Drawing.Point(188, 76);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(162, 30);
            this.interestBox.TabIndex = 16;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCyan;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.backButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 42);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Period:";
            // 
            // periodBox
            // 
            this.periodBox.BackColor = System.Drawing.Color.LightCyan;
            this.periodBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.periodBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.periodBox.Location = new System.Drawing.Point(189, 124);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(162, 30);
            this.periodBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Period type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(8, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "If you already have an interest rate,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(8, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "you can change it by clicking on the button";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "New interest rate:";
            // 
            // newInterestBox
            // 
            this.newInterestBox.BackColor = System.Drawing.Color.LightCyan;
            this.newInterestBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.newInterestBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.newInterestBox.Location = new System.Drawing.Point(188, 308);
            this.newInterestBox.Name = "newInterestBox";
            this.newInterestBox.Size = new System.Drawing.Size(162, 30);
            this.newInterestBox.TabIndex = 24;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightCyan;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.changeButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.changeButton.Location = new System.Drawing.Point(222, 358);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(128, 42);
            this.changeButton.TabIndex = 25;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightCyan;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clearButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.clearButton.Location = new System.Drawing.Point(16, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 42);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // addProcentInterestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 415);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newInterestBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.interestBox);
            this.Controls.Add(this.periodsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProcentInterestForm";
            this.Text = "addProcentInterestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox periodsList;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newInterestBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button clearButton;
    }
}