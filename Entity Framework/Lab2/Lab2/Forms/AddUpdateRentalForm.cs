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

namespace Lab2.Forms
{
    public partial class AddUpdateRentalForm : Form
    {
        MovieRepository movieRepository = new MovieRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        RentalRepository rentalRepository = new RentalRepository();
        Rental rental;
        public AddUpdateRentalForm(FormMode formMode)
        {
            InitializeComponent();
            if (formMode == FormMode.Add)
            {
                this.Text = "Add Rental";
                label1.Text = "Add Rental";
                AddButton.Show();
                UpdateButton.Hide();
            }
            else if (formMode == FormMode.Update)
            {
                this.Text = "Update Rental";
                label1.Text = "Update Rental";
                AddButton.Hide();
                UpdateButton.Show();
            }
            var movies = movieRepository.GetAll().ToList();
            MovieNameComboBox.DataSource = movies;
            MovieNameComboBox.DisplayMember = "Title";
            MovieNameComboBox.ValueMember = "Id";

            var customers = customerRepository.GetAll().ToList();
            CustomerNameComboBox.DataSource = customers;
            CustomerNameComboBox.DisplayMember = "Name";
            CustomerNameComboBox.ValueMember = "Id";
        }
        public AddUpdateRentalForm(FormMode formMode, Rental rental) : this(formMode)
        {
            this.rental = rental;
            
            RentalDatePicker.Value = rental.RentalDate.ToDateTime(new TimeOnly(0, 0));
            ReturnDatePicker.Value = rental.ReturnDate.ToDateTime(new TimeOnly(0, 0));

            var movies = movieRepository.GetAll().ToList();
            MovieNameComboBox.DataSource = movies;
            MovieNameComboBox.DisplayMember = "Title";
            MovieNameComboBox.ValueMember = "Id";

            var customers = customerRepository.GetAll().ToList();
            CustomerNameComboBox.DataSource = customers;
            CustomerNameComboBox.DisplayMember = "Name";
            CustomerNameComboBox.ValueMember = "Id";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (
                RentalDatePicker.Value == null ||
                ReturnDatePicker.Value == null ||
                MovieNameComboBox.SelectedItem == null||
                CustomerNameComboBox.SelectedItem == null
                )
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rental = new Rental
            {
                    RentalDate = DateOnly.FromDateTime(RentalDatePicker.Value),
                    ReturnDate = DateOnly.FromDateTime(RentalDatePicker.Value),
                    MovieId = (int)MovieNameComboBox.SelectedValue,
                    CustomerId = (int)CustomerNameComboBox.SelectedValue
            };
            rentalRepository.Add(rental);

            MessageBox.Show("Rental added successfully!");
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (
                RentalDatePicker.Value == null ||
                ReturnDatePicker.Value == null ||
                MovieNameComboBox.SelectedItem == null ||
                CustomerNameComboBox.SelectedItem == null
                )
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rental.RentalDate = DateOnly.FromDateTime(RentalDatePicker.Value);
            rental.ReturnDate = DateOnly.FromDateTime(RentalDatePicker.Value);
            rental.MovieId = (int)MovieNameComboBox.SelectedValue;
            rental.CustomerId = (int)CustomerNameComboBox.SelectedValue;
            rentalRepository.Update();
            MessageBox.Show("Rental updated successfully!");
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RentalDatePicker.Value = DateTime.Now;
            ReturnDatePicker.Value = DateTime.Now;
            MovieNameComboBox.SelectedItem = null;
            CustomerNameComboBox.SelectedItem = null;
        }
    }
}
