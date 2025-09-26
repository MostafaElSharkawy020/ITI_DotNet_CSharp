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
    public partial class AddUpdateGenreForm : Form
    {
        GenreRepository genreRepository = new GenreRepository();
        Genre genre;
        public AddUpdateGenreForm(FormMode formMode)
        {
            InitializeComponent();
            if (formMode == FormMode.Add)
            {
                this.Text = "Add Genre";
                label1.Text = "Add Genre";
                AddButton.Show();
                UpdateButton.Hide();
            }
            else if (formMode == FormMode.Update)
            {
                this.Text = "Update Genre";
                label1.Text = "Update Genre";
                AddButton.Hide();
                UpdateButton.Show();
            }
        }
        public AddUpdateGenreForm(FormMode formMode, Genre genre) : this(formMode)
        {
            this.genre = genre;
            NameTextBox.Text = genre.Name;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var genre = new Genre
            {
                Name = NameTextBox.Text,
            };
            genreRepository.Add(genre);

            MessageBox.Show("Genre added successfully!");
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            genre.Name = NameTextBox.Text;
            genreRepository.Update();
            MessageBox.Show("Genre updated successfully!");
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
        }
    }
}
