<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<div style="width: 90%">
    <table style="border-top-width: 1px; border-left-width: 1px; border-left-color: navy; border-bottom-width: 1px; border-bottom-color: navy; border-top-color: navy; border-collapse: collapse; border-right-width: 1px; border-right-color: navy; width: 100%;">
        <tr>
            <td style="font-weight: bold; border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid;">
                Item</td>
            <td style="font-weight: bold; border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right;">
                Price</td>
        </tr>
        <tr>
            <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid">
                <asp:Image ID="imgThumbPhoto" runat="server" Height="35px" ImageAlign="AbsMiddle" Width="35px" />
                <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="lblEmptyCart" runat="server" Font-Bold="True" Text="Your Shopping Cart is empty!"
        Visible="False"></asp:Label>
</td>
            <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right">
                <asp:Label ID="lblItemPrice" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="border-right: navy 1px solid; border-top: navy 1px solid; font-weight: bold; border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right;">
                Total:</td>
            <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid; text-align: right">
                <asp:Label ID="lblTotalPrice" runat="server" Font-Bold="True" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align: right" colspan="2">
            </td>
        </tr>
    </table>
        <br />
        <table style="width: 100%">
            <tr>
                <td style="font-weight: bold">
                    Please specify any ordering instructions:</td>
                <td>
                </td>
                <td style="text-align: right">
                    &nbsp;<asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Order Now" /></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDetails" runat="server" Columns="75" Rows="4" TextMode="MultiLine"></asp:TextBox></td>
                <td>
                </td>
                <td style="text-align: right">
                    <asp:Button ID="btnSaveCart" runat="server" OnClick="btnSaveCart_Click" Text="Save Cart" /></td>
            </tr>
        </table>
        <asp:HiddenField ID="hiddenItemId" runat="server" />
    </div>
</asp:Content>

