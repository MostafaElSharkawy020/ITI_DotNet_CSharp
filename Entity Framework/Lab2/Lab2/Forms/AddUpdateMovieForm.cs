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
    public partial class AddUpdateMovieForm : Form
    {
        MovieRepository movieRepository = new MovieRepository();
        GenreRepository genreRepository = new GenreRepository();
        Movie movie;
        public AddUpdateMovieForm(FormMode formMode)
        {
            InitializeComponent();
            if (formMode == FormMode.Add)
            {
                this.Text = "Add Movie";
                label1.Text = "Add Movie";
                AddButton.Show();
                UpdateButton.Hide();
            }
            else if (formMode == FormMode.Update)
            {
                this.Text = "Update Movie";
                label1.Text = "Update Movie";
                AddButton.Hide();
                UpdateButton.Show();
            }
            var genres = genreRepository.GetAll().ToList();
            GenreComboBox.DataSource = genres;
            GenreComboBox.DisplayMember = "Name";
            GenreComboBox.ValueMember = "Id";
        }
        public AddUpdateMovieForm(FormMode formMode, Movie movie) : this(formMode)
        {
            this.movie = movie;
            TitleTextBox.Text = movie.Title;
            ReleaseDatePicker.Value = movie.ReleaseDate.ToDateTime(new TimeOnly(0, 0));
            AvailableCopiesNumericUpDown.Value = movie.AvailableCopies;
            var genres = genreRepository.GetAll().ToList();
            GenreComboBox.DataSource = genres;
            GenreComboBox.DisplayMember = "Name";
            GenreComboBox.ValueMember = "Id";
            GenreComboBox.SelectedValue = movie.GenreId;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) ||
                ReleaseDatePicker.Value == null ||
                AvailableCopiesNumericUpDown.Value <= 0||
                GenreComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var movie = new Movie
            {
                Title = TitleTextBox.Text,
                ReleaseDate = DateOnly.FromDateTime(ReleaseDatePicker.Value),
                AvailableCopies = (int)AvailableCopiesNumericUpDown.Value,
                GenreId = (int)GenreComboBox.SelectedValue
            };
            movieRepository.Add(movie);

            MessageBox.Show("Movie added successfully!");
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) ||
                 ReleaseDatePicker.Value == null ||
                 AvailableCopiesNumericUpDown.Value <= 0 ||
                 GenreComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            movie.Title = TitleTextBox.Text;
            movie.ReleaseDate = DateOnly.FromDateTime(ReleaseDatePicker.Value);
            movie.AvailableCopies = (int)AvailableCopiesNumericUpDown.Value;
            movie.GenreId = (int)GenreComboBox.SelectedValue;
            movieRepository.Update();
            MessageBox.Show("Movie updated successfully!");
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.Clear();
            AvailableCopiesNumericUpDown.Value = 0;
            ReleaseDatePicker.Value = DateTime.Now;
            GenreComboBox.SelectedItem = null;
        }
    }
}
