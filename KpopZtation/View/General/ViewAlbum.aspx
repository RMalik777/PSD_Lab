<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="ViewAlbum.aspx.cs" Inherits="KpopZtation.View.General.ViewAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Album Detail</h1>

    <img src="<%= albumImage %>" width="200" height="200" />
    <div>
        <h2>Album Name:</h2>
        <p><%=albumName %></p>
    </div>

    <div>
        <h2>Artist Name</h2>
        <p><%= artistName %></p>
    </div>

    <div>
        <h2>Album Price:</h2>
        <p><%=albumPrice %></p>
    </div>

    <div>
        <h2>Album Stock:</h2>
        <p><%=albumStock %></p>
    </div>

    <div>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />
    </div>
</asp:Content>
