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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BankSystemWF
{
    public partial class addProcentInterestForm : Form
    {
        AccountForm accountForm;
        public addProcentInterestForm(AccountForm f, string name)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            accountForm = f;
            this.Text = name;

            periodsList.Items.Add("minutes");
            periodsList.Items.Add("hours");
            periodsList.Items.Add("days");
            periodsList.Items.Add("month");

            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            string text = "Only integers greater than zero are accepted.";
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.periodBox, text);


            ToolTip toolTip2 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1000;
            toolTip2.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip2.ShowAlways = true;
            string text2 = "Only whole or real numbers greater than zero are accepted";

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip2.SetToolTip(this.interestBox, text2);
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            newInterestBox.Text = "";
            interestBox.Text = "";
            periodBox.Text = "";
            periodsList.SelectedIndex = -1;
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            accountForm.Show();
            Hide();
        }

        private void addInterestRateXML(double interest, string period, string periodType, string date, string fileName)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement root = doc.Element("datas");

            if (root != null)
            {
                // добавляем новый элемент
                root.Add(new XElement("operation",
                            new XAttribute("name", "InterestRate"),
                            new XElement("InterestRate", interest.ToString()),
                            new XElement("InterestDate", date),
                            new XElement("Period", period),
                            new XElement("PeriodType", periodType)));
                doc.Save(fileName);
            }
        }

        private void addButtonClear(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\accounts.xml";
            if (File.Exists(filePath))
            {
                foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account")) 
                {
                    if (xElement.Attribute("name").Value == this.Text)
                    {
                        double interest;
                        int period;
                        bool isChek1 = double.TryParse(interestBox.Text, out interest);
                        bool isChek2 = int.TryParse(periodBox.Text, out period);

                        if (interest > 0 && period > 0 && isChek1 && isChek2 && periodsList.SelectedIndex != -1)
                        {

                            XDocument xdoc = XDocument.Load("accounts.xml");
                            var acc = xdoc.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == this.Text);
                            if (acc != null)
                            {
                                var i = acc.Element("InterestRate");
                                i.Value = interest.ToString();

                                var iD = acc.Element("InterestDate");
                                iD.Value = DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss");

                                var p = acc.Element("Period");
                                p.Value = period.ToString();

                                var pT = acc.Element("PeriodType");
                                pT.Value = periodsList.SelectedItem.ToString();

                                xdoc.Save("accounts.xml");
                            }

                            string filePath2 = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + this.Text + ".xml";
                            if (File.Exists(filePath2))
                            {
                                addInterestRateXML(interest, period.ToString(), periodsList.SelectedItem.ToString(), DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss"), this.Text + ".xml");
                            }
                            else
                            {
                                XDocument doc = new XDocument();
                                XElement data = new XElement("datas");
                                doc.Add(data);
                                doc.Save(this.Text + ".xml");

                                addInterestRateXML(interest, period.ToString(), periodsList.SelectedItem.ToString(), DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss"), this.Text + ".xml");
                            }
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("You did not fill out all the forms or filled out incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void changeButtonClick(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\accounts.xml";
            if (File.Exists(filePath))
            {
                foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                {
                    if (xElement.Attribute("name").Value == this.Text)
                    {
                        double interest;
                        bool isChek1 = double.TryParse(newInterestBox.Text, out interest);

                        if (isChek1)
                        {
                            XDocument xdoc = XDocument.Load("accounts.xml");
                            var acc = xdoc.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == this.Text);
                            if (acc != null)
                            {
                                var i = acc.Element("InterestRate");
                                if (i != null && i.Value != "")
                                    i.Value = interest.ToString();
                                else
                                    MessageBox.Show("You don't have an interest rate yet, you need to add it first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                xdoc.Save("accounts.xml");
                            }

                            string nn = this.Text + ".xml";
                            string filePath2 = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + nn;
                            if (File.Exists(filePath2))
                            {
                                addInterestRateXML(interest, xElement.Element("Period").Value, xElement.Element("PeriodType").Value, DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss"), nn);
                            }
                            else
                            {
                                MessageBox.Show("You don't have an interest rate yet, you need to add it first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            
                            
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("You did not fill out all the forms or filled out incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
