using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class edit_book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("BooksData.txt");
            if (File.Exists(path))
            {
                string[] books = File.ReadAllLines(path);
                foreach (string line in books)
                {
                    string[] book = line.Split(' ');
                    if (book[0] == bookId.Text)
                    {
                        searchRes.Text = line;
                        searchRes.Visible = true;
                        bookName.Text = book[1];
                        bookType.Text = book[2];
                        bookLevel.Text = book[3];   
                    }
                }
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("BooksData.txt");
            if (File.Exists(path))
            {
                string[] books = File.ReadAllLines(path);

                for (int i = 0; i < books.Length; i++)
                {
                    string[] book = books[i].Split(' ');
                    if (book[0] == bookId.Text)
                    {
                        book[1] = bookName.Text;
                        book[2] = bookType.Text;
                        book[3] = bookLevel.Text;

                        books[i] = $"{book[0]} {book[1]} {book[2]} {book[3]}";

                        File.WriteAllLines(path, books);
                        return;
                    }
                    else
                    {

                    }
                }

            }

        }
    }
}