namespace BankSystemWF
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.createButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.LightCyan;
            this.createButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.createButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.createButton.Location = new System.Drawing.Point(86, 141);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(255, 41);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create a new account";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButtonClick);
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.LightCyan;
            this.signinButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.signinButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.signinButton.Location = new System.Drawing.Point(86, 209);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(255, 41);
            this.signinButton.TabIndex = 1;
            this.signinButton.Text = "Sign in";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.signinButtonClick);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.LightCyan;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.quitButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.quitButton.Location = new System.Drawing.Point(86, 339);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(255, 41);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButtonClick);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.LightCyan;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.infoButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.infoButton.Location = new System.Drawing.Point(86, 273);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(255, 41);
            this.infoButton.TabIndex = 3;
            this.infoButton.Text = "How to use it?";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButtonClick);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.Text = "Raimzhanov Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button infoButton;
    }
}

