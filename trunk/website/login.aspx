<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="login.aspx.cs"
    Inherits="login" Title="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <h3>Please Login:</h3>
    </div>
    <div>
        <table style="border-top-style: none; border-right-style: none; border-left-style: none;
            border-bottom-style: none">
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblNotValid" runat="server" Text="User Name and/or Password is not valid!"
            Visible="False"></asp:Label>&nbsp;
        <asp:Label ID="lblEmptyTextBox" runat="server" Text="User Name and/or Password cannot be blank!"
            Visible="False"></asp:Label></div>
</asp:Content>
