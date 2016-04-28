<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="ADOTutorial.AddAuthor" MasterPageFile="~/SiteMaster.Master" %>

<asp:Content runat="server" ID="ContentAddAuthor" ContentPlaceHolderID="ContentPlaceHolder1">
    <strong>Add a new author</strong>
    <br />
    <br />
    <table>
        <tr>
            <td>First Name : &nbsp</td>
            <td>
                <asp:TextBox ID="txtfName" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Last Name : &nbsp</td>
            <td>
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Phone : &nbsp</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Address : &nbsp</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>City : &nbsp</td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>State : &nbsp</td>
            <td>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Zip : &nbsp</td>
            <td>
                <asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"><asp:Button ID="btnAdd" runat="server" Text="Add Author" Width="125px" OnClick="btnAdd_Click" /></td> 
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

