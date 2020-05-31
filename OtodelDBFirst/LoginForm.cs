using OtodelDBFirst.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodelDBFirst
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (OtodelContext otodelContext = new OtodelContext())
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                var Result = from employee in otodelContext.Employees
                             select employee;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OtodelContext otodelContext = new OtodelContext())
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                var Result = from employee in otodelContext.Employees
                             where employee.EmployeeMail == username && employee.Password == password
                             select employee;
                if (Result.Count() > 0)
                {
                    Employee employee = Result.First();
                    RouterForm routerForm = new RouterForm(employee);
                    this.Hide();
                    routerForm.Show();
                }
                else
                {
                    MessageBox.Show("Çalışan bulunamadı!");
                }
            }
        }
    }
}
