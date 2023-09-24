<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="ViewArtist.aspx.cs" Inherits="KpopZtation.View.General.ViewArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>
        <div>
            <asp:Label ID="lblArtistName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Image ID="imgArtistImage" runat="server"/>
        </div>

        <h2>Album List</h2>
        <asp:Label ID="totalAlbum" runat="server" Text=""></asp:Label>
        
        <br />
        <br />
        <% if(role.Equals("Admin")) { %>
            <div>
                <asp:Button ID="btnInsertAlbum" runat="server" Text="Insert Album" OnClick="btnInsertAlbum_Click" />
            </div>
        <%} %>
        <br />
        <br/>
        <div style="display: flex; flex-direction:row">
            <asp:Repeater ID="albumList" runat="server">
                <ItemTemplate>
                    <div style="display: flex; flex-direction:column; margin-right:10px">
                        <% if (role.Equals("Customer"))
                            { %>
                            <a href="../General/ViewAlbum.aspx?id=<%# Eval("AlbumID") %>">
                                <div style="border-style:solid; padding: 10px; color:black">
                                    <img src="<%# Eval("AlbumImage") %>" height="200" width="200"/>
                                    <h2><%# Eval("AlbumName") %></h2>
                                    <p><%# Eval("AlbumDescription") %></p>
                                    <p><%# Eval("AlbumPrice") %></p>
                                </div>
                            </a>
                        <%}
                            else
                            { %>

                        <div style="border-style:solid; padding: 10px">
                            <img src="<%# Eval("AlbumImage") %>" height="200" width="200"/>
                            <h2><%# Eval("AlbumName") %></h2>
                            <p><%# Eval("AlbumDescription") %></p>
                            <p><%# Eval("AlbumPrice") %></p>
                        </div>
                        <%} %>

                        <% if (role.Equals("Admin"))
                            { %>
                        <div>
                            <asp:Button ID="btnDeleteAlbum" runat="server" Text="Delete Album" CommandName="Delete" CommandArgument='<%# Eval("AlbumID") %>' OnCommand="btnDeleteAlbum_Command" UseSubmitBehavior="False" />
                            <asp:Button ID="btnUpdateAlbum" runat="server" Text="Update Album" CommandName="Update" CommandArgument='<%# Eval("AlbumID") %>' OnCommand="btnUpdateAlbum_Command" UseSubmitBehavior="False" />
                        </div>

                        <% } %>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
</asp:Content>
