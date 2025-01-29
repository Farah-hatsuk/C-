<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit profile.aspx.cs" Inherits="_27_1_2025.edit_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <section class="container py-5">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="card shadow-lg">
                        <div class="card-body">
                            <h2 class="text-center mb-4"><i class="fas fa-user-edit"></i> Edit Profile</h2>
                            
                            <div class="mb-3">
                                <label class="form-label"><i class="fas fa-user"></i> Full Name</label>
                                <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" placeholder="Enter full name"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label class="form-label"><i class="fas fa-envelope"></i> Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter email"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label class="form-label"><i class="fas fa-id-badge"></i> Membership ID</label>
                                <asp:TextBox ID="txtMembershipID" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label class="form-label"><i class="fas fa-user-check"></i> Membership Status</label>
                                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label class="form-label"><i class="fas fa-lock"></i> Password</label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter new password"></asp:TextBox>
                                    <button type="button" class="btn btn-outline-secondary" onclick="togglePassword()">
                                        <i class="fas fa-eye"></i>
                                    </button>
                                </div>
                            </div>

                            <div class="text-center">
                                <asp:Button ID="btnSaveChanges" runat="server" CssClass="btn btn-primary btn-custom w-100" Text="Save Changes" OnClick="btnSaveChanges_Click" />
                            </div>

                            <div class="text-center mt-3">
                                <asp:Button ID="btnGoToProfile" runat="server" CssClass="btn btn-secondary btn-custom w-100" Text="Go to Profile" OnClick="btnGoToProfile_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>

    <script>
        function togglePassword() {
            var passwordField = document.getElementById('<%= txtPassword.ClientID %>');
            if (passwordField.type === "password") {
                passwordField.type = "text";
            } else {
                passwordField.type = "password";
            }
        }
    </script>

        </div>
    </form>
</body>
</html>
