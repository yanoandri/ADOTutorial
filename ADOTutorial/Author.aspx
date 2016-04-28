<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMaster.Master" CodeBehind="Author.aspx.cs" Inherits="ADOTutorial.Author" %>

<asp:Content ID="ContentViewAuthor" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <strong>List of Authors</strong><br />
    <br />
    Select State&nbsp;
    <asp:DropDownList ID="ddlSelect" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSelect_SelectedIndexChanged">
    </asp:DropDownList><br />
    <asp:GridView ID="GridAuthor" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EnableViewState="False">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <EditRowStyle BackColor="#999999" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</asp:Content>
