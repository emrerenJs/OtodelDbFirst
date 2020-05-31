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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        /*Fonksiyonlar*/
        public void GetCustomers(string customerID = "")
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            using (OtodelContext otodelContext = new OtodelContext())
            {
                var CustomerResult = from customers in otodelContext.Customers
                                     where customers.CustomerID.Contains(customerID)
                                     select customers;
                foreach (Customer customer in CustomerResult)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = customer.CustomerID;
                    listViewItem.SubItems.Add(customer.FirstName);
                    listViewItem.SubItems.Add(customer.LastName);
                    listViewItem.SubItems.Add(customer.Phone);
                    listViewItem.SubItems.Add(customer.Gender ? "Erkek" : "Kadın");
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        public void ClearAllObjects()
        {
            CFirstNameTB.Text = "";
            CLastNameTB.Text = "";
            CPhoneTB.Text = "";
            CGenderMRB.Checked = true;
        }
        /*Fonksiyonlar*/
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
            ClearAllObjects();
        }
        public bool EmptyControl()
        {
            if(
                CTCTB.Text.Trim() == "" ||
                CFirstNameTB.Text.Trim() == "" ||
                CLastNameTB.Text.Trim() == "" ||
                CPhoneTB.Text.Trim() == "" ||
                (!CGenderMRB.Checked && !CGenderFRB.Checked)
              )
            {
                return false;
            }
            return true;
        }
        private void CAddBT_Click(object sender, EventArgs e)
        {
            if (EmptyControl())
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    if (otodelContext.Customers.Find(CTCTB.Text.Trim()) == null)
                    {
                        otodelContext.Customers.Add(new Customer
                        {
                            CustomerID = CTCTB.Text,
                            FirstName = CFirstNameTB.Text,
                            LastName = CLastNameTB.Text,
                            Phone = CPhoneTB.Text,
                            Gender = CGenderMRB.Checked ? true : false
                        });
                        otodelContext.SaveChanges();
                        GetCustomers();
                        MessageBox.Show("Kayıt başarılı!");
                    }
                    else
                        MessageBox.Show("Bu TC Kimlik numarasında bir kayıt zaten oluşturulmuş!");
                }
            }
            else
                MessageBox.Show("Boş alan bırakmayınız!");
        }

        private void CUpdateBT_Click(object sender, EventArgs e)
        {
            if (EmptyControl())
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    Customer customer = otodelContext.Customers.Find(CTCTB.Text);
                    if (customer == null)
                        MessageBox.Show("Bu TC Kimlik numarasında bir kullanıcı bulunamadı!");
                    else
                    {
                        customer.FirstName = CFirstNameTB.Text;
                        customer.LastName = CLastNameTB.Text;
                        customer.Phone = CPhoneTB.Text;
                        customer.Gender = CGenderFRB.Checked ? false : true;
                        otodelContext.SaveChanges();
                        GetCustomers();
                        MessageBox.Show("Güncelleme başarılı!");
                    }
                }
            }
            else
                MessageBox.Show("Boş alan bırakmayınız!");
        }

        private void CDeleteBT_Click(object sender, EventArgs e)
        {
            if (CTCTB.Text.Trim() == "")
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcının TC Kimlik numarasını girin!");
            else
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    Customer customer = otodelContext.Customers.Find(CTCTB.Text);
                    if (customer == null)
                        MessageBox.Show("Bu TC Kimlik numarasında bir kullanıcı bulunamadı!");
                    else 
                    {
                        DialogResult dialogResult = MessageBox.Show(
                                String.Format("{0} TC Kimlik numaralı kişiyi silmek istiyor musunuz?",CTCTB.Text.Trim(),CFirstNameTB.Text, CLastNameTB.Text),
                                "Kullanıcı siliniyor!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );
                        if(dialogResult == DialogResult.Yes)
                        {
                            otodelContext.Customers.Remove(customer);
                            otodelContext.SaveChanges();
                            GetCustomers();
                            MessageBox.Show("Silme başarılı!");
                        }
                    }
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CTCTB.Text = listView1.SelectedItems[0].SubItems[0].Text;
                CFirstNameTB.Text = listView1.SelectedItems[0].SubItems[1].Text;
                CLastNameTB.Text = listView1.SelectedItems[0].SubItems[2].Text;
                CPhoneTB.Text = listView1.SelectedItems[0].SubItems[3].Text;
                if (listView1.SelectedItems[0].SubItems[4].Text == "Erkek")
                    CGenderMRB.Checked = true;
                else
                    CGenderFRB.Checked = true;
            }
            catch
            {
                ClearAllObjects();
            }
        }

        private void CTCTB_TextChanged(object sender, EventArgs e)
        {
            GetCustomers(CTCTB.Text.Trim());
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                using(OtodelContext otodelContext = new OtodelContext())
                {
                    Customer customer = otodelContext.Customers.Find(CTCTB.Text.Trim());
                    TicketForm ticketForm = new TicketForm(customer);
                    ticketForm.ShowDialog();
                }
            }
        }

        private void CTCTB_Click(object sender, EventArgs e)
        {
            ClearAllObjects();
            CTCTB.Text = "";
        }
    }
}
