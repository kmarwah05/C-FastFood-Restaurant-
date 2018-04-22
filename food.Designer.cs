namespace FastFood
{
    partial class food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(food));
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodImage = new System.Windows.Forms.PictureBox();
            this.chefImage = new System.Windows.Forms.PictureBox();
            this.closePicture = new System.Windows.Forms.PictureBox();
            this.customerImage = new System.Windows.Forms.PictureBox();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.setPriceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.foodIdTextBox = new System.Windows.Forms.TextBox();
            this.foodIdLabel = new System.Windows.Forms.Label();
            this.foodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.setPriceTextBox = new System.Windows.Forms.TextBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.foodImage);
            this.panel1.Controls.Add(this.chefImage);
            this.panel1.Controls.Add(this.closePicture);
            this.panel1.Controls.Add(this.customerImage);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 103);
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
            // foodTypeLabel
            // 
            this.foodTypeLabel.AutoSize = true;
            this.foodTypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTypeLabel.Location = new System.Drawing.Point(34, 482);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(117, 23);
            this.foodTypeLabel.TabIndex = 32;
            this.foodTypeLabel.Text = "Food Type:";
            // 
            // setPriceLabel
            // 
            this.setPriceLabel.AutoSize = true;
            this.setPriceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPriceLabel.Location = new System.Drawing.Point(34, 391);
            this.setPriceLabel.Name = "setPriceLabel";
            this.setPriceLabel.Size = new System.Drawing.Size(98, 23);
            this.setPriceLabel.TabIndex = 29;
            this.setPriceLabel.Text = "Set Price:";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(731, 567);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(173, 61);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Teal;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createButton.Location = new System.Drawing.Point(366, 567);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(173, 61);
            this.createButton.TabIndex = 27;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameTextBox.Location = new System.Drawing.Point(179, 296);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(235, 27);
            this.foodNameTextBox.TabIndex = 25;
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AllowDrop = true;
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLabel.Location = new System.Drawing.Point(34, 300);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(132, 23);
            this.foodNameLabel.TabIndex = 24;
            this.foodNameLabel.Text = "Food Name:";
            // 
            // foodIdTextBox
            // 
            this.foodIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodIdTextBox.Location = new System.Drawing.Point(179, 199);
            this.foodIdTextBox.Name = "foodIdTextBox";
            this.foodIdTextBox.Size = new System.Drawing.Size(235, 27);
            this.foodIdTextBox.TabIndex = 23;
            // 
            // foodIdLabel
            // 
            this.foodIdLabel.AutoSize = true;
            this.foodIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodIdLabel.Location = new System.Drawing.Point(34, 203);
            this.foodIdLabel.Name = "foodIdLabel";
            this.foodIdLabel.Size = new System.Drawing.Size(90, 23);
            this.foodIdLabel.TabIndex = 22;
            this.foodIdLabel.Text = "Food Id:";
            // 
            // foodTypeComboBox
            // 
            this.foodTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTypeComboBox.FormattingEnabled = true;
            this.foodTypeComboBox.Items.AddRange(new object[] {
            "Veg",
            "Non Veg"});
            this.foodTypeComboBox.Location = new System.Drawing.Point(179, 482);
            this.foodTypeComboBox.Name = "foodTypeComboBox";
            this.foodTypeComboBox.Size = new System.Drawing.Size(235, 28);
            this.foodTypeComboBox.TabIndex = 33;
            this.foodTypeComboBox.UseWaitCursor = true;
            // 
            // setPriceTextBox
            // 
            this.setPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPriceTextBox.Location = new System.Drawing.Point(179, 391);
            this.setPriceTextBox.Name = "setPriceTextBox";
            this.setPriceTextBox.Size = new System.Drawing.Size(235, 27);
            this.setPriceTextBox.TabIndex = 34;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Food Type";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Set Price";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Food Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Food ID";
            this.Column1.Name = "Column1";
            // 
            // foodGridView
            // 
            this.foodGridView.AllowUserToAddRows = false;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.foodGridView.Location = new System.Drawing.Point(457, 215);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodGridView.Size = new System.Drawing.Size(723, 268);
            this.foodGridView.TabIndex = 26;
            this.foodGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.foodGridView_MouseDoubleClick);
            // 
            // food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 661);
            this.Controls.Add(this.setPriceTextBox);
            this.Controls.Add(this.foodTypeComboBox);
            this.Controls.Add(this.foodTypeLabel);
            this.Controls.Add(this.setPriceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.foodGridView);
            this.Controls.Add(this.foodNameTextBox);
            this.Controls.Add(this.foodNameLabel);
            this.Controls.Add(this.foodIdTextBox);
            this.Controls.Add(this.foodIdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "food";
            this.ShowIcon = false;
            this.Text = "food";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.food_FormClosing);
            this.Load += new System.EventHandler(this.food_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox foodImage;
        private System.Windows.Forms.PictureBox chefImage;
        private System.Windows.Forms.PictureBox closePicture;
        private System.Windows.Forms.PictureBox customerImage;
        private System.Windows.Forms.Label foodTypeLabel;
        private System.Windows.Forms.Label setPriceLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.TextBox foodIdTextBox;
        private System.Windows.Forms.Label foodIdLabel;
        private System.Windows.Forms.ComboBox foodTypeComboBox;
        private System.Windows.Forms.TextBox setPriceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView foodGridView;
    }
}