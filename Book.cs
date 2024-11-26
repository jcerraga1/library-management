using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int NumOfPages { get; set; }
        public int Copies { get; set; }

        public Book(string id, string title, string author, string category, int numOfPages, int copies)
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            NumOfPages = numOfPages;
            Copies = copies;
        }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Author}, {NumOfPages}, {Copies}";
        }
    }

}
