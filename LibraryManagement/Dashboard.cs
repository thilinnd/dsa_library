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
using System.Globalization;

namespace LibraryManagement
{
    public partial class Dashboard : UserControl
    {
        private DataTable dataTable;
        private Books bstRoot;
        private string sortBy = "Title"; 
        private string currentBookID = "";
        private string currentName = "";
        private string currentAuthor = "";
        private string currentCategory = "";
        private DateTime currentDate = DateTime.Now;

        public Dashboard()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("Timestamp");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Category");

            this.booksTable.DataSource = dataTable;
        }

        private void LoadData()
        {

            dataTable.Clear();
            bstRoot = null;

            var repo = new ClientReposity();
            var books = repo.GetAllBooks();

            foreach (var book in books)
            {
                var row = dataTable.NewRow();
                row["BookID"] = book.BookID;
                row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                row["Name"] = book.Name;
                row["Author"] = book.Author;
                row["Category"] = book.Category;
                dataTable.Rows.Add(row);

                if (bstRoot == null)
                    bstRoot = new Books(book.BookID, book.Timestamp, book.Name, book.Author, book.Category);
                else
                    bstRoot.Insert(book);
            }
        }



        private void booksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = booksTable.Rows[e.RowIndex];
                currentBookID = row.Cells["BookID"].Value.ToString();
                currentName = row.Cells["Name"].Value.ToString();
                currentAuthor = row.Cells["Author"].Value.ToString();
                currentCategory = row.Cells["Category"].Value.ToString();
                currentDate = DateTime.Parse(row.Cells["Timestamp"].Value.ToString());

                // Đồng bộ dữ liệu lên các textbox
                db_bookID.Text = currentBookID;
                db_title.Text = currentName;
                db_author.Text = currentAuthor;
                db_category.Text = currentCategory;
                db_published.Value = currentDate;
            }
        }

        /* ---------------- text box & picker ---------------- */
        private void db_bookID_TextChanged(object sender, EventArgs e)
        {
            currentBookID = db_bookID.Text.Trim();
        }

        private void booktitle_TextChanged(object sender, EventArgs e)
        {
            currentName = db_title.Text.Trim();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentDate = db_published.Value;
        }

        private void db_author_TextChanged(object sender, EventArgs e)
        {
            currentAuthor = db_author.Text.Trim();
        }

        private void db_category_TextChanged(object sender, EventArgs e)
        {
            currentCategory = db_category.Text.Trim();
        }

        /* ---------------- button ---------------- */
        private void Load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (bstRoot == null)
            {
                MessageBox.Show("Please click Load before sorting.");
                return;
            }

            dataTable.Clear();

            bstRoot.InOrderTraversal(b =>
            {
                var row = dataTable.NewRow();
                row["BookID"] = b.BookID;
                row["Timestamp"] = b.Timestamp.ToString("yyyy-MM-dd");
                row["Name"] = b.Name;
                row["Author"] = b.Author;
                row["Category"] = b.Category;
                dataTable.Rows.Add(row);
            });
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentName))
            {
                MessageBox.Show("Please enter Book Name!");
                return;
            }

            DateTime timestamp = db_published.Value; // Giữ ở dạng DateTime

            Books newBook = new Books("", timestamp, currentName, currentAuthor, currentCategory);

            var repo = new ClientReposity();
            repo.AddBook(newBook);

            MessageBox.Show("Book added successfully!");
            Load_Click(sender, e);
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentBookID))
            {
                MessageBox.Show("Please enter or select the Book ID to update!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to update this book?",
                                                "Confirm update",
                                                MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            // Lấy dữ liệu mới từ form
            DateTime newTimestamp = db_published.Value;

            Books updatedBook = new Books(
                currentBookID,
                newTimestamp,
                currentName,
                currentAuthor,
                currentCategory
            );

            // Cập nhật trong CSDL
            var repo = new ClientReposity();
            repo.UpdateBook(updatedBook);

            // Cập nhật trong BST:
            if (bstRoot != null)
            {
                bstRoot = bstRoot.Delete(currentBookID, currentDate);

                bstRoot.Insert(updatedBook);
            }

            MessageBox.Show("Book update successfully!");
            Load_Click(sender, e);
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (bstRoot != null)
            {
                DateTime timestamp = db_published.Value;
                bstRoot = bstRoot.Delete(currentBookID, timestamp);
            }
        
            if (string.IsNullOrWhiteSpace(currentBookID))
            {
                MessageBox.Show("Please enter or select the Book ID to delete!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this book?",
                                                "Confirm deletion",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var repo = new ClientReposity();
                repo.DeleteBook(currentBookID); // Xóa trong CSDL

                // Xóa trong BST
                if (bstRoot != null)
                {
                    DateTime timestamp = db_published.Value;
                    bstRoot = bstRoot.Delete(currentBookID, timestamp);
                }

                MessageBox.Show("Book deleted successfully!");
                Load_Click(sender, e); 
            }
        }


        /* ---------------- panel & UI events (placeholder) ---------------- */
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOldest_Click(object sender, EventArgs e)
        {
            if (bstRoot != null)
            {
                var oldest = bstRoot.FindOldest();

                dataTable.Clear(); 

                var row = dataTable.NewRow();
                row["BookID"] = oldest.BookID;
                row["Timestamp"] = oldest.Timestamp.ToString("yyyy-MM-dd");
                row["Name"] = oldest.Name;
                row["Author"] = oldest.Author;
                row["Category"] = oldest.Category;

                dataTable.Rows.Add(row);
            }
        }

        private void btnLatest_Click(object sender, EventArgs e)
        {
            if (bstRoot != null)
            {
                var latest = bstRoot.FindLatest();

                dataTable.Clear();

                var row = dataTable.NewRow();
                row["BookID"] = latest.BookID;
                row["Timestamp"] = latest.Timestamp.ToString("yyyy-MM-dd");
                row["Name"] = latest.Name;
                row["Author"] = latest.Author;
                row["Category"] = latest.Category;

                dataTable.Rows.Add(row);
            }
        }

        private void dateTimefrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimefrom.Value.Date;
            DateTime to = dateTimeto.Value.Date;

            if (from > to)
            {
                MessageBox.Show("The start date must be before the end date.");
                return;
            }

            // Xóa dữ liệu cũ
            dataTable.Clear();

            if (bstRoot != null)
            {
                bstRoot.PrintInRange(from, to, book =>
                {
                    var row = dataTable.NewRow();
                    row["BookID"] = book.BookID;
                    row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                    row["Name"] = book.Name;
                    row["Author"] = book.Author;
                    row["Category"] = book.Category;
                    dataTable.Rows.Add(row);
                });
            }
            else
            {
                MessageBox.Show("There are no books in the tree.");
            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimefrom.Value.Date;
            DateTime to = dateTimeto.Value.Date;

            if (from > to)
            {
                MessageBox.Show("Start date must be before end date.");
                return;
            }

            // Xóa trong database
            var repo = new ClientReposity();
            repo.DeleteBooksInRange(from, to);

            // Load lại dữ liệu và cập nhật lại BST
            LoadData();

            MessageBox.Show("Book deleted in time range.");
        }

        private void lb_Cat_Click(object sender, EventArgs e)
        {

        }

        private void booktitle_right_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_right_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_right_TextChanged(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            string title = booktitle_right.Text.Trim();
            string author = author_right.Text.Trim();
            string category = Category_right.Text.Trim();

            dataTable.Clear();

            if (bstRoot != null)
            {
                bstRoot.FilterBooks(title, author, category, book =>
                {
                    var row = dataTable.NewRow();
                    row["BookID"] = book.BookID;
                    row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                    row["Name"] = book.Name;
                    row["Author"] = book.Author;
                    row["Category"] = book.Category;
                    dataTable.Rows.Add(row);
                });
            }
            else
            {
                MessageBox.Show("There is no data to search.");
            }
        }

        private void radio_title_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_title.Checked)
            {
                sortBy = "Title";
                dataTable.Clear();

                if (bstRoot != null)
                {
                    List<Books> allBooks = new List<Books>();

                    // Duyệt cây và thêm toàn bộ sách vào danh sách
                    bstRoot.InOrderTraversal(book => allBooks.Add(book));

                    // Sắp xếp danh sách theo Title (từ điển)
                    var sortedBooks = allBooks.OrderBy(b => b.Name).ToList();

                    // Đổ dữ liệu vào dataTable
                    foreach (var book in sortedBooks)
                    {
                        var row = dataTable.NewRow();
                        row["BookID"] = book.BookID;
                        row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                        row["Name"] = book.Name;
                        row["Author"] = book.Author;
                        row["Category"] = book.Category;
                        dataTable.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("There is no data to show.");
                }
            }
        }

        private void radio_author_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_author.Checked)
            {
                sortBy = "Author";
                dataTable.Clear();

                if (bstRoot != null)
                {
                    List<Books> allBooks = new List<Books>();

                    // Duyệt cây và thêm toàn bộ sách vào danh sách
                    bstRoot.InOrderTraversal(book => allBooks.Add(book));

                    // Sắp xếp danh sách theo Author (từ điển)
                    var sortedBooks = allBooks.OrderBy(b => b.Author).ToList();

                    // Đổ dữ liệu vào dataTable
                    foreach (var book in sortedBooks)
                    {
                        var row = dataTable.NewRow();
                        row["BookID"] = book.BookID;
                        row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                        row["Name"] = book.Name;
                        row["Author"] = book.Author;
                        row["Category"] = book.Category;
                        dataTable.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("\"There is no data to show.");
                }
            }

        }

        private void radio_category_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_category.Checked)
            {
                sortBy = "Category";
                dataTable.Clear();

                if (bstRoot != null)
                {
                    List<Books> allBooks = new List<Books>();

                    // Duyệt cây và thêm toàn bộ sách vào danh sách
                    bstRoot.InOrderTraversal(book => allBooks.Add(book));

                    // Sắp xếp danh sách theo Category (từ điển)
                    var sortedBooks = allBooks.OrderBy(b => b.Category).ToList();

                    // Đổ dữ liệu vào dataTable
                    foreach (var book in sortedBooks)
                    {
                        var row = dataTable.NewRow();
                        row["BookID"] = book.BookID;
                        row["Timestamp"] = book.Timestamp.ToString("yyyy-MM-dd");
                        row["Name"] = book.Name;
                        row["Author"] = book.Author;
                        row["Category"] = book.Category;
                        dataTable.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("There is no data to sh");
                }
            }
        }

    }
}


