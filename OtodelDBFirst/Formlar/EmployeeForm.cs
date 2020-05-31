using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodelDBFirst.Formlar
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void GetEmployees()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            using(OtodelContext otodelContext = new OtodelContext())
            {
                var EmployeeResult = from employees in otodelContext.Employees
                                     where employees.EmployeeRank != "Gelistirici"
                                     select employees;
                foreach(Employee employee in EmployeeResult)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = employee.EmployeeID;
                    listViewItem.SubItems.Add(employee.EmployeeMail);
                    listViewItem.SubItems.Add(employee.Password);
                    listViewItem.SubItems.Add(employee.FirstName);
                    listViewItem.SubItems.Add(employee.LastName);
                    listViewItem.SubItems.Add(employee.EmployeeRank);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        private bool EmptyControl()
        {
            if(eEmailTB.Text.Trim() == "" || eFirstNameTB.Text.Trim() == "" || eLastNameTB.Text.Trim() == "" || ePasswordTB.Text.Trim() == "" || eRankCB.Text.Trim() == "")
                return true;
            else
                return false;
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }
        private void ClearAreas()
        {
            eEmailTB.Text = "";
            eRankCB.SelectedIndex = -1;
            ePasswordTB.Text = "";
            eFirstNameTB.Text = "";
            eLastNameTB.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmptyControl())
                MessageBox.Show("Boş alan bırakmayınız..");
            else if (eTCTB.Text.Trim().Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik numarasını doğru bir değer girin!");
            }
            else
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    otodelContext.Employees.Add(new Employee
                    {
                        EmployeeID = eTCTB.Text,
                        EmployeeMail = eEmailTB.Text,
                        Password = ePasswordTB.Text,
                        FirstName = eFirstNameTB.Text,
                        LastName = eLastNameTB.Text,
                        EmployeeRank = eRankCB.Text
                    });
                    otodelContext.SaveChanges();
                    GetEmployees();
                    MessageBox.Show("Kayıt başarılı!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmptyControl())
                MessageBox.Show("Boş alan bırakmayınız..");
            else if (eTCTB.Text.Trim().Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik numarasını doğru bir değer girin!");
            }
            else
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    Employee employee = otodelContext.Employees.Find(eTCTB.Text);
                    if(employee is null)
                    {
                        MessageBox.Show("Böyle bir personel bulunamadı");
                    }
                    else
                    {
                        employee.EmployeeMail = eEmailTB.Text.Trim();
                        employee.Password = ePasswordTB.Text.Trim();
                        employee.FirstName = eFirstNameTB.Text.Trim();
                        employee.LastName = eLastNameTB.Text.Trim();
                        employee.EmployeeRank = eRankCB.Text;
                        otodelContext.SaveChanges();
                        GetEmployees();
                        MessageBox.Show("Güncelleme başarılı!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(eTCTB.Text.Trim() == "" || eTCTB.Text.Trim().Length != 11)
            {
                MessageBox.Show("Doğru bir TC Kimlik numarası girin");
            }
            else
            {
                using(OtodelContext otodelContext = new OtodelContext())
                {
                    Employee employee = otodelContext.Employees.Find(eTCTB.Text.Trim());
                    if(employee is null)
                    {
                        MessageBox.Show("Böyle bir personel bulunamadı");
                    }
                    else
                    {
                        DialogResult ds = MessageBox.Show(employee.EmployeeID + 
                            " numaralı " + employee.FirstName + " " + employee.LastName +
                            " bilgilerini silmek ister misiniz?","Personel siliniyor",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if(ds == DialogResult.Yes)
                        {
                            otodelContext.Employees.Remove(employee);
                            otodelContext.SaveChanges();
                            GetEmployees();
                            MessageBox.Show("Silme işlemi başarılı");
                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                eTCTB.Text = listView1.SelectedItems[0].SubItems[0].Text;
                eEmailTB.Text = listView1.SelectedItems[0].SubItems[1].Text;
                ePasswordTB.Text = listView1.SelectedItems[0].SubItems[2].Text;
                eFirstNameTB.Text = listView1.SelectedItems[0].SubItems[3].Text;
                eLastNameTB.Text = listView1.SelectedItems[0].SubItems[4].Text;
                if (listView1.SelectedItems[0].SubItems[5].Text == "Satış Ofisi")
                {
                    eRankCB.SelectedIndex = 0;
                }
                else
                {
                    eRankCB.SelectedIndex = 1;
                }
            }
            catch
            {
                ClearAreas();
                eTCTB.Text = "";
            }
        }

        private void eTCTB_TextChanged(object sender, EventArgs e)
        {
            ClearAreas();
        }
    }
}
