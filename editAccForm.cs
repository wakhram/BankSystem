using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemWF
{
    public partial class editAccForm : Form
    {
        mainForm f1;
        string nameAccount;
        public editAccForm(mainForm form, string s)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            f1 = form;
            this.Text = s;
            nameAccount = s;
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void editButtonClick(object sender, EventArgs e)
        {
            double count;
            bool isCheck = double.TryParse(balanceEditBox.Text, out count);
            if (isCheck)
            {
                if (count > 0)
                {
                    XDocument xdoc2 = XDocument.Load("accounts.xml");
                    var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == nameAccount);
                    if (lastBalance != null)
                    {
                        var bb = lastBalance.Element("balance");
                        bb.Value = count.ToString();

                        var cc = lastBalance.Element("editTime");
                        cc.Value = DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy");

                        var aa = lastBalance.Attribute("name");
                        string filePath2 = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + aa.Value.ToString() +".xml";
                        if (File.Exists(filePath2))
                        {
                            XDocument docNew = XDocument.Load(aa.Value.ToString() + ".xml");
                            docNew.Save(nameEditBox.Text.ToString() + ".xml");
                            File.Delete(filePath2);
                        }
                        aa.Value = nameEditBox.Text.ToString();

                        xdoc2.Save("accounts.xml");
                    }
                }
                else
                {
                    MessageBox.Show("You must enter a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You entered the initial balance incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Close();
        }
    }
}
