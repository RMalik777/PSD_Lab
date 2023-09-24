<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="KpopZtation.View.Admin.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>
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
            <asp:Button ID="btnInsert" runat="server" Text="Insert Artist" OnClick="btnInsert_Click" />
        </div>
</asp:Content>
