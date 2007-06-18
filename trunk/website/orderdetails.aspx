<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="orderdetails.aspx.cs" Inherits="orderdetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table>
        <tr>
            <td style="font-weight: bold">
                Order #:</td>
            <td>
                <asp:Label ID="lblOrderNum" runat="server" Text="Label"></asp:Label></td>
            <td style="width: 50px">
            </td>
            <td style="font-weight: bold">
                Date:</td>
            <td>
                <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
    <br />
    <div style="width: 90%">
        <table style="border-top-width: 1px; border-left-width: 1px; border-left-color: navy;
            border-bottom-width: 1px; border-bottom-color: navy; width: 100%; border-top-color: navy;
            border-collapse: collapse; border-right-width: 1px; border-right-color: navy">
            <tr>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; font-weight: bold;
                    border-left: navy 1px solid; border-bottom: navy 1px solid">
                    Item</td>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; font-weight: bold;
                    border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right">
                    Price</td>
            </tr>
            <tr>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid;
                    border-bottom: navy 1px solid">
                    <asp:Image ID="imgThumbPhoto" runat="server" Height="35px" ImageAlign="AbsMiddle"
                        Width="35px" />
                    &nbsp;
                    <asp:LinkButton ID="btnDescription" runat="server">LinkButton</asp:LinkButton></td>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid;
                    border-bottom: navy 1px solid; text-align: right">
                    <asp:Label ID="lblItemPrice" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; font-weight: bold;
                    border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right">
                    Total:</td>
                <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid;
                    border-bottom: navy 1px solid; text-align: right">
                    <asp:Label ID="lblTotalPrice" runat="server" Font-Bold="True" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right">
                </td>
            </tr>
        </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td style="font-weight: bold">
                    Your special ordering instructions:</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDetails" runat="server" Columns="75" ReadOnly="True" Rows="4"
                        TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
    </div>
</asp:Content>

