using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace LibraryManagement.Repositories
{
    internal class ClientReposity
    {
        private readonly string connectionString = "Data Source=THILIN\\MNSQL;Initial Catalog=dsa_lib;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        public List<Books> GetAllBooks()
        {
            List<Books> books = new List<Books>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string bookID = reader["BookID"].ToString();
                    DateTime timestamp = Convert.ToDateTime(reader["Timestamp"]);
                    string name = reader["Name"].ToString();
                    string author = reader["Author"].ToString();
                    string category = reader["Category"].ToString();

                    books.Add(new Books(bookID, timestamp, name, author, category));
                }
            }
            return books;
        }

        public void AddBook(Books book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Books (Timestamp, Name, Author, Category) " +
                               "VALUES (@Timestamp, @Name, @Author, @Category)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Timestamp", book.Timestamp);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Category", book.Category);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteBook(string bookID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE BookID = @BookID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", bookID);
                command.ExecuteNonQuery();
            }
        }



        public void UpdateBook(Books book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Books 
                             SET Timestamp = @Timestamp, 
                                 Name = @Name, 
                                 Author = @Author, 
                                 Category = @Category 
                             WHERE BookID = @BookID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Timestamp", book.Timestamp);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Category", book.Category);
                command.Parameters.AddWithValue("@BookID", book.BookID);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteBooksInRange(DateTime from, DateTime to)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE Timestamp >= @From AND Timestamp <= @To";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);

                command.ExecuteNonQuery();
            }
        }

        

    }
}
