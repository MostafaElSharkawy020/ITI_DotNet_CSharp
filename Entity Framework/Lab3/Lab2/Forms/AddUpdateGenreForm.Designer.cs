namespace Lab2.Forms
{
    partial class AddUpdateGenreForm
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
            NameTextBox = new TextBox();
            ClearButton = new Button();
            AddButton = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.LightCoral;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(354, 219);
            UpdateButton.Margin = new Padding(10);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(135, 51);
            UpdateButton.TabIndex = 23;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(354, 112);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(371, 38);
            NameTextBox.TabIndex = 19;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.LightCoral;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(535, 219);
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
            AddButton.Location = new Point(174, 219);
            AddButton.Margin = new Padding(10);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(135, 51);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(214, 112);
            label2.Name = "label2";
            label2.Size = new Size(95, 38);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 60);
            label1.TabIndex = 13;
            label1.Text = "Add Genre";
            // 
            // AddUpdateGenreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 289);
            Controls.Add(UpdateButton);
            Controls.Add(NameTextBox);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateGenreForm";
            Text = "AddUpdateGenreForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateButton;
        private TextBox NameTextBox;
        private Button ClearButton;
        private Button AddButton;
        private Label label2;
        private Label label1;
    }
}