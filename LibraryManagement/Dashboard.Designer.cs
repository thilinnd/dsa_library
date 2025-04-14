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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dateTimeto = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimefrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLatest = new System.Windows.Forms.Button();
            this.BtnOldest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.booktitle_right = new System.Windows.Forms.TextBox();
            this.label_btitle = new System.Windows.Forms.Label();
            this.author_right = new System.Windows.Forms.TextBox();
            this.lb_author = new System.Windows.Forms.Label();
            this.Category_right = new System.Windows.Forms.TextBox();
            this.lb_Cat = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.radio_title = new System.Windows.Forms.RadioButton();
            this.radio_author = new System.Windows.Forms.RadioButton();
            this.radio_category = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.radio_category);
            this.panel2.Controls.Add(this.radio_author);
            this.panel2.Controls.Add(this.radio_title);
            this.panel2.Controls.Add(this.filter);
            this.panel2.Controls.Add(this.Category_right);
            this.panel2.Controls.Add(this.lb_Cat);
            this.panel2.Controls.Add(this.author_right);
            this.panel2.Controls.Add(this.lb_author);
            this.panel2.Controls.Add(this.booktitle_right);
            this.panel2.Controls.Add(this.label_btitle);
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
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.OldLace;
            this.BtnDelete.Location = new System.Drawing.Point(165, 429);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(92, 43);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dateTimeto
            // 
            this.dateTimeto.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimeto.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimeto.Location = new System.Drawing.Point(67, 382);
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
            this.label8.Location = new System.Drawing.Point(6, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "To:";
            // 
            // dateTimefrom
            // 
            this.dateTimefrom.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimefrom.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimefrom.Location = new System.Drawing.Point(67, 339);
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
            this.label7.Location = new System.Drawing.Point(6, 339);
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
            this.btnSearch.Location = new System.Drawing.Point(36, 429);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 43);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // booktitle_right
            // 
            this.booktitle_right.BackColor = System.Drawing.Color.OldLace;
            this.booktitle_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booktitle_right.ForeColor = System.Drawing.Color.SeaGreen;
            this.booktitle_right.Location = new System.Drawing.Point(122, 91);
            this.booktitle_right.Name = "booktitle_right";
            this.booktitle_right.Size = new System.Drawing.Size(158, 30);
            this.booktitle_right.TabIndex = 17;
            this.booktitle_right.TextChanged += new System.EventHandler(this.booktitle_right_TextChanged);
            // 
            // label_btitle
            // 
            this.label_btitle.AutoSize = true;
            this.label_btitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_btitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_btitle.Location = new System.Drawing.Point(18, 91);
            this.label_btitle.Name = "label_btitle";
            this.label_btitle.Size = new System.Drawing.Size(102, 25);
            this.label_btitle.TabIndex = 16;
            this.label_btitle.Text = "Book title: ";
            // 
            // author_right
            // 
            this.author_right.BackColor = System.Drawing.Color.OldLace;
            this.author_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_right.ForeColor = System.Drawing.Color.SeaGreen;
            this.author_right.Location = new System.Drawing.Point(122, 154);
            this.author_right.Name = "author_right";
            this.author_right.Size = new System.Drawing.Size(158, 30);
            this.author_right.TabIndex = 23;
            this.author_right.TextChanged += new System.EventHandler(this.author_right_TextChanged);
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_author.Location = new System.Drawing.Point(18, 154);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(81, 25);
            this.lb_author.TabIndex = 22;
            this.lb_author.Text = "Author: ";
            // 
            // Category_right
            // 
            this.Category_right.BackColor = System.Drawing.Color.OldLace;
            this.Category_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_right.ForeColor = System.Drawing.Color.SeaGreen;
            this.Category_right.Location = new System.Drawing.Point(122, 211);
            this.Category_right.Name = "Category_right";
            this.Category_right.Size = new System.Drawing.Size(158, 30);
            this.Category_right.TabIndex = 25;
            this.Category_right.TextChanged += new System.EventHandler(this.Category_right_TextChanged);
            // 
            // lb_Cat
            // 
            this.lb_Cat.AutoSize = true;
            this.lb_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cat.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_Cat.Location = new System.Drawing.Point(18, 211);
            this.lb_Cat.Name = "lb_Cat";
            this.lb_Cat.Size = new System.Drawing.Size(103, 25);
            this.lb_Cat.TabIndex = 24;
            this.lb_Cat.Text = "Category: ";
            this.lb_Cat.Click += new System.EventHandler(this.lb_Cat_Click);
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.SeaGreen;
            this.filter.FlatAppearance.BorderSize = 0;
            this.filter.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.OldLace;
            this.filter.Location = new System.Drawing.Point(103, 13);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(92, 43);
            this.filter.TabIndex = 26;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // radio_title
            // 
            this.radio_title.AutoSize = true;
            this.radio_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_title.ForeColor = System.Drawing.Color.SeaGreen;
            this.radio_title.Location = new System.Drawing.Point(23, 527);
            this.radio_title.Name = "radio_title";
            this.radio_title.Size = new System.Drawing.Size(126, 26);
            this.radio_title.TabIndex = 27;
            this.radio_title.TabStop = true;
            this.radio_title.Text = "Book Title";
            this.radio_title.UseVisualStyleBackColor = true;
            this.radio_title.CheckedChanged += new System.EventHandler(this.radio_title_CheckedChanged);
            // 
            // radio_author
            // 
            this.radio_author.AutoSize = true;
            this.radio_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_author.ForeColor = System.Drawing.Color.SeaGreen;
            this.radio_author.Location = new System.Drawing.Point(165, 527);
            this.radio_author.Name = "radio_author";
            this.radio_author.Size = new System.Drawing.Size(94, 26);
            this.radio_author.TabIndex = 28;
            this.radio_author.TabStop = true;
            this.radio_author.Text = "Author";
            this.radio_author.UseVisualStyleBackColor = true;
            this.radio_author.CheckedChanged += new System.EventHandler(this.radio_author_CheckedChanged);
            // 
            // radio_category
            // 
            this.radio_category.AutoSize = true;
            this.radio_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_category.ForeColor = System.Drawing.Color.SeaGreen;
            this.radio_category.Location = new System.Drawing.Point(23, 563);
            this.radio_category.Name = "radio_category";
            this.radio_category.Size = new System.Drawing.Size(116, 26);
            this.radio_category.TabIndex = 29;
            this.radio_category.TabStop = true;
            this.radio_category.Text = "Category";
            this.radio_category.UseVisualStyleBackColor = true;
            this.radio_category.CheckedChanged += new System.EventHandler(this.radio_category_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(117, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sort by";
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
        private System.Windows.Forms.TextBox Category_right;
        private System.Windows.Forms.Label lb_Cat;
        private System.Windows.Forms.TextBox author_right;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.TextBox booktitle_right;
        private System.Windows.Forms.Label label_btitle;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.RadioButton radio_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_category;
        private System.Windows.Forms.RadioButton radio_author;
    }
}
