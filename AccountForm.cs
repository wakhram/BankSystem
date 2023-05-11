using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Linq;

namespace BankSystemWF
{
    public partial class AccountForm : Form
    {
        public List<string> operationName = new List<string>();
        public List<string> operationSum = new List<string>();
        mainForm f1;
        DispatcherTimer timer;
        DispatcherTimer timer2;

        int time;
        public AccountForm(mainForm form, string nameAcc)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            f1 = form;

            this.Text = nameAcc;

            XDocument xdoc = XDocument.Load("accounts.xml");
            // получаем корневой узел
            XElement datas = xdoc.Element("datas");
            if (datas != null)
            {
                // проходим по всем элементам person
                foreach (XElement account in datas.Elements("Account"))
                {
                    XAttribute name = account.Attribute("name");
                    XElement balance = account.Element("balance");
                    XElement interest = account.Element("InterestRate");
                    XElement iDate = account.Element("InterestDate");
                    XElement period = account.Element("Period");
                    XElement periodType = account.Element("PeriodType");

                    if (name.Value == nameAcc)
                    {
                        balanceLabel.Text = balance.Value;
                        string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + nameAcc + ".xml";
                        if (File.Exists(filePath))
                        {
                            XDocument xdoc2 = XDocument.Load(name.Value + ".xml");
                            // получаем корневой узел
                            XElement datas2 = xdoc2.Element("datas");
                            foreach (XElement account2 in datas2.Elements("operation"))
                            {
                                XAttribute name2 = account2.Attribute("name");
                                if (name2 != null && name2.Value != "InterestRate")
                                    operationName.Add(name2.Value);

                                XElement balance2 = account2.Element("count");
                                if (balance2 != null)
                                    operationSum.Add(balance2.Value);
                            }
                            int k = operationName.Count();
                            if (k > 0)
                            {
                                switch (k)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        dataGridView1.Rows.Add(operationName[0], operationSum[0]);
                                        break;
                                    case 2:
                                        dataGridView1.Rows.Add(operationName[1], operationSum[1]);
                                        dataGridView1.Rows.Add(operationName[0], operationSum[0]);
                                        break;
                                    case 3:
                                        dataGridView1.Rows.Add(operationName[2], operationSum[2]);
                                        dataGridView1.Rows.Add(operationName[1], operationSum[1]);
                                        dataGridView1.Rows.Add(operationName[0], operationSum[0]);
                                        break;
                                    default:
                                        for (int i = operationName.Count - 1; i > operationName.Count - 4; i--)
                                        {
                                            dataGridView1.Rows.Add(operationName[i], operationSum[i]);
                                        }
                                        break;
                                }
                            }
                        }

                        if (interest != null && interest.Value != "")
                        {
                            string s = periodType.Value.ToString();
                            int z = Convert.ToInt32(period.Value);
                            switch (s)
                            {
                                case "minutes":
                                    time = z * 60;
                                    break;
                                case "hours":
                                    time = z * 60 * 60;
                                    break;
                                case "days":
                                    time = z * 60 * 60 * 24;
                                    break;
                                case "month":
                                    time = z * 30 * 24 * 60 * 60;
                                    break;
                                default:
                                    break;
                            }

                            const string format = "dd:MM:yyyy HH:mm:ss";
                            DateTime date1 = DateTime.ParseExact(iDate.Value, format, CultureInfo.InvariantCulture);
                            DateTime date2 = DateTime.Now;
                            TimeSpan ts = date2.Subtract(date1);
                            TimeSpan ts2 = new TimeSpan(0, 0, time);

                            Console.WriteLine(date1);
                            Console.WriteLine(date2);
                            Console.WriteLine(ts);
                            Console.WriteLine(ts2);

                            if (ts >= ts2)
                            {
                                double lastB;

                                foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                                {
                                    if (xElement.Attribute("name").Value == this.Text)
                                    {
                                        XAttribute name2 = xElement.Attribute("name");
                                        XElement balance2 = xElement.Element("balance");
                                        XElement interest2 = xElement.Element("InterestRate");
                                        XElement period2 = xElement.Element("Period");
                                        XElement pT2 = xElement.Element("PeriodType");
                                        if (name.Value == this.Text)
                                        {
                                            double k = (Convert.ToDouble(balance2.Value) * Convert.ToDouble(interest2.Value)) / 100;
                                            lastB = Convert.ToDouble(balance2.Value) + k;

                                            XDocument xdoc2 = XDocument.Load("accounts.xml");
                                            var acc = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == this.Text);
                                            if (acc != null)
                                            {
                                                var b = acc.Element("balance");
                                                b.Value = lastB.ToString();

                                                var i = acc.Element("InterestRate");
                                                i.Value = "";

                                                var iD = acc.Element("InterestDate");
                                                iD.Value = "";

                                                var p = acc.Element("Period");
                                                p.Value = "";

                                                var pT = acc.Element("PeriodType");
                                                pT.Value = "";

                                                xdoc2.Save("accounts.xml");
                                            }

                                            addInterestRateXML(interest.Value.ToString(), k.ToString(), lastB.ToString(), DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss"), period2.Value.ToString(), pT2.Value.ToString(), this.Text + ".xml");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                timer = new DispatcherTimer();
                                timer.Interval = TimeSpan.FromSeconds(1);
                                timer.Tick += timer_Tick;
                                timer.IsEnabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void addInterestRateXML(string interest, string pay, string balance, string date, string p, string pT, string fileName)
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
                            new XElement("Pay", pay),
                            new XElement("Period", p),
                            new XElement("PeriodType", pT),
                            new XElement("Balance", balance)));
                doc.Save(fileName);
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            

            double lastB;

            foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                if (xElement.Attribute("name").Value == this.Text)
                {
                    XAttribute name = xElement.Attribute("name");
                    XElement balance = xElement.Element("balance");
                    XElement interest = xElement.Element("InterestRate");
                    XElement iDate = xElement.Element("InterestDate");
                    XElement period2 = xElement.Element("Period");
                    XElement pT2 = xElement.Element("PeriodType");


                    const string format = "dd:MM:yyyy HH:mm:ss";
                    DateTime date1 = DateTime.ParseExact(iDate.Value, format, CultureInfo.InvariantCulture);
                    DateTime date2 = DateTime.Now;
                    TimeSpan ts = date1.Subtract(date2);
                    TimeSpan ts2 = new TimeSpan(0, 0, time);

                    if (name.Value == this.Text)
                    {
                        if (ts >= ts2)
                        {
                            double k = (Convert.ToDouble(balance.Value) * Convert.ToDouble(interest.Value)) / 100;
                            lastB = Convert.ToDouble(balance.Value) + k;

                            XDocument xdoc = XDocument.Load("accounts.xml");
                            var acc = xdoc.Element("datas").Elements("Account").FirstOrDefault(p => p.Attribute("name")?.Value == this.Text);
                            if (acc != null)
                            {
                                var b = acc.Element("balance");
                                b.Value = lastB.ToString();
                                balanceLabel.Text = b.Value.ToString();

                                var i = acc.Element("InterestRate");
                                i.Value = "";

                                var p = acc.Element("Period");
                                p.Value = "";

                                var pT = acc.Element("PeriodType");
                                pT.Value = "";

                                xdoc.Save("accounts.xml");
                            }
                            addInterestRateXML(interest.Value.ToString(), k.ToString(), lastB.ToString(), DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss"), period2.Value.ToString(), pT2.Value.ToString(), this.Text + ".xml");
                            timer.Stop();
                        } 
                    }
                }
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            f1.Show();
            Close();
        }

        private void withdrawButtonClick(object sender, EventArgs e)
        {
            WithdrawMoneyForm withdrawMoneyForm = new WithdrawMoneyForm(this, this.Text);
            withdrawMoneyForm.Show();
        }

        private void topUpButtonClick(object sender, EventArgs e)
        {
            TopUpMoneyForm topUpMoneyForm = new TopUpMoneyForm(this, this.Text);
            topUpMoneyForm.Show();
        }

        private void transferButtonClick(object sender, EventArgs e)
        {
            TransferMoneyForm transferMoneyForm = new TransferMoneyForm(this, this.Text);
            transferMoneyForm.Show();
        }

        private void historyButtonClick(object sender, EventArgs e)
        {
            OperationHistoryForm operationHistoryForm = new OperationHistoryForm(this, this.Text);
            operationHistoryForm.Show();
        }

        private void procentButtonClick(object sender, EventArgs e)
        {
            addProcentInterestForm procentForm = new addProcentInterestForm(this, this.Text);
            procentForm.Show();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Show();
        }
    }
}
