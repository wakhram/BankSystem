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
    public partial class OperationHistoryForm : Form
    {
        AccountForm accountForm;
        string nameAcc;
        public OperationHistoryForm(AccountForm acc, string NameAcc)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            accountForm = acc;
            nameAcc = NameAcc;

            XDocument xdoc = XDocument.Load(nameAcc + ".xml");
            // получаем корневой узел
            XElement datas = xdoc.Element("datas");
            if (datas != null)
            {
                // проходим по всем элементам person
                foreach (XElement account in datas.Elements("operation"))
                {
                    XAttribute name = account.Attribute("name");
                    XElement balanceBefore = account.Element("balanceBefore");
                    XElement balanceAfter = account.Element("balanceAfter");
                    XElement sum = account.Element("count");
                    XElement transferTo = account.Element("transferAtTo");
                    if (name.Value != "InterestRate")
                    {
                        if (transferTo != null)
                        {
                            dataGridView1.Rows.Add(name.Value, balanceBefore.Value, sum.Value, balanceAfter.Value, transferTo.Value);
                        }
                        else
                        {
                            dataGridView1.Rows.Add(name.Value, balanceBefore.Value, sum.Value, balanceAfter.Value, "");
                        }
                    }
                    else
                    {
                        XElement interest = account.Element("InterestRate");
                        XElement iDate = account.Element("InterestDate");
                        XElement period = account.Element("Period");
                        XElement periodType = account.Element("PeriodType");
                        XElement pay = account.Element("Pay");
                        if (pay != null)
                        {
                            dataGridView2.Rows.Add(interest.Value, period.Value, periodType.Value, iDate.Value, pay.Value);
                        }
                        else
                        {
                            dataGridView2.Rows.Add(interest.Value, period.Value, periodType.Value, iDate.Value, "");
                        }
                    }
                }
            }
        }
    }
}
