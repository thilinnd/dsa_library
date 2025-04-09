using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
