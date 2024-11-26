using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    public class LibraryManager
    {
        private Library library;

        public LibraryManager()
        {
            library = new Library();
        }

        public void LoadBooksFromFile(string filename)
        {
            try
            {
                foreach (var line in File.ReadAllLines(filename))
                {
                    var parts = line.Split(',');
                    var book = new Book(parts[0], parts[1], parts[2], parts[3],
                        int.Parse(parts[4]), int.Parse(parts[5]));
                    library.AddBook(book);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading books: {ex.Message}");
            }
        }

        public void SaveLibraryToFile(string filename)
        {
            try
            {
                using (var writer = new StreamWriter(filename))
                {
                    writer.Write(library.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving books: {ex.Message}");
            }
        }

        public Library GetLibrary()
        {
            return library;
        }
    }

}
