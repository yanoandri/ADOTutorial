<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMaster.Master" CodeBehind="Title.aspx.cs" Inherits="ADOTutorial.Title" %>

<asp:Content runat="server" ID="titleContainer" ContentPlaceHolderID="ContentPlaceHolder1">
      <strong>List of Titles<br />
        <br />
        Select Publisher:
        <asp:DropDownList ID="ddlPublisher" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPublisher_SelectedIndexChanged">
             <asp:ListItem Text="--Select One--" Value="0" />
        </asp:DropDownList></strong><br />
    <br />
    <asp:GridView ID="gridTitle" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EnableViewState="False">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <EditRowStyle BackColor="#999999" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</asp:Content>
