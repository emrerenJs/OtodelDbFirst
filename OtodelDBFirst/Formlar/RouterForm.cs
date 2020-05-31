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
    public partial class RouterForm : Form
    {
        private Employee employee;
        public RouterForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void RouterForm_Load(object sender, EventArgs e)
        {

        }

        private void routerCloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimalizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BusesBTN_Click(object sender, EventArgs e)
        {
            if(this.employee.EmployeeRank.ToString() == "Gelistirici" || this.employee.EmployeeRank.ToString() == "Müdür")
            {
                BusForm busForm = new BusForm();
                busForm.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Buraya erişmeye yetkiniz yok..");
            }
        }

        private void ExpeditionsBTN_Click(object sender, EventArgs e)
        {
            if (this.employee.EmployeeRank.ToString() == "Gelistirici" || this.employee.EmployeeRank.ToString() == "Yönetici")
            {
                ExpeditionForm expeditionForm = new ExpeditionForm();
                expeditionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Buraya erişmeye yetkiniz yok..");
            }
        }

        private void TicketsBTN_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.employee.EmployeeRank.ToString() == "Gelistirici" || this.employee.EmployeeRank.ToString() == "Yönetici")
            {
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Buraya erişmeye yetkiniz yok..");
            }
        }
    }
}
