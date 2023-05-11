using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemWF
{
    public partial class infoForm : Form
    {
        loginForm form;
        public infoForm(loginForm f)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);

            string text = "How to use it?\r\n\r\n                                        " +
                "This is a bank application.\r\n- Here you can create and manage one or more accounts.When creating, \n" +
                "you need to specify your initial balance.The name of the account\n" +
                "is given by the program automatically and can be changed.\r\n" +
                "- After creating an account, you can specify the interest rate for the deposit\n" +
                "and the period. You will also need to select the period of time at which\n" +
                "interest should be calculated. They are available to choose from\n" +
                "every minute / hourly / daily / monthly.\r\n" +
                "- You will have access to such operations as: withdraw / replenish / transfer.\n" +
                "All numbers that will be entered in these fields must be either real or \n" +
                "integral and not be with \"-\".It is impossible to withdraw and \n" +
                "transfer more than you have.Transfer to another account \n" +
                "You can't if you only have one account.\r\n" +
                "- Also all transactions of each account will be stored.\r\n\r\n" +
                "                                                         Sincerely, Raimzhanov Bank!";
            mainLabel.Text = text;
        }
    }
}
