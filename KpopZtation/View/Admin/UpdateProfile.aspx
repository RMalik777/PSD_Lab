<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtation.View.Admin.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Your Profile</h1>
    </div>
    <div>
        <asp:Label ID="lblOldName" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblOldEmail" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblOldGender" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
        <asp:RadioButtonList ID="genderRadio" runat="server"></asp:RadioButtonList>
            <asp:RadioButton ID="maleRadio" GroupName="gender" runat="server" Text="Male"/>
            <asp:RadioButton ID="femaleRadio" GroupName="gender" runat="server" Text="Female"/>
        <br />
        <br />

        <asp:Label ID="lblOldAddress" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblOldPassword" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        
        <br />
        <asp:Button ID="updateBtn" runat="server" Text="Register" OnClick="updateBtn_Click" />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <h2>Delete Account</h2>
        <p>Warning: Once you delete your account, it will be permanent and can't be undone!</p>
    </div>

    <div id="deleteAccount">
        <asp:Button ID="btnDeleteAccount" runat="server" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
    </div>
</asp:Content>
