namespace LibraryManagement
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_loaddata = new System.Windows.Forms.Button();
            this.db_published = new System.Windows.Forms.DateTimePicker();
            this.db_clear = new System.Windows.Forms.Button();
            this.db_delete = new System.Windows.Forms.Button();
            this.db_update = new System.Windows.Forms.Button();
            this.db_addbook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.db_author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.db_category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.db_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.db_bookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.db_loaddata);
            this.panel1.Controls.Add(this.db_published);
            this.panel1.Controls.Add(this.db_clear);
            this.panel1.Controls.Add(this.db_delete);
            this.panel1.Controls.Add(this.db_update);
            this.panel1.Controls.Add(this.db_addbook);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.db_author);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.db_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.db_title);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.db_bookID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 533);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // db_loaddata
            // 
            this.db_loaddata.BackColor = System.Drawing.Color.SeaGreen;
            this.db_loaddata.FlatAppearance.BorderSize = 0;
            this.db_loaddata.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_loaddata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_loaddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_loaddata.ForeColor = System.Drawing.Color.OldLace;
            this.db_loaddata.Location = new System.Drawing.Point(83, 13);
            this.db_loaddata.Margin = new System.Windows.Forms.Padding(0);
            this.db_loaddata.Name = "db_loaddata";
            this.db_loaddata.Size = new System.Drawing.Size(92, 43);
            this.db_loaddata.TabIndex = 15;
            this.db_loaddata.Text = "Load";
            this.db_loaddata.UseVisualStyleBackColor = false;
            this.db_loaddata.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // db_published
            // 
            this.db_published.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.db_published.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.db_published.Location = new System.Drawing.Point(118, 322);
            this.db_published.Name = "db_published";
            this.db_published.Size = new System.Drawing.Size(158, 26);
            this.db_published.TabIndex = 14;
            this.db_published.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // db_clear
            // 
            this.db_clear.BackColor = System.Drawing.Color.SeaGreen;
            this.db_clear.FlatAppearance.BorderSize = 0;
            this.db_clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_clear.ForeColor = System.Drawing.Color.OldLace;
            this.db_clear.Location = new System.Drawing.Point(146, 452);
            this.db_clear.Margin = new System.Windows.Forms.Padding(0);
            this.db_clear.Name = "db_clear";
            this.db_clear.Size = new System.Drawing.Size(92, 43);
            this.db_clear.TabIndex = 13;
            this.db_clear.Text = "Clear";
            this.db_clear.UseVisualStyleBackColor = false;
            this.db_clear.Click += new System.EventHandler(this.db_return_Click);
            // 
            // db_delete
            // 
            this.db_delete.BackColor = System.Drawing.Color.SeaGreen;
            this.db_delete.FlatAppearance.BorderSize = 0;
            this.db_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_delete.ForeColor = System.Drawing.Color.OldLace;
            this.db_delete.Location = new System.Drawing.Point(18, 452);
            this.db_delete.Margin = new System.Windows.Forms.Padding(0);
            this.db_delete.Name = "db_delete";
            this.db_delete.Size = new System.Drawing.Size(92, 43);
            this.db_delete.TabIndex = 12;
            this.db_delete.Text = "Delete";
            this.db_delete.UseVisualStyleBackColor = false;
            this.db_delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // db_update
            // 
            this.db_update.BackColor = System.Drawing.Color.SeaGreen;
            this.db_update.FlatAppearance.BorderSize = 0;
            this.db_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_update.ForeColor = System.Drawing.Color.OldLace;
            this.db_update.Location = new System.Drawing.Point(146, 388);
            this.db_update.Margin = new System.Windows.Forms.Padding(0);
            this.db_update.Name = "db_update";
            this.db_update.Size = new System.Drawing.Size(92, 43);
            this.db_update.TabIndex = 11;
            this.db_update.Text = "Update";
            this.db_update.UseVisualStyleBackColor = false;
            this.db_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_addbook
            // 
            this.db_addbook.BackColor = System.Drawing.Color.SeaGreen;
            this.db_addbook.FlatAppearance.BorderSize = 0;
            this.db_addbook.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_addbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_addbook.ForeColor = System.Drawing.Color.OldLace;
            this.db_addbook.Location = new System.Drawing.Point(18, 388);
            this.db_addbook.Margin = new System.Windows.Forms.Padding(0);
            this.db_addbook.Name = "db_addbook";
            this.db_addbook.Size = new System.Drawing.Size(92, 43);
            this.db_addbook.TabIndex = 10;
            this.db_addbook.Text = "Add";
            this.db_addbook.UseVisualStyleBackColor = false;
            this.db_addbook.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(2, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Published: ";
            // 
            // db_author
            // 
            this.db_author.BackColor = System.Drawing.Color.OldLace;
            this.db_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_author.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_author.Location = new System.Drawing.Point(118, 197);
            this.db_author.Name = "db_author";
            this.db_author.Size = new System.Drawing.Size(158, 30);
            this.db_author.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(30, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // db_category
            // 
            this.db_category.BackColor = System.Drawing.Color.OldLace;
            this.db_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_category.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_category.Location = new System.Drawing.Point(118, 258);
            this.db_category.Name = "db_category";
            this.db_category.Size = new System.Drawing.Size(158, 30);
            this.db_category.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(8, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category: ";
            // 
            // db_title
            // 
            this.db_title.BackColor = System.Drawing.Color.OldLace;
            this.db_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_title.Location = new System.Drawing.Point(118, 135);
            this.db_title.Name = "db_title";
            this.db_title.Size = new System.Drawing.Size(158, 30);
            this.db_title.TabIndex = 3;
            this.db_title.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book title: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // db_bookID
            // 
            this.db_bookID.BackColor = System.Drawing.Color.OldLace;
            this.db_bookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_bookID.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_bookID.Location = new System.Drawing.Point(118, 72);
            this.db_bookID.Name = "db_bookID";
            this.db_bookID.Size = new System.Drawing.Size(158, 30);
            this.db_bookID.TabIndex = 1;
            this.db_bookID.TextChanged += new System.EventHandler(this.db_bookID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.booksTable);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(338, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 533);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // booksTable
            // 
            this.booksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksTable.BackgroundColor = System.Drawing.Color.OldLace;
            this.booksTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.GridColor = System.Drawing.Color.DimGray;
            this.booksTable.Location = new System.Drawing.Point(14, 51);
            this.booksTable.MultiSelect = false;
            this.booksTable.Name = "booksTable";
            this.booksTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.booksTable.RowHeadersWidth = 62;
            this.booksTable.RowTemplate.Height = 28;
            this.booksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksTable.Size = new System.Drawing.Size(708, 463);
            this.booksTable.TabIndex = 1;
            this.booksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(315, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1100, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox db_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox db_bookID;
        private System.Windows.Forms.TextBox db_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox db_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button db_update;
        private System.Windows.Forms.Button db_addbook;
        private System.Windows.Forms.Button db_clear;
        private System.Windows.Forms.Button db_delete;
        private System.Windows.Forms.DateTimePicker db_published;
        private System.Windows.Forms.Button db_loaddata;
    }
}
