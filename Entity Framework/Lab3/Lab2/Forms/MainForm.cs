using Lab2.Forms;
using Lab2.Models;
using Lab2.Repositories;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private CustomerRepository customerRepository = new CustomerRepository();
        private GenreRepository genreRepository = new GenreRepository();
        private MovieRepository movieRepository = new MovieRepository();
        private RentalRepository rentalRepository = new RentalRepository();
        int RowIndex;

        public MainForm()
        {
            InitializeComponent();
            CustomersGridView.DataSource = customerRepository.GetAll();
            UpdateCustomerButton.Hide();
            DeleteCustomerButton.Hide();
        }

        private void RentalsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesButton.BackColor = Color.LightCoral;
            MoviesButton.ForeColor = Color.White;
            GenresButton.BackColor = Color.White;
            GenresButton.ForeColor = Color.LightCoral;
            CustomersButton.BackColor = Color.White;
            CustomersButton.ForeColor = Color.LightCoral;
            RentalsButton.BackColor = Color.White;
            RentalsButton.ForeColor = Color.LightCoral;

            MoviesPanel.BringToFront();

            UpdateMovieButton.Hide();
            DeleteMovieButton.Hide();
            MoviesGridView.DataSource = movieRepository.GetAll();
        }

        private void GenresButton_Click(object sender, EventArgs e)
        {
            GenresButton.BackColor = Color.LightCoral;
            GenresButton.ForeColor = Color.White;
            MoviesButton.BackColor = Color.White;
            MoviesButton.ForeColor = Color.LightCoral;
            CustomersButton.BackColor = Color.White;
            CustomersButton.ForeColor = Color.LightCoral;
            RentalsButton.BackColor = Color.White;
            RentalsButton.ForeColor = Color.LightCoral;

            GenresPanel.BringToFront();

            UpdateGenreButton.Hide();
            DeleteGenreButton.Hide();

            GenresGridView.DataSource = genreRepository.GetAll();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersButton.BackColor = Color.LightCoral;
            CustomersButton.ForeColor = Color.White;
            MoviesButton.BackColor = Color.White;
            MoviesButton.ForeColor = Color.LightCoral;
            GenresButton.BackColor = Color.White;
            GenresButton.ForeColor = Color.LightCoral;
            RentalsButton.BackColor = Color.White;
            RentalsButton.ForeColor = Color.LightCoral;

            CustomersPanel.BringToFront();

            UpdateCustomerButton.Hide();
            DeleteCustomerButton.Hide();

            CustomersGridView.DataSource = customerRepository.GetAll();
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            RentalsButton.BackColor = Color.LightCoral;
            RentalsButton.ForeColor = Color.White;
            MoviesButton.BackColor = Color.White;
            MoviesButton.ForeColor = Color.LightCoral;
            GenresButton.BackColor = Color.White;
            GenresButton.ForeColor = Color.LightCoral;
            CustomersButton.BackColor = Color.White;
            CustomersButton.ForeColor = Color.LightCoral;

            RentalsPanel.BringToFront();

            UpdateRentalButton.Hide();
            DeleteRentalButton.Hide();
            RentalsGridView.DataSource = rentalRepository.GetAll();

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddUpdateCustomerForm addCustomerForm = new AddUpdateCustomerForm(FormMode.Add);
            addCustomerForm.ShowDialog();
            CustomersGridView.DataSource = customerRepository.GetAll();
            UpdateCustomerButton.Hide();
            DeleteCustomerButton.Hide();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)CustomersGridView.Rows[RowIndex].DataBoundItem;
            AddUpdateCustomerForm addCustomerForm = new AddUpdateCustomerForm(FormMode.Update, customer);
            addCustomerForm.ShowDialog();

            CustomersGridView.DataSource = customerRepository.GetAll();
            UpdateCustomerButton.Hide();
            DeleteCustomerButton.Hide();
        }

        private void CustomersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;
                UpdateCustomerButton.Show();
                DeleteCustomerButton.Show();
            }
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)CustomersGridView.Rows[RowIndex].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete customer {customer.Name}?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                customerRepository.Delete(customer);
                CustomersGridView.DataSource = customerRepository.GetAll();
                UpdateCustomerButton.Hide();
                DeleteCustomerButton.Hide();
            }

        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            AddUpdateGenreForm addGenreForm = new AddUpdateGenreForm(FormMode.Add);
            addGenreForm.ShowDialog();
            GenresGridView.DataSource = genreRepository.GetAll();
            UpdateGenreButton.Hide();
            DeleteGenreButton.Hide();
        }

        private void UpdateGenreButton_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)GenresGridView.Rows[RowIndex].DataBoundItem;
            AddUpdateGenreForm addGenreForm = new AddUpdateGenreForm(FormMode.Update, genre);
            addGenreForm.ShowDialog();

            GenresGridView.DataSource = genreRepository.GetAll();
            UpdateGenreButton.Hide();
            DeleteGenreButton.Hide();
        }

        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)GenresGridView.Rows[RowIndex].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete genre {genre.Name}?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                genreRepository.Delete(genre);
                GenresGridView.DataSource = genreRepository.GetAll();
                UpdateGenreButton.Hide();
                DeleteGenreButton.Hide();
            }
        }

        private void GenresGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;
                UpdateGenreButton.Show();
                DeleteGenreButton.Show();
            }
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            AddUpdateMovieForm addMovieForm = new AddUpdateMovieForm(FormMode.Add);
            addMovieForm.ShowDialog();
            MoviesGridView.DataSource = movieRepository.GetAll();
            UpdateMovieButton.Hide();
            DeleteMovieButton.Hide();
        }

        private void UpdateMovieButton_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MoviesGridView.Rows[RowIndex].DataBoundItem;
            AddUpdateMovieForm addMovieForm = new AddUpdateMovieForm(FormMode.Update, movie);
            addMovieForm.ShowDialog();

            MoviesGridView.DataSource = movieRepository.GetAll();
            UpdateMovieButton.Hide();
            DeleteMovieButton.Hide();
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MoviesGridView.Rows[RowIndex].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete movie {movie.Title}?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                movieRepository.Delete(movie);
                MoviesGridView.DataSource = movieRepository.GetAll();
                UpdateMovieButton.Hide();
                DeleteMovieButton.Hide();
            }
        }

        private void MoviesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;
                UpdateMovieButton.Show();
                DeleteMovieButton.Show();
            }
        }
        private void RentalsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;
                UpdateRentalButton.Show();
                DeleteRentalButton.Show();
            }
        }

        private void AddRentalButton_Click(object sender, EventArgs e)
        {
            AddUpdateRentalForm addRentalForm = new AddUpdateRentalForm(FormMode.Add);
            addRentalForm.ShowDialog();
            RentalsGridView.DataSource = rentalRepository.GetAll();
            UpdateRentalButton.Hide();
            DeleteRentalButton.Hide();
        }
        private void UpdateRentalButton_Click(object sender, EventArgs e)
        {
            Rental rental = (Rental)RentalsGridView.Rows[RowIndex].DataBoundItem;
            AddUpdateRentalForm addRentalForm = new AddUpdateRentalForm(FormMode.Update, rental);
            addRentalForm.ShowDialog();
            RentalsGridView.DataSource = rentalRepository.GetAll();
            UpdateRentalButton.Hide();
            DeleteRentalButton.Hide();
        }
        private void DeleteRentalButton_Click(object sender, EventArgs e)
        {
            Rental rental = (Rental)RentalsGridView.Rows[RowIndex].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete this rental?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                rentalRepository.Delete(rental);
                RentalsGridView.DataSource = rentalRepository.GetAll();
                UpdateRentalButton.Hide();
                DeleteRentalButton.Hide();
            }
        }
    }
}
