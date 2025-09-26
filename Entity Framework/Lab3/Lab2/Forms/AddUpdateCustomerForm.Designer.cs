namespace Lab2.Forms
{
    partial class AddUpdateCustomerForm
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
            NameTextBox = new TextBox();
            UpdateButton = new Button();
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(321, 60);
            label1.TabIndex = 0;
            label1.Text = "Add Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(214, 116);
            label2.Name = "label2";
            label2.Size = new Size(95, 38);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(93, 173);
            label3.Name = "label3";
            label3.Size = new Size(216, 38);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(214, 230);
            label4.Name = "label4";
            label4.Size = new Size(89, 38);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightCoral;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(174, 315);
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
            ClearButton.Location = new Point(533, 315);
            ClearButton.Margin = new Padding(10);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(135, 51);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(354, 116);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(371, 38);
            NameTextBox.TabIndex = 6;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.LightCoral;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(354, 315);
            UpdateButton.Margin = new Padding(10);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(135, 51);
            UpdateButton.TabIndex = 11;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumberTextBox.Location = new Point(354, 175);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(371, 38);
            PhoneNumberTextBox.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.Location = new Point(354, 230);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(371, 38);
            EmailTextBox.TabIndex = 14;
            // 
            // AddUpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 405);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(UpdateButton);
            Controls.Add(NameTextBox);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateCustomerForm";
            Text = "Add Customer";
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
        private TextBox NameTextBox;
        private Button UpdateButton;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
    }
}