<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtation.View.General.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblRole" runat="server" Text=""></asp:Label>
    <div>

        <% if (role.Equals("Admin"))
            { %>
        <h2>Insert Artist</h2>
        <div>
            <asp:Button ID="btnInsertArtist" runat="server" Text="Insert Artist" OnClick="btnInsertArtist_Click"/>
        </div>
        <%} %>
        <div>
            <h2>Artists List</h2>
            <asp:Label ID="totalArtist" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div style="display: flex; flex-direction:row">
            <asp:Repeater ID="artistList" runat="server">
                <ItemTemplate>
                    <div style="display: flex; flex-direction:column; margin-right:10px">
                        <a href="./ViewArtist.aspx?id=<%# Eval("ArtistID") %>" style="text-decoration:none">
                            <div style="border-style:solid; padding:10px; border-color:black">
                            
                                    <img src="<%# Eval("ArtistImage") %>" height="200" width="200" />
                                    <p style="color: black"><%# Eval("ArtistName") %></p>
                            </div>
                        </a>
                        <% if(role.Equals("Admin")) { %>
                            <div>
                                <asp:Button ID="btnDeleteArtist" runat="server" Text="Delete Artist" CommandName="Delete" CommandArgument='<%# Eval("ArtistID") %>' OnCommand="btnDeleteArtist_Command" UseSubmitBehavior="False" />
                                <asp:Button ID="btnUpdateArtist" runat="server" Text="Update Artist" CommandName="Update" CommandArgument='<%# Eval("ArtistID") %>' OnCommand="btnUpdateArtist_Command" UseSubmitBehavior="False" />
                            </div>
                        <%} %>
                    </div>
                    <br />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
