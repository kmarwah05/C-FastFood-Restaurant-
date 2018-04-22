namespace FastFood
{
    partial class chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chef));
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodImage = new System.Windows.Forms.PictureBox();
            this.chefImage = new System.Windows.Forms.PictureBox();
            this.closePicture = new System.Windows.Forms.PictureBox();
            this.customerImage = new System.Windows.Forms.PictureBox();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeePhoneTextBox = new System.Windows.Forms.TextBox();
            this.employeePhoneLabel = new System.Windows.Forms.Label();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.foodImage);
            this.panel1.Controls.Add(this.chefImage);
            this.panel1.Controls.Add(this.closePicture);
            this.panel1.Controls.Add(this.customerImage);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 103);
            this.panel1.TabIndex = 1;
            // 
            // foodImage
            // 
            this.foodImage.Image = ((System.Drawing.Image)(resources.GetObject("foodImage.Image")));
            this.foodImage.Location = new System.Drawing.Point(579, 12);
            this.foodImage.Name = "foodImage";
            this.foodImage.Size = new System.Drawing.Size(76, 75);
            this.foodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodImage.TabIndex = 3;
            this.foodImage.TabStop = false;
            this.foodImage.Click += new System.EventHandler(this.foodImage_Click);
            // 
            // chefImage
            // 
            this.chefImage.Image = ((System.Drawing.Image)(resources.GetObject("chefImage.Image")));
            this.chefImage.Location = new System.Drawing.Point(995, 12);
            this.chefImage.Name = "chefImage";
            this.chefImage.Size = new System.Drawing.Size(84, 82);
            this.chefImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chefImage.TabIndex = 2;
            this.chefImage.TabStop = false;
            this.chefImage.Click += new System.EventHandler(this.chefImage_Click);
            // 
            // closePicture
            // 
            this.closePicture.Image = ((System.Drawing.Image)(resources.GetObject("closePicture.Image")));
            this.closePicture.Location = new System.Drawing.Point(1156, 12);
            this.closePicture.Name = "closePicture";
            this.closePicture.Size = new System.Drawing.Size(35, 32);
            this.closePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePicture.TabIndex = 1;
            this.closePicture.TabStop = false;
            this.closePicture.Click += new System.EventHandler(this.closePicture_Click);
            // 
            // customerImage
            // 
            this.customerImage.Image = ((System.Drawing.Image)(resources.GetObject("customerImage.Image")));
            this.customerImage.Location = new System.Drawing.Point(134, 21);
            this.customerImage.Name = "customerImage";
            this.customerImage.Size = new System.Drawing.Size(69, 66);
            this.customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerImage.TabIndex = 0;
            this.customerImage.TabStop = false;
            this.customerImage.Click += new System.EventHandler(this.customerImage_Click);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTextBox.Location = new System.Drawing.Point(163, 175);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(123, 27);
            this.employeeIdTextBox.TabIndex = 8;
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdLabel.Location = new System.Drawing.Point(12, 179);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(139, 23);
            this.employeeIdLabel.TabIndex = 7;
            this.employeeIdLabel.Text = "Employee Id:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameTextBox.Location = new System.Drawing.Point(543, 171);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(178, 27);
            this.employeeNameTextBox.TabIndex = 10;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(347, 175);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(181, 23);
            this.employeeNameLabel.TabIndex = 9;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // employeePhoneTextBox
            // 
            this.employeePhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeePhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePhoneTextBox.Location = new System.Drawing.Point(977, 171);
            this.employeePhoneTextBox.Name = "employeePhoneTextBox";
            this.employeePhoneTextBox.Size = new System.Drawing.Size(206, 27);
            this.employeePhoneTextBox.TabIndex = 12;
            // 
            // employeePhoneLabel
            // 
            this.employeePhoneLabel.AutoSize = true;
            this.employeePhoneLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePhoneLabel.Location = new System.Drawing.Point(781, 175);
            this.employeePhoneLabel.Name = "employeePhoneLabel";
            this.employeePhoneLabel.Size = new System.Drawing.Size(182, 23);
            this.employeePhoneLabel.TabIndex = 11;
            this.employeePhoneLabel.Text = "Employee Phone:";
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Phone});
            this.employeeGridView.Location = new System.Drawing.Point(35, 268);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowTemplate.Height = 24;
            this.employeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.Size = new System.Drawing.Size(1134, 268);
            this.employeeGridView.TabIndex = 15;
            this.employeeGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employeeGridView_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(694, 568);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(173, 61);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Teal;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createButton.Location = new System.Drawing.Point(317, 568);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(173, 61);
            this.createButton.TabIndex = 18;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.employeePhoneTextBox);
            this.Controls.Add(this.employeePhoneLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.employeeIdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chef";
            this.Text = "chef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chef_FormClosing);
            this.Load += new System.EventHandler(this.chef_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox foodImage;
        private System.Windows.Forms.PictureBox chefImage;
        private System.Windows.Forms.PictureBox closePicture;
        private System.Windows.Forms.PictureBox customerImage;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox employeePhoneTextBox;
        private System.Windows.Forms.Label employeePhoneLabel;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}