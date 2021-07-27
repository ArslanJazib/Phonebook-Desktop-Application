namespace J8
{
    partial class phone_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phone_book));
            this.phoneBook = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_icon = new System.Windows.Forms.PictureBox();
            this.search_tbox = new System.Windows.Forms.TextBox();
            this.add_icon = new System.Windows.Forms.PictureBox();
            this.booklabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.search_name = new System.Windows.Forms.RadioButton();
            this.search_number = new System.Windows.Forms.RadioButton();
            this.search_email = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.GroupBox();
            this.search_bar = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.options.SuspendLayout();
            this.search_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneBook
            // 
            this.phoneBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo,
            this.u_name,
            this.Number,
            this.Email,
            this.Address});
            this.phoneBook.Location = new System.Drawing.Point(0, 98);
            this.phoneBook.Name = "phoneBook";
            this.phoneBook.ReadOnly = true;
            this.phoneBook.RowTemplate.Height = 28;
            this.phoneBook.Size = new System.Drawing.Size(1082, 579);
            this.phoneBook.TabIndex = 0;
            this.phoneBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.phoneBook.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phoneBook_CellContentDoubleClick);
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "Serial No.";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // u_name
            // 
            this.u_name.HeaderText = "Name";
            this.u_name.Name = "u_name";
            this.u_name.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // search_icon
            // 
            this.search_icon.Image = ((System.Drawing.Image)(resources.GetObject("search_icon.Image")));
            this.search_icon.Location = new System.Drawing.Point(178, 10);
            this.search_icon.Name = "search_icon";
            this.search_icon.Size = new System.Drawing.Size(47, 53);
            this.search_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_icon.TabIndex = 1;
            this.search_icon.TabStop = false;
            this.search_icon.Click += new System.EventHandler(this.search_icon_Click);
            // 
            // search_tbox
            // 
            this.search_tbox.Location = new System.Drawing.Point(3, 37);
            this.search_tbox.Name = "search_tbox";
            this.search_tbox.Size = new System.Drawing.Size(169, 26);
            this.search_tbox.TabIndex = 2;
            // 
            // add_icon
            // 
            this.add_icon.Image = ((System.Drawing.Image)(resources.GetObject("add_icon.Image")));
            this.add_icon.Location = new System.Drawing.Point(566, 22);
            this.add_icon.Name = "add_icon";
            this.add_icon.Size = new System.Drawing.Size(41, 50);
            this.add_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_icon.TabIndex = 3;
            this.add_icon.TabStop = false;
            this.add_icon.Click += new System.EventHandler(this.addicon_Click);
            // 
            // booklabel
            // 
            this.booklabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.booklabel.AutoSize = true;
            this.booklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booklabel.Location = new System.Drawing.Point(856, 35);
            this.booklabel.Name = "booklabel";
            this.booklabel.Size = new System.Drawing.Size(146, 29);
            this.booklabel.TabIndex = 4;
            this.booklabel.Text = "Phonebook";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1008, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // search_name
            // 
            this.search_name.AutoSize = true;
            this.search_name.Location = new System.Drawing.Point(48, 40);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(21, 20);
            this.search_name.TabIndex = 0;
            this.search_name.TabStop = true;
            this.search_name.UseVisualStyleBackColor = true;
            this.search_name.CheckedChanged += new System.EventHandler(this.search_name_CheckedChanged);
            // 
            // search_number
            // 
            this.search_number.AutoSize = true;
            this.search_number.Location = new System.Drawing.Point(102, 40);
            this.search_number.Name = "search_number";
            this.search_number.Size = new System.Drawing.Size(21, 20);
            this.search_number.TabIndex = 1;
            this.search_number.TabStop = true;
            this.search_number.UseVisualStyleBackColor = true;
            this.search_number.CheckedChanged += new System.EventHandler(this.search_number_CheckedChanged);
            // 
            // search_email
            // 
            this.search_email.AutoSize = true;
            this.search_email.Location = new System.Drawing.Point(156, 40);
            this.search_email.Name = "search_email";
            this.search_email.Size = new System.Drawing.Size(21, 20);
            this.search_email.TabIndex = 2;
            this.search_email.TabStop = true;
            this.search_email.UseVisualStyleBackColor = true;
            this.search_email.CheckedChanged += new System.EventHandler(this.search_email_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // options
            // 
            this.options.Controls.Add(this.pictureBox4);
            this.options.Controls.Add(this.pictureBox1);
            this.options.Controls.Add(this.search_name);
            this.options.Controls.Add(this.search_email);
            this.options.Controls.Add(this.search_number);
            this.options.Controls.Add(this.pictureBox2);
            this.options.Location = new System.Drawing.Point(12, 12);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(201, 77);
            this.options.TabIndex = 16;
            this.options.TabStop = false;
            this.options.Text = "Options";
            // 
            // search_bar
            // 
            this.search_bar.Controls.Add(this.delete);
            this.search_bar.Controls.Add(this.update);
            this.search_bar.Controls.Add(this.search_tbox);
            this.search_bar.Controls.Add(this.search_icon);
            this.search_bar.Enabled = false;
            this.search_bar.Location = new System.Drawing.Point(219, 12);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(341, 77);
            this.search_bar.TabIndex = 17;
            // 
            // delete
            // 
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(286, 10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(44, 53);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 4;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(231, 10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(49, 53);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 3;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // phone_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 677);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.options);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.booklabel);
            this.Controls.Add(this.add_icon);
            this.Controls.Add(this.phoneBook);
            this.Name = "phone_book";
            this.Text = "Phonebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.phone_book_FormClosing);
            this.Load += new System.EventHandler(this.phone_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.search_bar.ResumeLayout(false);
            this.search_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.PictureBox search_icon;
        private System.Windows.Forms.TextBox search_tbox;
        private System.Windows.Forms.PictureBox add_icon;
        private System.Windows.Forms.Label booklabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView phoneBook;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.Panel search_bar;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox update;
        public System.Windows.Forms.RadioButton search_name;
        public System.Windows.Forms.RadioButton search_email;
        public System.Windows.Forms.RadioButton search_number;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
    }
}

