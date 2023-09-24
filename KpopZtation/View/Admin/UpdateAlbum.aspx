<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="KpopZtation.View.Admin.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Album</h1>
        <div>
            <p style="font-weight:bold">Current Album Name:</p>
            <asp:Label ID="lblAlbumNameCurrent" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p style="font-weight:bold">Current Album Image:</p>
            <asp:Image ID="imgAlbumImageCurrent" runat="server" Width="100" Height="100"/>
        </div>
        <div>
            <p style="font-weight:bold">Current Album Description:</p>
            <asp:Label ID="lblAlbumDescriptionCurrent" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p style="font-weight:bold">Current Album Price:</p>
            <asp:Label ID="lblAlbumPriceCurrent" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p style="font-weight:bold">Current Album Stock:</p>
            <asp:Label ID="lblAlbumStockCurrent" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />

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
            <asp:Button ID="btnUpdateAlbum" runat="server" Text="Update Album" OnClick="btnUpdateAlbum_Click" />
        </div>
</asp:Content>
