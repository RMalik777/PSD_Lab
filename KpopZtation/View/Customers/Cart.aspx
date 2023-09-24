<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="KpopZtation.View.Customers.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Your Cart</h1>

    <h2>Total Album(s): <%= totalAlbum %></h2>
    <div style="display: flex; flex-direction:row">
        <asp:Repeater ID="cartList" runat="server">
            <ItemTemplate>
                <div style="display: flex; flex-direction:column; margin-right:10px; margin-bottom:10px">
                    <div style="border-style:solid; padding: 10px; color:black">
                        <img src="<%# Eval("msAlbum.AlbumImage") %>" height="200" width="200"/>
                        <h2><%# Eval("msAlbum.AlbumName") %></h2>
                        <p><%# Eval("msAlbum.AlbumPrice") %></p>
                        <p>Quantity: <%# Eval("Quantity") %></p>
                     </div>
                    <asp:Button ID="btnRemove" runat="server" Text="Remove from Cart" CommandName="Remove" CommandArgument='<%# Eval("msAlbum.AlbumID") %>' OnCommand="btnRemove_Command" UseSubmitBehavior="False" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <%  %>

    <asp:Label ID="lblSuccess" runat="server" Text=""></asp:Label>
    <% if (totalAlbum >= 1)
        { %>
    <h2>Total Price: <%= totalPrice %></h2>
    <div>
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
    </div>
    <% }
        else
        { %>
        <h2>There is no album in your cart!</h2>
    <% } %>
</asp:Content>
