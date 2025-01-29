using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class edit_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserProfile();
            }
        }

        private void LoadUserProfile()
        {
            string filePath = Server.MapPath("~/UserData.txt");
            string userEmail = Session["UserEmail"] as string;

            if (string.IsNullOrEmpty(userEmail))
            {
                Response.Write("No user is logged in.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Response.Write("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool userFound = false;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] userData = line.Split(' ');
                if (userData.Length >= 4)
                {
                    string storedName = userData[0];
                    string storedEmail = userData[1];
                    string storedPassword = userData[2];

                    if (storedEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        txtFullName.Text = storedName;
                        txtEmail.Text = storedEmail;
                        txtMembershipID.Text = "123456";
                        txtStatus.Text = "Active";
                        txtPassword.Text = storedPassword;
                        userFound = true;
                        break;
                    }
                }
            }

            if (!userFound)
            {
                Response.Write("User not found in the file.");
            }
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/UserData.txt");
            string userEmail = Session["UserEmail"] as string;

            if (string.IsNullOrEmpty(userEmail))
            {
                Response.Write("No user is logged in.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Response.Write("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string updatedContent = "";
            bool userFound = false;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] userData = line.Split(' ');
                if (userData.Length >= 4)
                {
                    string storedEmail = userData[1];

                    if (storedEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        userData[0] = "Name: " + txtFullName.Text;
                        userData[1] = "Email: " + txtEmail.Text;
                        userData[2] = "Password: " + txtPassword.Text;

                        updatedContent += string.Join(",", userData) + Environment.NewLine;
                        userFound = true;
                    }
                    else
                    {
                        updatedContent += line + Environment.NewLine;
                    }
                }
            }

            if (userFound)
            {
                File.WriteAllText(filePath, updatedContent);
                Response.Redirect("profile.aspx");
            }
            else
            {
                Response.Write("User not found.");
            }
        }

        protected void btnGoToProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
    }
}