using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    public class Library
    {
        Dictionary<string, Dictionary<string, Book>> shelves;

        public Library()
        {
            shelves = new Dictionary<string, Dictionary<string, Book>>();
        }

        public void AddBook(Book book)
        {
            //do we already have the category of the book if our shelves 
            if (!shelves.ContainsKey(book.Category))
            {
                shelves[book.Category] = new Dictionary<string, Book>();
            }

            var shelf = shelves[book.Category];
            if (shelf.ContainsKey(book.Id))
            {
                shelf[book.Id].Copies += book.Copies;
            }
            else
            {
                shelf[book.Id] = book;
            }
        }

        public Dictionary<string, Dictionary<string, Book>> GetShelves()
        {
            return shelves;
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            foreach (var category in shelves)
            {
                result.AppendLine($"Category: {category.Key}");
                foreach (var book in category.Value.Values)
                {
                    result.AppendLine(book.ToString());
                }
            }
            return result.ToString();
        }
    }

}
