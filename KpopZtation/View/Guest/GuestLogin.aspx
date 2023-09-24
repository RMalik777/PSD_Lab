<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="GuestLogin.aspx.cs" Inherits="KpopZtation.View.Guest.GuestLogin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
