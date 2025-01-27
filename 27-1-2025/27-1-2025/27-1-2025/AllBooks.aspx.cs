using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
namespace _27_1_2025
{
    public partial class AllBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string file = Server.MapPath("BooksData.txt");
            string[] books = File.ReadAllLines(file);
            StringBuilder row = new StringBuilder();

            foreach (string book in books)
            {

                string[] Library = book.Split(' ');

                row.Append("<tr>");
                row.Append($"<td> {Library[0]} </td> ");
                row.Append($"<td> {Library[1]} </td> ");
                row.Append($"<td> {Library[2]} </td> ");
                row.Append($"<td> {Library[3]} </td> ");
                row.Append("</tr>");

            }

            TableBody.InnerHtml = row.ToString();




        }
    }
}