<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="_27_1_2025.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet">
    <style>
        
<style>
        .card {
            border: none;
            border-radius: 15px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s ease;
        }
        .card:hover {
            transform: translateY(-5px);
        }
        .profile-img {
            border: 5px solid #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        .btn-custom {
            background-color: #6c5ce7;
            color: white;
            border-radius: 25px;
            padding: 10px 20px;
            transition: background-color 0.3s ease;
        }
        .btn-custom:hover {
            background-color: #5a4bcf;
        }
        .btn-outline-custom {
            border-color: #6c5ce7;
            color: #6c5ce7;
            border-radius: 25px;
            padding: 10px 20px;
            transition: all 0.3s ease;
        }
        .btn-outline-custom:hover {
            background-color: #6c5ce7;
            color: white;
        }
        .section-bg {
            background: linear-gradient(135deg, #f5f7fa, #c3cfe2);
        }
        .text-purple {
            color: #6c5ce7;
        }
    </style>
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <section class="section-bg">
            <div class="container py-5">
                <div class="row">
                    <div class="col">
                        <nav aria-label="breadcrumb" class="bg-light rounded-3 p-3 mb-4">
                            <ol class="breadcrumb mb-0">
                                <li class="breadcrumb-item"><a href="#" class="text-decoration-none text-purple">Home</a></li>
                                <li class="breadcrumb-item"><a href="#" class="text-decoration-none text-purple">Library</a></li>
                                <li class="breadcrumb-item active" aria-current="page">User Profile</li>
                            </ol>
                        </nav>
                    </div>
                </div>

                <div class="row">
                    <!-- Sidebar Profile -->
                    <div class="col-lg-4">
                        <div class="card mb-4">
                            <div class="card-body text-center">
                                <img src="https://i.pinimg.com/736x/32/eb/5b/32eb5b8700325a06af8e936e0c320ce1.jpg" 
                                     alt="avatar" class="rounded-circle profile-img img-fluid" style="width: 150px;">
                                <h5 class="my-3 text-purple">
                                    <asp:Label ID="lblFullName" runat="server" Text="John Doe"></asp:Label>
                                </h5>
                                <p class="text-muted mb-1"><i class="fas fa-user-tag"></i> Library Member</p>
                                <p class="text-muted mb-4"><i class="fas fa-id-card"></i> Membership ID: 
                                    <asp:Label ID="lblProfileMembershipID" runat="server" Text="123456"></asp:Label>
                                </p>
                                <div class="d-flex justify-content-center mb-2">
                                    <asp:Button ID="btnRenew" runat="server" CssClass="btn btn-custom me-2" Text="Renew Membership" />
                                    <asp:Button ID="btnContact" runat="server" CssClass="btn btn-outline-custom" Text="Contact Support" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Profile Details -->
                    <div class="col-lg-8">
                        <div class="card mb-4">
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-sm-3"><p class="mb-0"><i class="fas fa-user"></i> Full Name</p></div>
                                    <div class="col-sm-9">
                                        <p class="text-muted mb-0">
                                            <asp:Label ID="lblName" runat="server" Text="John Doe"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <hr>
                                <div class="row">
                                    <div class="col-sm-3"><p class="mb-0"><i class="fas fa-envelope"></i> Email</p></div>
                                    <div class="col-sm-9">
                                        <p class="text-muted mb-0">
                                            <asp:Label ID="lblEmail" runat="server" Text="johndoe@example.com"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <hr>
                                <div class="row">
                                    <div class="col-sm-3"><p class="mb-0"><i class="fas fa-id-badge"></i> Membership ID</p></div>
                                    <div class="col-sm-9">
                                        <p class="text-muted mb-0">
                                            <asp:Label ID="lblMembershipID" runat="server" Text="123456"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <hr>
                                <div class="row">
                                    <div class="col-sm-3"><p class="mb-0"><i class="fas fa-check-circle"></i> Membership Status</p></div>
                                    <div class="col-sm-9">
                                        <p class="text-muted mb-0">
                                            <asp:Label ID="lblStatus" runat="server" Text="Active"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <hr>
                                <div class="row">
                                    <div class="col-sm-3"><p class="mb-0"><i class="fas fa-envelope-open"></i> Profile Email</p></div>
                                    <div class="col-sm-9">
                                        <p class="text-muted mb-0">
                                            <asp:Label ID="lblProfileEmail" runat="server"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <hr>
<div class="row">
    <div class="col-sm-3">
        <p class="mb-0"><i class="fas fa-lock"></i> Password</p>
    </div>
    <div class="col-sm-9">
        <p class="text-muted mb-0">
            <asp:Label ID="lblPassword" runat="server"></asp:Label>
        </p>
    </div>
</div>
                            </div>
                        </div>

                        <!-- Edit Profile Button -->
                        <div class="text-center">
                            <asp:Button ID="btnEditProfile" runat="server" CssClass="btn btn-warning btn-custom" Text="Edit Profile" OnClick="btnEditProfile_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </section>

        </div>
    </form>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
