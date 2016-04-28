<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewEmployee.aspx.cs" Inherits="ADOTutorial2.AddNewEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
        <strong>Add a New Employee<br />
        </strong>
        <br />
        <table style="width: 320px">
            <tr>
                <td>
                    LastName</td>
                <td>
                    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    FirstName</td>
                <td>
                    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Title</td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Region</td>
                <td>
                    <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    PostalCode</td>
                <td>
                    <asp:TextBox ID="txtCode" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Country</td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Extension</td>
                <td>
                    <asp:TextBox ID="txtExtension" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        &nbsp; &nbsp;
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" /></div>
    </form>
</body>
</html>
