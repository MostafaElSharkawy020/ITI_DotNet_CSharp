using Lab2.Models;
using Lab2.Repositories;
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

namespace Lab2.Forms
{
    public enum FormMode
    {
        Add,
        Update
    }
    public partial class AddUpdateCustomerForm : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();
        Customer customer;
        public AddUpdateCustomerForm(FormMode formMode)
        {
            InitializeComponent();
            if (formMode == FormMode.Add)
            {
                this.Text = "Add Customer";
                label1.Text = "Add Customer";
                AddButton.Show();
                UpdateButton.Hide();
            }
            else if (formMode == FormMode.Update)
            {
                this.Text = "Update Customer";
                label1.Text = "Update Customer";
                AddButton.Hide();
                UpdateButton.Show();
            }
        }
        public AddUpdateCustomerForm(FormMode formMode, Customer customer) : this(formMode)
        {
            this.customer = customer;
            NameTextBox.Text = customer.Name;
            EmailTextBox.Text = customer.Email;
            PhoneNumberTextBox.Text = customer.PhoneNumber;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CustomerRepository.ValidateEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CustomerRepository.ValidatePhone(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Please enter a valid phone number!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = new Customer
            {
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text
            };
            customerRepository.Add(customer);

            MessageBox.Show("Customer added successfully!");
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CustomerRepository.ValidateEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CustomerRepository.ValidatePhone(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Please enter a valid phone number!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customer.Email = EmailTextBox.Text;
            customer.Name = NameTextBox.Text;
            customer.PhoneNumber = PhoneNumberTextBox.Text;
            customerRepository.Update();
            MessageBox.Show("Customer updated successfully!");
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
        }
    }
}
