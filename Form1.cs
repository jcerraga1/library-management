using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class Form1 : Form
    {
        private LibraryManager libraryManager;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            libraryManager = new LibraryManager();
            libraryManager.LoadBooksFromFile("books.txt");
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string id, title, author, category;
            int copies, numOfPages;
            do
            {
                id = Prompt.ShowDialog("Enter Book ID:", "ID");
            }while (id == "");
            do
            {
                title = Prompt.ShowDialog("Enter Book Title:", "Title");
            } while (title == ""); 
            do
            {
                author = Prompt.ShowDialog("Enter Author:", "Author");
            } while (author == "");
            do
            {
                numOfPages = int.Parse(Prompt.ShowDialogInt("Enter Number of Pages:", "Pages"));
            } while (numOfPages == 0);

            copies = int.Parse(Prompt.ShowDialogInt("Enter Copies:", "Copies"));
            category = comboBoxCategory.Text;

            var book = new Book(id, title, author, category, numOfPages, copies);
            libraryManager.GetLibrary().AddBook(book);
            libraryManager.SaveLibraryToFile("books.txt");

            MessageBox.Show("Book added successfully!");
        }

        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            textBoxBooks.Text = libraryManager.GetLibrary().ToString();
        }
        
    }
}

