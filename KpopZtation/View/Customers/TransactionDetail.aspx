<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="KpopZtation.View.Customers.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>

    <h2>Transaction ID: <%= transactionId %></h2>

    <h3>Total Item(s) Bought: <%= totalItem %></h3>
    <div style="display: flex; flex-direction:row">
        <asp:Repeater ID="transactionDetailList" runat="server">
            <ItemTemplate>
                <div style="display: flex; flex-direction:column; margin-right:10px; margin-bottom:10px">
                    <div style="border-style:solid; padding: 10px; color:black">
                        <img src="<%# Eval("msAlbum.AlbumImage") %>" width="200" height="200" />
                        <p>Album Name: <%# Eval("msAlbum.AlbumName") %></p>
                        <p>Artist Name: <%# Eval("msAlbum.msArtist.ArtistName") %></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <asp:Button ID="btnBack" runat="server" Text="Back to Transaction History" OnClick="btnBack_Click" />
</asp:Content>
