<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestLogin.aspx.cs" Inherits="Project1.View.Guest.GuestLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

            <br />

            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

            <br />

            <asp:CheckBox ID="cbRemember" runat="server" Text="Remember Me" />
            <br />
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
    </form>
</body>
</html>
