using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Books
    {
        public string BookID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Books(string bookID, DateTime timestamp, string name, string author, string category)
        {
            BookID = bookID;
            Timestamp = timestamp;
            Name = name;
            Author = author;
            Category = category;
        }
    }
}
