using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class profile : System.Web.UI.Page
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
                Response.Write("<script>alert('No user is logged in.');</script>");
                return;
            }

            if (!File.Exists(filePath))
            {
                Response.Write("<script>alert('User data file not found.');</script>");
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
                        lblName.Text = storedName;
                        lblEmail.Text = storedEmail;
                        lblProfileEmail.Text = storedEmail;
                        lblFullName.Text = storedName;
                        lblPassword.Text = storedPassword;

                        string membershipID = "123456"; // قيمة افتراضية
                        lblProfileMembershipID.Text = membershipID;
                        lblMembershipID.Text = membershipID;
                        lblStatus.Text = "Active"; // تعيين الحالة كمفعّلة

                        userFound = true;
                        break;
                    }
                }
            }

            if (!userFound)
            {
                Response.Write("<script>alert('User not found in the file.');</script>");
            }
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit_profile.aspx");
        }
    }
}
