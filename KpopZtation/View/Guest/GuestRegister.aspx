<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="GuestRegister.aspx.cs" Inherits="KpopZtation.View.Guest.GuestRegister1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" TextMode="SingleLine"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
        <asp:RadioButtonList ID="genderRadio" runat="server"></asp:RadioButtonList>
            <asp:RadioButton ID="maleRadio" GroupName="gender" runat="server" Text="Male"/>
            <asp:RadioButton ID="femaleRadio" GroupName="gender" runat="server" Text="Female"/>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" TextMode="SingleLine"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
