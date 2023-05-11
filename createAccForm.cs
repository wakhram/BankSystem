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
    public partial class createAccForm : Form
    {
        public createAccForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
        }
        private void createAccForm_Load(object sender, EventArgs e)
        {
            // This example assumes that the Form_Load event handling method
            // is connected to the Load event of the form.
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            string text = "Please enter the balance as numbers.\r\nIf the balance is not integer (e.g. 650.7, then enter it through ',', i.e. 650,7)";
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.questionPicture, text);
        }
        private void addAccXMLLinq(string accName, string accBalance, string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");

            
            if (root != null)
            {
                // добавляем новый элемент
                root.Add(new XElement("Account",
                            new XAttribute("name", accName),
                            new XElement("balance", accBalance),
                            new XElement("createTime", DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy")),
                            new XElement("editTime", ""),
                            new XElement("InterestRate", ""),
                            new XElement("InterestDate", ""),
                            new XElement("Period", ""),
                            new XElement("PeriodType", "")));
                xdoc.Save(fileName);
            }

        }
        private void createButton2Click(object sender, EventArgs e)
        {
            double balance;
            bool isCheck = double.TryParse(startBalance.Text, out balance);
            if (isCheck && balance > 0)
            {
                string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\accounts.xml";
                if (File.Exists(filePath))
                {
                    
                    string[] num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    string name = "KZ";
                    for (int i = 0; i < 6; i++)
                    {
                        name += num[new Random(Guid.NewGuid().GetHashCode()).Next(0, num.Length)];
                    }
                    XDocument xdoc2 = XDocument.Load("accounts.xml");
                    var lastBalance = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == name);
                    if (lastBalance != null)
                    {
                        MessageBox.Show("Give another name", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        addAccXMLLinq(name, startBalance.Text, "accounts.xml");
                    }
                }
                else
                {
                    XDocument xdoc = new XDocument();
                    // создаем корневой элемент
                    XElement datas = new XElement("datas");

                    // добавляем корневой элемент в документ
                    xdoc.Add(datas);
                    //сохраняем документ
                    xdoc.Save("accounts.xml");
                    string[] num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    string name = "KZ";
                    for (int i = 0; i < 6; i++)
                    {
                        name += num[new Random(Guid.NewGuid().GetHashCode()).Next(0, num.Length)];
                    }
                    addAccXMLLinq(name, startBalance.Text, "accounts.xml");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("You entered the initial balance incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
