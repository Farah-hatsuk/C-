<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit book.aspx.cs" Inherits="_27_1_2025.edit_book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>ID:</label>
            <asp:TextBox ID="bookId" runat="server"></asp:TextBox>
            <asp:Button ID="search" runat="server" Text="search" OnClick="search_Click" />
            <asp:Label ID="searchRes" runat="server"></asp:Label>
            <br />
            <br />
            <label>name:</label>
            <asp:TextBox ID="bookName" runat="server"></asp:TextBox>
            <label>type:</label>
            <asp:TextBox ID="bookType" runat="server"></asp:TextBox>
            <label>level:</label>
            <asp:TextBox ID="bookLevel" runat="server"></asp:TextBox>

            <asp:Button ID="edit" runat="server" Text="edit" OnClick="edit_Click" />

        </div>
    </form>
</body>
</html>
