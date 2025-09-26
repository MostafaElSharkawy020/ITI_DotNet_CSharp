namespace Lab2.Forms
{
    partial class AddUpdateMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddButton = new Button();
            ClearButton = new Button();
            TitleTextBox = new TextBox();
            ReleaseDatePicker = new DateTimePicker();
            label5 = new Label();
            GenreComboBox = new ComboBox();
            UpdateButton = new Button();
            AvailableCopiesNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AvailableCopiesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(252, 60);
            label1.TabIndex = 0;
            label1.Text = "Add Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(234, 116);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(125, 174);
            label3.Name = "label3";
            label3.Size = new Size(184, 38);
            label3.TabIndex = 2;
            label3.Text = "Release Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(78, 230);
            label4.Name = "label4";
            label4.Size = new Size(231, 38);
            label4.TabIndex = 3;
            label4.Text = "Available Copies";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightCoral;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(174, 388);
            AddButton.Margin = new Padding(10);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(135, 51);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(534, 388);
            ClearButton.Margin = new Padding(10);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(135, 51);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleTextBox.Location = new Point(354, 116);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(371, 38);
            TitleTextBox.TabIndex = 6;
            // 
            // ReleaseDatePicker
            // 
            ReleaseDatePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReleaseDatePicker.Location = new Point(354, 173);
            ReleaseDatePicker.Name = "ReleaseDatePicker";
            ReleaseDatePicker.Size = new Size(371, 38);
            ReleaseDatePicker.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(214, 286);
            label5.Name = "label5";
            label5.Size = new Size(95, 38);
            label5.TabIndex = 9;
            label5.Text = "Genre";
            // 
            // GenreComboBox
            // 
            GenreComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(354, 288);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(371, 39);
            GenreComboBox.TabIndex = 10;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.LightCoral;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(354, 388);
            UpdateButton.Margin = new Padding(10);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(135, 51);
            UpdateButton.TabIndex = 11;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AvailableCopiesNumericUpDown
            // 
            AvailableCopiesNumericUpDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableCopiesNumericUpDown.Location = new Point(354, 230);
            AvailableCopiesNumericUpDown.Name = "AvailableCopiesNumericUpDown";
            AvailableCopiesNumericUpDown.Size = new Size(371, 38);
            AvailableCopiesNumericUpDown.TabIndex = 12;
            // 
            // AddUpdateMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 472);
            Controls.Add(AvailableCopiesNumericUpDown);
            Controls.Add(UpdateButton);
            Controls.Add(GenreComboBox);
            Controls.Add(label5);
            Controls.Add(ReleaseDatePicker);
            Controls.Add(TitleTextBox);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateMovieForm";
            Text = "AddMovieForm";
            ((System.ComponentModel.ISupportInitialize)AvailableCopiesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddButton;
        private Button ClearButton;
        private TextBox TitleTextBox;
        private DateTimePicker ReleaseDatePicker;
        private Label label5;
        private ComboBox GenreComboBox;
        private Button UpdateButton;
        private NumericUpDown AvailableCopiesNumericUpDown;
    }
}