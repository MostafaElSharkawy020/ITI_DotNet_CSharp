namespace Lab2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MoviesButton = new Button();
            TopBar = new FlowLayoutPanel();
            GenresButton = new Button();
            CustomersButton = new Button();
            RentalsButton = new Button();
            RentalsPanel = new Panel();
            RentalsGridView = new DataGridView();
            RentalsSideBar = new FlowLayoutPanel();
            AddRentalButton = new Button();
            UpdateRentalButton = new Button();
            DeleteRentalButton = new Button();
            GenresPanel = new Panel();
            GenresGridView = new DataGridView();
            GenresSideBar = new FlowLayoutPanel();
            AddGenreButton = new Button();
            UpdateGenreButton = new Button();
            DeleteGenreButton = new Button();
            MoviesPanel = new Panel();
            MoviesGridView = new DataGridView();
            MoviesSideBar = new FlowLayoutPanel();
            AddMovieButton = new Button();
            UpdateMovieButton = new Button();
            DeleteMovieButton = new Button();
            CustomersPanel = new Panel();
            CustomersGridView = new DataGridView();
            CustomersSideBar = new FlowLayoutPanel();
            AddCustomerButton = new Button();
            UpdateCustomerButton = new Button();
            DeleteCustomerButton = new Button();
            TopBar.SuspendLayout();
            RentalsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RentalsGridView).BeginInit();
            RentalsSideBar.SuspendLayout();
            GenresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GenresGridView).BeginInit();
            GenresSideBar.SuspendLayout();
            MoviesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviesGridView).BeginInit();
            MoviesSideBar.SuspendLayout();
            CustomersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).BeginInit();
            CustomersSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // MoviesButton
            // 
            MoviesButton.BackColor = Color.White;
            MoviesButton.FlatAppearance.BorderSize = 0;
            MoviesButton.FlatStyle = FlatStyle.Flat;
            MoviesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoviesButton.ForeColor = Color.LightCoral;
            MoviesButton.Location = new Point(20, 13);
            MoviesButton.Margin = new Padding(10, 3, 10, 3);
            MoviesButton.Name = "MoviesButton";
            MoviesButton.Size = new Size(200, 59);
            MoviesButton.TabIndex = 0;
            MoviesButton.Text = "Movies";
            MoviesButton.UseVisualStyleBackColor = false;
            MoviesButton.Click += MoviesButton_Click;
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.White;
            TopBar.Controls.Add(MoviesButton);
            TopBar.Controls.Add(GenresButton);
            TopBar.Controls.Add(CustomersButton);
            TopBar.Controls.Add(RentalsButton);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Padding = new Padding(10);
            TopBar.Size = new Size(1135, 85);
            TopBar.TabIndex = 1;
            // 
            // GenresButton
            // 
            GenresButton.BackColor = Color.White;
            GenresButton.FlatAppearance.BorderSize = 0;
            GenresButton.FlatStyle = FlatStyle.Flat;
            GenresButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenresButton.ForeColor = Color.LightCoral;
            GenresButton.Location = new Point(240, 13);
            GenresButton.Margin = new Padding(10, 3, 10, 3);
            GenresButton.Name = "GenresButton";
            GenresButton.Size = new Size(200, 59);
            GenresButton.TabIndex = 1;
            GenresButton.Text = "Genres";
            GenresButton.UseVisualStyleBackColor = false;
            GenresButton.Click += GenresButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.BackColor = Color.LightCoral;
            CustomersButton.FlatAppearance.BorderSize = 0;
            CustomersButton.FlatStyle = FlatStyle.Flat;
            CustomersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersButton.ForeColor = Color.White;
            CustomersButton.Location = new Point(460, 13);
            CustomersButton.Margin = new Padding(10, 3, 10, 3);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(200, 59);
            CustomersButton.TabIndex = 2;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // RentalsButton
            // 
            RentalsButton.BackColor = Color.White;
            RentalsButton.FlatAppearance.BorderSize = 0;
            RentalsButton.FlatStyle = FlatStyle.Flat;
            RentalsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalsButton.ForeColor = Color.LightCoral;
            RentalsButton.Location = new Point(680, 13);
            RentalsButton.Margin = new Padding(10, 3, 10, 3);
            RentalsButton.Name = "RentalsButton";
            RentalsButton.Size = new Size(200, 59);
            RentalsButton.TabIndex = 3;
            RentalsButton.Text = "Rentals";
            RentalsButton.UseVisualStyleBackColor = false;
            RentalsButton.Click += RentalsButton_Click;
            // 
            // RentalsPanel
            // 
            RentalsPanel.Controls.Add(RentalsGridView);
            RentalsPanel.Controls.Add(RentalsSideBar);
            RentalsPanel.Dock = DockStyle.Fill;
            RentalsPanel.Location = new Point(0, 85);
            RentalsPanel.Name = "RentalsPanel";
            RentalsPanel.Size = new Size(1135, 595);
            RentalsPanel.TabIndex = 2;
            RentalsPanel.Paint += RentalsPanel_Paint;
            // 
            // RentalsGridView
            // 
            RentalsGridView.AllowUserToAddRows = false;
            RentalsGridView.AllowUserToDeleteRows = false;
            RentalsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalsGridView.Dock = DockStyle.Fill;
            RentalsGridView.Location = new Point(0, 0);
            RentalsGridView.Name = "RentalsGridView";
            RentalsGridView.ReadOnly = true;
            RentalsGridView.RowHeadersWidth = 51;
            RentalsGridView.Size = new Size(951, 595);
            RentalsGridView.TabIndex = 2;
            RentalsGridView.CellClick += RentalsGridView_CellClick;
            // 
            // RentalsSideBar
            // 
            RentalsSideBar.AutoScroll = true;
            RentalsSideBar.BackColor = Color.White;
            RentalsSideBar.Controls.Add(AddRentalButton);
            RentalsSideBar.Controls.Add(UpdateRentalButton);
            RentalsSideBar.Controls.Add(DeleteRentalButton);
            RentalsSideBar.Dock = DockStyle.Right;
            RentalsSideBar.FlowDirection = FlowDirection.TopDown;
            RentalsSideBar.Location = new Point(951, 0);
            RentalsSideBar.Name = "RentalsSideBar";
            RentalsSideBar.Size = new Size(184, 595);
            RentalsSideBar.TabIndex = 1;
            // 
            // AddRentalButton
            // 
            AddRentalButton.BackColor = Color.LightCoral;
            AddRentalButton.FlatStyle = FlatStyle.Flat;
            AddRentalButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddRentalButton.ForeColor = Color.White;
            AddRentalButton.Location = new Point(10, 10);
            AddRentalButton.Margin = new Padding(10);
            AddRentalButton.Name = "AddRentalButton";
            AddRentalButton.Size = new Size(164, 90);
            AddRentalButton.TabIndex = 1;
            AddRentalButton.Text = "Add";
            AddRentalButton.UseVisualStyleBackColor = false;
            AddRentalButton.Click += AddRentalButton_Click;
            // 
            // UpdateRentalButton
            // 
            UpdateRentalButton.BackColor = Color.LightCoral;
            UpdateRentalButton.FlatStyle = FlatStyle.Flat;
            UpdateRentalButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateRentalButton.ForeColor = Color.White;
            UpdateRentalButton.Location = new Point(10, 120);
            UpdateRentalButton.Margin = new Padding(10);
            UpdateRentalButton.Name = "UpdateRentalButton";
            UpdateRentalButton.Size = new Size(164, 90);
            UpdateRentalButton.TabIndex = 2;
            UpdateRentalButton.Text = "Update";
            UpdateRentalButton.UseVisualStyleBackColor = false;
            UpdateRentalButton.Click += UpdateRentalButton_Click;
            // 
            // DeleteRentalButton
            // 
            DeleteRentalButton.BackColor = Color.LightCoral;
            DeleteRentalButton.FlatStyle = FlatStyle.Flat;
            DeleteRentalButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteRentalButton.ForeColor = Color.White;
            DeleteRentalButton.Location = new Point(10, 230);
            DeleteRentalButton.Margin = new Padding(10);
            DeleteRentalButton.Name = "DeleteRentalButton";
            DeleteRentalButton.Size = new Size(164, 90);
            DeleteRentalButton.TabIndex = 3;
            DeleteRentalButton.Text = "Delete";
            DeleteRentalButton.UseVisualStyleBackColor = false;
            DeleteRentalButton.Click += DeleteRentalButton_Click;
            // 
            // GenresPanel
            // 
            GenresPanel.Controls.Add(GenresGridView);
            GenresPanel.Controls.Add(GenresSideBar);
            GenresPanel.Dock = DockStyle.Fill;
            GenresPanel.Location = new Point(0, 85);
            GenresPanel.Name = "GenresPanel";
            GenresPanel.Size = new Size(1135, 595);
            GenresPanel.TabIndex = 3;
            // 
            // GenresGridView
            // 
            GenresGridView.AllowUserToAddRows = false;
            GenresGridView.AllowUserToDeleteRows = false;
            GenresGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GenresGridView.Dock = DockStyle.Fill;
            GenresGridView.Location = new Point(0, 0);
            GenresGridView.Name = "GenresGridView";
            GenresGridView.ReadOnly = true;
            GenresGridView.RowHeadersWidth = 51;
            GenresGridView.Size = new Size(951, 595);
            GenresGridView.TabIndex = 3;
            GenresGridView.CellContentClick += GenresGridView_CellContentClick;
            // 
            // GenresSideBar
            // 
            GenresSideBar.AutoScroll = true;
            GenresSideBar.BackColor = Color.White;
            GenresSideBar.Controls.Add(AddGenreButton);
            GenresSideBar.Controls.Add(UpdateGenreButton);
            GenresSideBar.Controls.Add(DeleteGenreButton);
            GenresSideBar.Dock = DockStyle.Right;
            GenresSideBar.FlowDirection = FlowDirection.TopDown;
            GenresSideBar.Location = new Point(951, 0);
            GenresSideBar.Name = "GenresSideBar";
            GenresSideBar.Size = new Size(184, 595);
            GenresSideBar.TabIndex = 1;
            // 
            // AddGenreButton
            // 
            AddGenreButton.BackColor = Color.LightCoral;
            AddGenreButton.FlatStyle = FlatStyle.Flat;
            AddGenreButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddGenreButton.ForeColor = Color.White;
            AddGenreButton.Location = new Point(10, 10);
            AddGenreButton.Margin = new Padding(10);
            AddGenreButton.Name = "AddGenreButton";
            AddGenreButton.Size = new Size(164, 90);
            AddGenreButton.TabIndex = 1;
            AddGenreButton.Text = "Add";
            AddGenreButton.UseVisualStyleBackColor = false;
            AddGenreButton.Click += AddGenreButton_Click;
            // 
            // UpdateGenreButton
            // 
            UpdateGenreButton.BackColor = Color.LightCoral;
            UpdateGenreButton.FlatStyle = FlatStyle.Flat;
            UpdateGenreButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateGenreButton.ForeColor = Color.White;
            UpdateGenreButton.Location = new Point(10, 120);
            UpdateGenreButton.Margin = new Padding(10);
            UpdateGenreButton.Name = "UpdateGenreButton";
            UpdateGenreButton.Size = new Size(164, 90);
            UpdateGenreButton.TabIndex = 2;
            UpdateGenreButton.Text = "Update";
            UpdateGenreButton.UseVisualStyleBackColor = false;
            UpdateGenreButton.Click += UpdateGenreButton_Click;
            // 
            // DeleteGenreButton
            // 
            DeleteGenreButton.BackColor = Color.LightCoral;
            DeleteGenreButton.FlatStyle = FlatStyle.Flat;
            DeleteGenreButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteGenreButton.ForeColor = Color.White;
            DeleteGenreButton.Location = new Point(10, 230);
            DeleteGenreButton.Margin = new Padding(10);
            DeleteGenreButton.Name = "DeleteGenreButton";
            DeleteGenreButton.Size = new Size(164, 90);
            DeleteGenreButton.TabIndex = 3;
            DeleteGenreButton.Text = "Delete";
            DeleteGenreButton.UseVisualStyleBackColor = false;
            DeleteGenreButton.Click += DeleteGenreButton_Click;
            // 
            // MoviesPanel
            // 
            MoviesPanel.Controls.Add(MoviesGridView);
            MoviesPanel.Controls.Add(MoviesSideBar);
            MoviesPanel.Dock = DockStyle.Fill;
            MoviesPanel.Location = new Point(0, 85);
            MoviesPanel.Name = "MoviesPanel";
            MoviesPanel.Size = new Size(1135, 595);
            MoviesPanel.TabIndex = 3;
            // 
            // MoviesGridView
            // 
            MoviesGridView.AllowUserToAddRows = false;
            MoviesGridView.AllowUserToDeleteRows = false;
            MoviesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MoviesGridView.Dock = DockStyle.Fill;
            MoviesGridView.Location = new Point(0, 0);
            MoviesGridView.Name = "MoviesGridView";
            MoviesGridView.ReadOnly = true;
            MoviesGridView.RowHeadersWidth = 51;
            MoviesGridView.Size = new Size(951, 595);
            MoviesGridView.TabIndex = 3;
            MoviesGridView.CellClick += MoviesGridView_CellClick;
            // 
            // MoviesSideBar
            // 
            MoviesSideBar.AutoScroll = true;
            MoviesSideBar.BackColor = Color.White;
            MoviesSideBar.Controls.Add(AddMovieButton);
            MoviesSideBar.Controls.Add(UpdateMovieButton);
            MoviesSideBar.Controls.Add(DeleteMovieButton);
            MoviesSideBar.Dock = DockStyle.Right;
            MoviesSideBar.FlowDirection = FlowDirection.TopDown;
            MoviesSideBar.Location = new Point(951, 0);
            MoviesSideBar.Name = "MoviesSideBar";
            MoviesSideBar.Size = new Size(184, 595);
            MoviesSideBar.TabIndex = 1;
            // 
            // AddMovieButton
            // 
            AddMovieButton.BackColor = Color.LightCoral;
            AddMovieButton.FlatStyle = FlatStyle.Flat;
            AddMovieButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMovieButton.ForeColor = Color.White;
            AddMovieButton.Location = new Point(10, 10);
            AddMovieButton.Margin = new Padding(10);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(164, 90);
            AddMovieButton.TabIndex = 1;
            AddMovieButton.Text = "Add";
            AddMovieButton.UseVisualStyleBackColor = false;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // UpdateMovieButton
            // 
            UpdateMovieButton.BackColor = Color.LightCoral;
            UpdateMovieButton.FlatStyle = FlatStyle.Flat;
            UpdateMovieButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMovieButton.ForeColor = Color.White;
            UpdateMovieButton.Location = new Point(10, 120);
            UpdateMovieButton.Margin = new Padding(10);
            UpdateMovieButton.Name = "UpdateMovieButton";
            UpdateMovieButton.Size = new Size(164, 90);
            UpdateMovieButton.TabIndex = 2;
            UpdateMovieButton.Text = "Update";
            UpdateMovieButton.UseVisualStyleBackColor = false;
            UpdateMovieButton.Click += UpdateMovieButton_Click;
            // 
            // DeleteMovieButton
            // 
            DeleteMovieButton.BackColor = Color.LightCoral;
            DeleteMovieButton.FlatStyle = FlatStyle.Flat;
            DeleteMovieButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteMovieButton.ForeColor = Color.White;
            DeleteMovieButton.Location = new Point(10, 230);
            DeleteMovieButton.Margin = new Padding(10);
            DeleteMovieButton.Name = "DeleteMovieButton";
            DeleteMovieButton.Size = new Size(164, 90);
            DeleteMovieButton.TabIndex = 3;
            DeleteMovieButton.Text = "Delete";
            DeleteMovieButton.UseVisualStyleBackColor = false;
            DeleteMovieButton.Click += DeleteMovieButton_Click;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Controls.Add(CustomersGridView);
            CustomersPanel.Controls.Add(CustomersSideBar);
            CustomersPanel.Dock = DockStyle.Fill;
            CustomersPanel.Location = new Point(0, 85);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(1135, 595);
            CustomersPanel.TabIndex = 3;
            // 
            // CustomersGridView
            // 
            CustomersGridView.AllowUserToAddRows = false;
            CustomersGridView.AllowUserToDeleteRows = false;
            CustomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGridView.Dock = DockStyle.Fill;
            CustomersGridView.Location = new Point(0, 0);
            CustomersGridView.Name = "CustomersGridView";
            CustomersGridView.ReadOnly = true;
            CustomersGridView.RowHeadersWidth = 51;
            CustomersGridView.Size = new Size(951, 595);
            CustomersGridView.TabIndex = 3;
            CustomersGridView.CellClick += CustomersGridView_CellClick;
            // 
            // CustomersSideBar
            // 
            CustomersSideBar.AutoScroll = true;
            CustomersSideBar.BackColor = Color.White;
            CustomersSideBar.Controls.Add(AddCustomerButton);
            CustomersSideBar.Controls.Add(UpdateCustomerButton);
            CustomersSideBar.Controls.Add(DeleteCustomerButton);
            CustomersSideBar.Dock = DockStyle.Right;
            CustomersSideBar.FlowDirection = FlowDirection.TopDown;
            CustomersSideBar.Location = new Point(951, 0);
            CustomersSideBar.Name = "CustomersSideBar";
            CustomersSideBar.Size = new Size(184, 595);
            CustomersSideBar.TabIndex = 0;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.BackColor = Color.LightCoral;
            AddCustomerButton.FlatStyle = FlatStyle.Flat;
            AddCustomerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustomerButton.ForeColor = Color.White;
            AddCustomerButton.Location = new Point(10, 10);
            AddCustomerButton.Margin = new Padding(10);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(164, 90);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // UpdateCustomerButton
            // 
            UpdateCustomerButton.BackColor = Color.LightCoral;
            UpdateCustomerButton.FlatStyle = FlatStyle.Flat;
            UpdateCustomerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateCustomerButton.ForeColor = Color.White;
            UpdateCustomerButton.Location = new Point(10, 120);
            UpdateCustomerButton.Margin = new Padding(10);
            UpdateCustomerButton.Name = "UpdateCustomerButton";
            UpdateCustomerButton.Size = new Size(164, 90);
            UpdateCustomerButton.TabIndex = 2;
            UpdateCustomerButton.Text = "Update";
            UpdateCustomerButton.UseVisualStyleBackColor = false;
            UpdateCustomerButton.Click += UpdateCustomerButton_Click;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.BackColor = Color.LightCoral;
            DeleteCustomerButton.FlatStyle = FlatStyle.Flat;
            DeleteCustomerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCustomerButton.ForeColor = Color.White;
            DeleteCustomerButton.Location = new Point(10, 230);
            DeleteCustomerButton.Margin = new Padding(10);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(164, 90);
            DeleteCustomerButton.TabIndex = 3;
            DeleteCustomerButton.Text = "Delete";
            DeleteCustomerButton.UseVisualStyleBackColor = false;
            DeleteCustomerButton.Click += DeleteCustomerButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 680);
            Controls.Add(CustomersPanel);
            Controls.Add(RentalsPanel);
            Controls.Add(MoviesPanel);
            Controls.Add(GenresPanel);
            Controls.Add(TopBar);
            Name = "MainForm";
            Text = "Movie Rental System";
            TopBar.ResumeLayout(false);
            RentalsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RentalsGridView).EndInit();
            RentalsSideBar.ResumeLayout(false);
            GenresPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GenresGridView).EndInit();
            GenresSideBar.ResumeLayout(false);
            MoviesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MoviesGridView).EndInit();
            MoviesSideBar.ResumeLayout(false);
            CustomersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).EndInit();
            CustomersSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button MoviesButton;
        private FlowLayoutPanel TopBar;
        private Button GenresButton;
        private Button CustomersButton;
        private Button RentalsButton;
        private Panel RentalsPanel;
        private Panel GenresPanel;
        private Panel MoviesPanel;
        private Panel CustomersPanel;
        private FlowLayoutPanel CustomersSideBar;
        private Button AddCustomerButton;
        private Button UpdateCustomerButton;
        private Button DeleteCustomerButton;
        private FlowLayoutPanel GenresSideBar;
        private Button AddGenreButton;
        private Button UpdateGenreButton;
        private Button DeleteGenreButton;
        private FlowLayoutPanel MoviesSideBar;
        private Button AddMovieButton;
        private Button UpdateMovieButton;
        private Button DeleteMovieButton;
        private FlowLayoutPanel RentalsSideBar;
        private Button AddRentalButton;
        private Button UpdateRentalButton;
        private Button DeleteRentalButton;
        private DataGridView RentalsGridView;
        private DataGridView GenresGridView;
        private DataGridView MoviesGridView;
        private DataGridView CustomersGridView;
    }
}
