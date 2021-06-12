using System;
using System.Windows.Forms;

namespace StockExchange
{
    
    public partial class userSettings : Form
    {
        Customer customer;
        DataBase data = DataBase.database();
        public userSettings(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
            customer=data.GetCustomerbyID(customer.CustomerID);
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtAdress.Text = customer.Adress;
            txtUsername.Text = customer.Username;
            txtPassword.Text = customer.Password;         
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            Customer newc = new Customer(txtName.Text, txtAdress.Text, customer.Email, txtUsername.Text, txtPassword.Text);
            if (txtAdress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                if (customer.Username != newc.Username)
                {

                        data.updateCustomer(customer.CustomerID, newc.Name, newc.Username, newc.Password, newc.Email, newc.Adress);
                        MessageBox.Show("Update Succeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    data.updateCustomer(customer.CustomerID, newc.Name, newc.Username, newc.Password, newc.Email, newc.Adress);
                    MessageBox.Show("Update Succeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Texts can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
