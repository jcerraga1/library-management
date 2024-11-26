namespace LibraryManagementApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxCategory = new ComboBox();
            buttonAddBook = new Button();
            buttonShowBooks = new Button();
            textBoxBooks = new TextBox();
            SuspendLayout();

            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Items.AddRange(new object[] 
            { 
                "S1-Historic", 
                "S2-Dramatic", 
                "S3-Romantic", 
                "S4-Thriller",
                "S5-Children",
                "S6-Psychology",
                "S7-Computer"
            });
            comboBoxCategory.Location = new Point(12, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 28);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndex = 0;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(150, 10);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(113, 30);
            buttonAddBook.TabIndex = 1;
            buttonAddBook.Text = "Add Book";
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // buttonShowBooks
            // 
            buttonShowBooks.Location = new Point(269, 10);
            buttonShowBooks.Name = "buttonShowBooks";
            buttonShowBooks.Size = new Size(103, 30);
            buttonShowBooks.TabIndex = 2;
            buttonShowBooks.Text = "Show Books";
            buttonShowBooks.Click += buttonShowBooks_Click;
            // 
            // textBoxBooks
            // 
            textBoxBooks.Location = new Point(12, 50);
            textBoxBooks.Multiline = true;
            textBoxBooks.Name = "textBoxBooks";
            textBoxBooks.ReadOnly = true;
            textBoxBooks.ScrollBars = ScrollBars.Vertical;
            textBoxBooks.Size = new Size(360, 200);
            textBoxBooks.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(388, 272);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonAddBook);
            Controls.Add(buttonShowBooks);
            Controls.Add(textBoxBooks);
            Name = "Form1";
            Text = "Library Manager";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.TextBox textBoxBooks;
    }
}