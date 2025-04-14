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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_loaddata = new System.Windows.Forms.Button();
            this.db_published = new System.Windows.Forms.DateTimePicker();
            this.db_clear = new System.Windows.Forms.Button();
            this.db_delete = new System.Windows.Forms.Button();
            this.db_update = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeto = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimefrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLatest = new System.Windows.Forms.Button();
            this.BtnOldest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.addbook);
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
            this.panel1.Size = new System.Drawing.Size(294, 596);
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
            this.db_loaddata.Click += new System.EventHandler(this.Load_Click);
            // 
            // db_published
            // 
            this.db_published.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.db_published.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.db_published.Location = new System.Drawing.Point(118, 341);
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
            this.db_clear.Location = new System.Drawing.Point(33, 421);
            this.db_clear.Margin = new System.Windows.Forms.Padding(0);
            this.db_clear.Name = "db_clear";
            this.db_clear.Size = new System.Drawing.Size(92, 43);
            this.db_clear.TabIndex = 13;
            this.db_clear.Text = "Sort";
            this.db_clear.UseVisualStyleBackColor = false;
            this.db_clear.Click += new System.EventHandler(this.sort_Click);
            // 
            // db_delete
            // 
            this.db_delete.BackColor = System.Drawing.Color.SeaGreen;
            this.db_delete.FlatAppearance.BorderSize = 0;
            this.db_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_delete.ForeColor = System.Drawing.Color.OldLace;
            this.db_delete.Location = new System.Drawing.Point(32, 486);
            this.db_delete.Margin = new System.Windows.Forms.Padding(0);
            this.db_delete.Name = "db_delete";
            this.db_delete.Size = new System.Drawing.Size(92, 43);
            this.db_delete.TabIndex = 12;
            this.db_delete.Text = "Delete";
            this.db_delete.UseVisualStyleBackColor = false;
            this.db_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // db_update
            // 
            this.db_update.BackColor = System.Drawing.Color.SeaGreen;
            this.db_update.FlatAppearance.BorderSize = 0;
            this.db_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.db_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_update.ForeColor = System.Drawing.Color.OldLace;
            this.db_update.Location = new System.Drawing.Point(160, 486);
            this.db_update.Margin = new System.Windows.Forms.Padding(0);
            this.db_update.Name = "db_update";
            this.db_update.Size = new System.Drawing.Size(92, 43);
            this.db_update.TabIndex = 11;
            this.db_update.Text = "Update";
            this.db_update.UseVisualStyleBackColor = false;
            this.db_update.Click += new System.EventHandler(this.update_Click);
            // 
            // addbook
            // 
            this.addbook.BackColor = System.Drawing.Color.SeaGreen;
            this.addbook.FlatAppearance.BorderSize = 0;
            this.addbook.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.addbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook.ForeColor = System.Drawing.Color.OldLace;
            this.addbook.Location = new System.Drawing.Point(160, 421);
            this.addbook.Margin = new System.Windows.Forms.Padding(0);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(92, 43);
            this.addbook.TabIndex = 10;
            this.addbook.Text = "Add";
            this.addbook.UseVisualStyleBackColor = false;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(2, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Published: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // db_author
            // 
            this.db_author.BackColor = System.Drawing.Color.OldLace;
            this.db_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_author.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_author.Location = new System.Drawing.Point(118, 216);
            this.db_author.Name = "db_author";
            this.db_author.Size = new System.Drawing.Size(158, 30);
            this.db_author.TabIndex = 7;
            this.db_author.TextChanged += new System.EventHandler(this.db_author_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(30, 216);
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
            this.db_category.Location = new System.Drawing.Point(118, 277);
            this.db_category.Name = "db_category";
            this.db_category.Size = new System.Drawing.Size(158, 30);
            this.db_category.TabIndex = 5;
            this.db_category.TextChanged += new System.EventHandler(this.db_category_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(8, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // db_title
            // 
            this.db_title.BackColor = System.Drawing.Color.OldLace;
            this.db_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.db_title.Location = new System.Drawing.Point(118, 154);
            this.db_title.Name = "db_title";
            this.db_title.Size = new System.Drawing.Size(158, 30);
            this.db_title.TabIndex = 3;
            this.db_title.TextChanged += new System.EventHandler(this.booktitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 154);
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
            this.db_bookID.Location = new System.Drawing.Point(118, 91);
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
            this.label2.Location = new System.Drawing.Point(14, 91);
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
            this.panel3.Size = new System.Drawing.Size(740, 596);
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
            this.booksTable.Size = new System.Drawing.Size(708, 524);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.dateTimeto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimefrom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnLatest);
            this.panel2.Controls.Add(this.BtnOldest);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(1104, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 596);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimeto
            // 
            this.dateTimeto.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimeto.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimeto.Location = new System.Drawing.Point(73, 398);
            this.dateTimeto.Name = "dateTimeto";
            this.dateTimeto.Size = new System.Drawing.Size(213, 26);
            this.dateTimeto.TabIndex = 20;
            this.dateTimeto.ValueChanged += new System.EventHandler(this.dateTimeto_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(12, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "To:";
            // 
            // dateTimefrom
            // 
            this.dateTimefrom.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimefrom.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimefrom.Location = new System.Drawing.Point(73, 355);
            this.dateTimefrom.Name = "dateTimefrom";
            this.dateTimefrom.Size = new System.Drawing.Size(213, 26);
            this.dateTimefrom.TabIndex = 17;
            this.dateTimefrom.ValueChanged += new System.EventHandler(this.dateTimefrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(12, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "From: ";
            // 
            // btnLatest
            // 
            this.btnLatest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLatest.FlatAppearance.BorderSize = 0;
            this.btnLatest.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLatest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLatest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatest.ForeColor = System.Drawing.Color.OldLace;
            this.btnLatest.Location = new System.Drawing.Point(165, 277);
            this.btnLatest.Margin = new System.Windows.Forms.Padding(0);
            this.btnLatest.Name = "btnLatest";
            this.btnLatest.Size = new System.Drawing.Size(92, 43);
            this.btnLatest.TabIndex = 18;
            this.btnLatest.Text = "Latest";
            this.btnLatest.UseVisualStyleBackColor = false;
            this.btnLatest.Click += new System.EventHandler(this.btnLatest_Click);
            // 
            // BtnOldest
            // 
            this.BtnOldest.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnOldest.FlatAppearance.BorderSize = 0;
            this.BtnOldest.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnOldest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnOldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOldest.ForeColor = System.Drawing.Color.OldLace;
            this.BtnOldest.Location = new System.Drawing.Point(36, 277);
            this.BtnOldest.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOldest.Name = "BtnOldest";
            this.BtnOldest.Size = new System.Drawing.Size(92, 43);
            this.BtnOldest.TabIndex = 17;
            this.BtnOldest.Text = "Oldest";
            this.BtnOldest.UseVisualStyleBackColor = false;
            this.BtnOldest.Click += new System.EventHandler(this.BtnOldest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.OldLace;
            this.btnSearch.Location = new System.Drawing.Point(36, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 43);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.OldLace;
            this.BtnDelete.Location = new System.Drawing.Point(165, 17);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(92, 43);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1426, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button db_clear;
        private System.Windows.Forms.Button db_delete;
        private System.Windows.Forms.DateTimePicker db_published;
        private System.Windows.Forms.Button db_loaddata;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Button BtnOldest;
        private System.Windows.Forms.DateTimePicker dateTimeto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimefrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDelete;
    }
}
