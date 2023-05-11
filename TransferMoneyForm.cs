using System;
using System.IO;
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
    public partial class TransferMoneyForm : Form
    {
        AccountForm accountForm;
        string nameAcc;
        public TransferMoneyForm(AccountForm acc, string NameAcc)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            accountForm = acc;
            nameAcc = NameAcc;

            foreach(XElement xElement in XElement.Load(@"accounts.xml").Elements("Account")) 
            {
                if (nameAcc != xElement.Attribute("name").Value)
                    accountsList.Items.Add(xElement.Attribute("name").Value);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void addAccXMLLinq(string count, double balanceBefore, double balanceAfter, string transferTo, string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");

            if (root != null)
            {
                // добавляем новый элемент
                root.Add(new XElement("operation",
                            new XAttribute("name", "TransferMoney"),
                            new XElement("balanceBefore", balanceBefore),
                            new XElement("count", count),
                            new XElement("balanceAfter", balanceAfter),
                            new XElement("transferAtTo", transferTo)));
                xdoc.Save(fileName);
            }

        }
        private void transferAtXML(double count, string transferAt, string fileName)
        {
            foreach(XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                if (xElement.Attribute("name").Value == fileName)
                {
                    double oldBalance = Convert.ToDouble(xElement.Element("balance").Value);
                    double newBalance = oldBalance + (count);
                    string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + fileName + ".xml";
                    if (File.Exists(filePath))
                    {
                        XDocument xdoc = XDocument.Load(fileName + ".xml");
                        XElement root = xdoc.Element("datas");

                        if (root != null)
                        {
                            // добавляем новый элемент
                            root.Add(new XElement("operation",
                                        new XAttribute("name", "TransferMoney"),
                                        new XElement("balanceBefore", oldBalance.ToString()),
                                        new XElement("count", count.ToString()),
                                        new XElement("balanceAfter", newBalance.ToString()),
                                        new XElement("transferAtTo", transferAt)));
                            xdoc.Save(fileName + ".xml");
                        }
                    }
                }
            }

            
        }
        private void transferButtonClick(object sender, EventArgs e)
        {
            if (accountsList.SelectedIndex != -1)
            {
                double count;
                double balance;
                double balance2;
                double balance3;
                bool isCheck = double.TryParse(transferBox.Text, out count);
                if (isCheck)
                {
                    foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                    {
                        if (xElement.Attribute("name").Value == nameAcc)
                        {
                            balance = Convert.ToDouble(xElement.Element("balance").Value);
                            if (balance >= count)
                            {
                                if (count > 0)
                                {
                                    string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + nameAcc + ".xml";
                                    if (File.Exists(filePath))
                                    {
                                        balance2 = Convert.ToDouble(xElement.Element("balance").Value) - Convert.ToDouble(count);

                                        transferAtXML(count, nameAcc, accountsList.SelectedItem.ToString());

                                        XDocument xdoc2 = XDocument.Load("accounts.xml");
                                        var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == nameAcc);
                                        if (lastBalance != null)
                                        {
                                            var bb = lastBalance.Element("balance");
                                            bb.Value = balance2.ToString();
                                            xdoc2.Save("accounts.xml");
                                        }
                                        var lastBalance2 = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == accountsList.SelectedItem.ToString());
                                        if (lastBalance2 != null)
                                        {
                                            var bb = lastBalance2.Element("balance");
                                            bb.Value = (count + Convert.ToDouble(bb.Value)).ToString();
                                            xdoc2.Save("accounts.xml");
                                        }
                                        accountForm.balanceLabel.Text = balance2.ToString();
                                        addAccXMLLinq(count.ToString(), balance, balance2, accountsList.SelectedItem.ToString(), nameAcc + ".xml");
                                    }
                                    else
                                    {
                                        XDocument xdoc = new XDocument();
                                        // создаем корневой элемент
                                        XElement datas = new XElement("datas");

                                        // добавляем корневой элемент в документ
                                        xdoc.Add(datas);
                                        //сохраняем документ
                                        xdoc.Save(nameAcc + ".xml");

                                        XDocument xdoc1 = new XDocument();
                                        // создаем корневой элемент
                                        XElement datas1 = new XElement("datas");

                                        // добавляем корневой элемент в документ
                                        xdoc1.Add(datas1);
                                        //сохраняем документ
                                        xdoc1.Save(accountsList.SelectedItem.ToString() + ".xml");
                                        transferAtXML(count, nameAcc, accountsList.SelectedItem.ToString());

                                        balance2 = Convert.ToDouble(xElement.Element("balance").Value) - Convert.ToDouble(count);
                                        balance3 = Convert.ToDouble(xElement.Element("balance").Value) + Convert.ToDouble(count);

                                        XDocument xdoc2 = XDocument.Load("accounts.xml");
                                        var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == nameAcc);
                                        if (lastBalance != null)
                                        {
                                            var bb = lastBalance.Element("balance");
                                            bb.Value = balance2.ToString();
                                            xdoc2.Save("accounts.xml");
                                        }
                                        var lastBalance2 = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == accountsList.SelectedItem.ToString());
                                        if (lastBalance2 != null)
                                        {
                                            var bb = lastBalance2.Element("balance");
                                            bb.Value = (count + Convert.ToDouble(bb.Value)).ToString();
                                            xdoc2.Save("accounts.xml");
                                        }
                                        accountForm.balanceLabel.Text = balance2.ToString();
                                        addAccXMLLinq(count.ToString(), balance, balance2, accountsList.SelectedItem.ToString(), nameAcc + ".xml");
                                    }
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("You must enter a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("You don't have enough funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You entered the initial balance incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
