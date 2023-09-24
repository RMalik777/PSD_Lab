<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtation.View.Admin.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Album</h1>

        <div>
            <asp:Label ID="lblAlbumName" runat="server" Text="Album Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox>
        </div>

        <br />
        
        <div>
            <asp:Label ID="lblAlbumDescription" runat="server" Text="Album Description"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlbumDescription" runat="server"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="lblAlbumPrice" runat="server" Text="Album Price"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlbumPrice" runat="server"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="lblAlbumStock" runat="server" Text="Album Stock"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlbumStock" runat="server"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="lblAlbumImage" runat="server" Text="Album Image"></asp:Label>
            <br />
            <asp:FileUpload ID="fuAlbumImage" runat="server" />
        </div>

        <br />

        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnInsertAlbum" runat="server" Text="Insert Album" OnClick="btnInsertAlbum_Click" />
        </div>
</asp:Content>
