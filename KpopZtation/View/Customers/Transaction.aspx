<%@ Page Title="" Language="C#" MasterPageFile="~/Master/WebMaster.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="KpopZtation.View.Customers.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Your Transaction History</h1>

    <h2>Total Transaction(s): <%= totalTransaction %></h2>
    <div style="display: flex; flex-direction:row; flex-wrap:wrap">
        <asp:Repeater ID="transactionHeaderList" runat="server">
            <ItemTemplate>
                <div style="display: flex; flex-direction:column; flex: 1 0 25%; margin-right:10px; margin-bottom:10px">
                    <a href="./TransactionDetail.aspx?id=<%# Eval("TransactionID") %>">
                        <div style="border-style:solid; padding: 10px; color:black">
                            <h2>Transaction ID: <%# Eval("TransactionID") %></h2>
                            <h2>Transaction Date: <%# DateTime.Parse(Eval("TransactionDate").ToString()) %></h2>
                         </div>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
