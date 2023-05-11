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
using System.Xml.XPath;

namespace BankSystemWF
{
    public partial class TopUpMoneyForm : Form
    {
        AccountForm accountForm;
        string NameAcc;
        public TopUpMoneyForm(AccountForm acc, string nameAcc)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            accountForm = acc;
            NameAcc = nameAcc;
        }
        private void addAccXMLLinq(string count, double balanceBefore, double balanceAfter, string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");

            if (root != null)
            {
                // добавляем новый элемент
                root.Add(new XElement("operation",
                            new XAttribute("name", "TopUpMoney"),
                            new XElement("balanceBefore", balanceBefore),
                            new XElement("count", count),
                            new XElement("balanceAfter", balanceAfter)));
                xdoc.Save(fileName);
            }

        }

        private void topUpButtonClick(object sender, EventArgs e)
        {
            double count;
            double balance;
            double balance2;
            bool isCheck = double.TryParse(topUpBox.Text, out count);
            if (isCheck)
            {
                string filePath2 = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\accounts.xml";
                if (File.Exists(filePath2))
                {
                    foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                    {
                        if (xElement.Attribute("name").Value == NameAcc)
                        {
                            if (count > 0)
                            {
                                balance = Convert.ToDouble(xElement.Element("balance").Value);
                                string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + NameAcc + ".xml";
                                if (File.Exists(filePath))
                                {
                                    balance2 = Convert.ToDouble(xElement.Element("balance").Value) + Convert.ToDouble(count);

                                    XDocument xdoc2 = XDocument.Load("accounts.xml");
                                    var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == NameAcc);
                                    if (lastBalance != null)
                                    {
                                        var bb = lastBalance.Element("balance");
                                        bb.Value = balance2.ToString();
                                        xdoc2.Save("accounts.xml");
                                    }
                                    accountForm.balanceLabel.Text = balance2.ToString();
                                    addAccXMLLinq(count.ToString(), balance, balance2, NameAcc + ".xml");
                                }
                                else
                                {
                                    XDocument xdoc = new XDocument();
                                    // создаем корневой элемент
                                    XElement datas = new XElement("datas");

                                    // добавляем корневой элемент в документ
                                    xdoc.Add(datas);
                                    //сохраняем документ
                                    xdoc.Save(NameAcc + ".xml");

                                    balance2 = Convert.ToDouble(xElement.Element("balance").Value) + Convert.ToDouble(count);

                                    XDocument xdoc2 = XDocument.Load("accounts.xml");
                                    var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == NameAcc);
                                    if (lastBalance != null)
                                    {
                                        var bb = lastBalance.Element("balance");
                                        bb.Value = balance2.ToString();
                                        xdoc2.Save("accounts.xml");
                                    }
                                    accountForm.balanceLabel.Text = balance2.ToString();

                                    addAccXMLLinq(count.ToString(), balance, balance2, NameAcc + ".xml");
                                }
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("You must enter a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You entered the initial balance incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
