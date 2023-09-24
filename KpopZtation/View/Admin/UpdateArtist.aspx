<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="KpopZtation.View.Admin.UpdateArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Artist</h1>
        <div>
            <asp:Label ID="lblArtistName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Image ID="imgArtistImage" runat="server"/>
        </div>

        <div>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:FileUpload ID="fileImage" runat="server" />
        </div>

        <br />

        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnUpdate" runat="server" Text="Update Artist" OnClick="btnUpdate_Click" />
        </div>

        <br />

        <div>
            <asp:Button ID="btnHome" runat="server" Text="Back to Home" OnClick="btnHome_Click"/>
        </div>
</asp:Content>
