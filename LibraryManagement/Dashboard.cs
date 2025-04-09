using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagement.Repositories;

namespace LibraryManagement
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            Dashboard_Load();
        }

        private void Dashboard_Load()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("Timestamp");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Category");

            var repo = new ClientReposity();
            var books = repo.GetAllBooks();

            foreach (var book in books)
            {
                var row = dataTable.NewRow();
                row["BookID"] = book.BookID;
                row["Timestamp"] = book.Timestamp;
                row["Name"] = book.Name;
                row["Author"] = book.Author;
                row["Category"] = book.Category;
                dataTable.Rows.Add(row);
            }

            this.booksTable.DataSource = dataTable;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void db_return_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void db_bookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
