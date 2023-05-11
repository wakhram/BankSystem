using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystemWF
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        loginForm form1;
        public mainForm(loginForm loginForm1)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 37, 57);
            form1 = loginForm1;

            exportDatas();
        }

        private void exportDatas ()
        {
            string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\accounts.xml";
            if (File.Exists(filePath))
            {
                foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                {
                    dataGridView1.Rows.Add(xElement.Attribute("name").Value, xElement.Element("balance").Value);
                }
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            form1.Show();
        }

        private void signinButtonClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {
                AccountForm fNew = new AccountForm(this, (dataGridView1.CurrentRow.Cells[0].Value).ToString());
                fNew.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select one account", "Error", MessageBoxButtons.OK);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                XDocument xdoc = XDocument.Load("accounts.xml");
                XElement root = xdoc.Element("datas");

                if (root != null)
                {
                    // получим элемент person с name = "Bob"
                    var bob = root.Elements("Account")
                        .FirstOrDefault(p => p.Attribute("name")?.Value == item.Cells[0].Value.ToString());
                    // и удалим его
                    if (bob != null)
                    {
                        bob.Remove();
                        xdoc.Save("accounts.xml");
                    }
                }
                string filePath = @"C:\Users\davro\source\repos\BankSystemWF\BankSystemWF\bin\Debug\" + item.Cells[0].Value + ".xml";
                if (File.Exists(filePath))
                {
                    addTimeXMLLinq(item.Cells[0].Value + ".xml");
                }
                else
                {
                    XDocument xdoc2 = new XDocument();
                    // создаем корневой элемент
                    XElement datas = new XElement("datas");

                    // добавляем корневой элемент в документ
                    xdoc2.Add(datas);
                    //сохраняем документ
                    xdoc2.Save(item.Cells[0].Value + ".xml");
                    addTimeXMLLinq(item.Cells[0].Value + ".xml");
                }
            }
            dataGridView1.Rows.Clear();
            foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                dataGridView1.Rows.Add(xElement.Attribute("name").Value, xElement.Element("balance").Value);
            }
        }
        private void addTimeXMLLinq(string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");

            if (root != null)
            {
                string ss = "RIP " + DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy");
                // добавляем новый элемент
                root.Add(new XElement("LastOperation", ss));
                xdoc.Save(fileName);
            }

        }

        private void editButtonClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                editAccForm editForm = new editAccForm(this, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one account", "Error", MessageBoxButtons.OK);
            }

            dataGridView1.Rows.Clear();
            foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                dataGridView1.Rows.Add(xElement.Attribute("name").Value, xElement.Element("balance").Value);
            }

        }
    }
}
