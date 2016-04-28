<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMaster.Master" CodeBehind="AddTitle.aspx.cs" Inherits="ADOTutorial.AddTitle" %>

<asp:Content ID="ContentAddTitle" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <strong>Add a new author</strong>
    <br />
    <br />
    <table>
        <tr>
            <td>Title : &nbsp</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Type : &nbsp</td>
            <td>
                <asp:TextBox ID="txtType" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Publisher : &nbsp</td>
            <td>
                <asp:DropDownList ID="ddlPublisher" runat="server">
                    <asp:ListItem Text="--Select One--" Value="0" />
                </asp:DropDownList><br />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Price : &nbsp</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Advance : &nbsp</td>
            <td>
                <asp:TextBox ID="txtAdvance" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Royalty : &nbsp</td>
            <td>
                <asp:TextBox ID="txtRoyalty" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>ytd : &nbsp</td>
            <td>
                <asp:TextBox ID="txtYtd" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Notes : &nbsp</td>
            <td>
                <asp:TextBox ID="txtNotes" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Button ID="btnAdd" runat="server" Text="Add Author" Width="125px" OnClick="btnAdd_Click" /></td>
            <td class="auto-style1"></td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }
    </style>
</asp:Content>
