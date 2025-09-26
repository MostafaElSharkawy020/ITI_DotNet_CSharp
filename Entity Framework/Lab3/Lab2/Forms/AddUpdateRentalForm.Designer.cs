namespace Lab2.Forms
{
    partial class AddUpdateRentalForm
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
            UpdateButton = new Button();
            label5 = new Label();
            RentalDatePicker = new DateTimePicker();
            ClearButton = new Button();
            AddButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomerNameComboBox = new ComboBox();
            MovieNameComboBox = new ComboBox();
            ReturnDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.LightCoral;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(354, 384);
            UpdateButton.Margin = new Padding(10);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(135, 51);
            UpdateButton.TabIndex = 23;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(135, 282);
            label5.Name = "label5";
            label5.Size = new Size(175, 38);
            label5.TabIndex = 21;
            label5.Text = "Return Date";
            // 
            // RentalDatePicker
            // 
            RentalDatePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RentalDatePicker.Location = new Point(354, 226);
            RentalDatePicker.Name = "RentalDatePicker";
            RentalDatePicker.Size = new Size(371, 38);
            RentalDatePicker.TabIndex = 20;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(534, 384);
            ClearButton.Margin = new Padding(10);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(135, 51);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightCoral;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(174, 384);
            AddButton.Margin = new Padding(10);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(135, 51);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(139, 226);
            label4.Name = "label4";
            label4.Size = new Size(170, 38);
            label4.TabIndex = 16;
            label4.Text = "Rental Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(125, 170);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 15;
            label3.Text = "Movie Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 112);
            label2.Name = "label2";
            label2.Size = new Size(229, 38);
            label2.TabIndex = 14;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 60);
            label1.TabIndex = 13;
            label1.Text = "Add Rental";
            // 
            // CustomerNameComboBox
            // 
            CustomerNameComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerNameComboBox.FormattingEnabled = true;
            CustomerNameComboBox.Location = new Point(354, 111);
            CustomerNameComboBox.Name = "CustomerNameComboBox";
            CustomerNameComboBox.Size = new Size(371, 39);
            CustomerNameComboBox.TabIndex = 25;
            // 
            // MovieNameComboBox
            // 
            MovieNameComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MovieNameComboBox.FormattingEnabled = true;
            MovieNameComboBox.Location = new Point(354, 169);
            MovieNameComboBox.Name = "MovieNameComboBox";
            MovieNameComboBox.Size = new Size(371, 39);
            MovieNameComboBox.TabIndex = 26;
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnDatePicker.Location = new Point(354, 282);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(371, 38);
            ReturnDatePicker.TabIndex = 27;
            // 
            // AddUpdateRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 472);
            Controls.Add(ReturnDatePicker);
            Controls.Add(MovieNameComboBox);
            Controls.Add(CustomerNameComboBox);
            Controls.Add(UpdateButton);
            Controls.Add(label5);
            Controls.Add(RentalDatePicker);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateRentalForm";
            Text = "AddUpdateRentalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown AvailableCopiesNumericUpDown;
        private Button UpdateButton;
        private ComboBox GenreComboBox;
        private Label label5;
        private DateTimePicker RentalDatePicker;
        private TextBox CustomxtBox;
        private Button ClearButton;
        private Button AddButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CustomerNameComboBox;
        private ComboBox MovieNameComboBox;
        private DateTimePicker ReturnDatePicker;
    }
}