using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemWF
{
    public partial class loginForm : Form
    {

        /*
         ----COLORS----
         RGB 
            main fon - (42, 37, 57)
            second fon - (189, 211, 204)
            text - (234, 233, 229)
            last - (239, 200, 200)
         --------------
         */
        public loginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
        }

        private void quitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButtonClick(object sender, EventArgs e)
        {
            createAccForm newForm = new createAccForm();
            newForm.Show();
        }

        private void signinButtonClick(object sender, EventArgs e)
        {
            mainForm newMainForm = new mainForm(this);
            newMainForm.Show();
            this.Hide();
        }

        private void infoButtonClick(object sender, EventArgs e)
        {
            infoForm infoForm1 = new infoForm(this);
            infoForm1.Show();
        }
    }
}
