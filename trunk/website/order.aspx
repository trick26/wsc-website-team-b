<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="order" Title="WSC :: Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlTopLabels" runat="server" Width="90%">
        <h3>
        Please verify your order:</h3>
    </asp:Panel>
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
                    <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>&nbsp;
                </td>
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
                <td>
                </td>
                <td style="text-align: right">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtDetails" runat="server" Columns="75" ReadOnly="True" Rows="4"
                        TextMode="MultiLine"></asp:TextBox></td>
                <td>
                </td>
                <td style="text-align: right">
                    <br />
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    <br />
    &nbsp;<asp:Panel ID="pnlSuccess" runat="server" Visible="False" Width="90%">
        <asp:Label ID="lblOrderSuccess" runat="server" Font-Bold="True" ForeColor="Maroon"
            Text="Your order has been successfully submitted!"></asp:Label><br />
        <asp:Label ID="lblOrderNumLabel" runat="server" ForeColor="Maroon" Text="Your order #:"></asp:Label>
        <asp:Label ID="lblOrderNum" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:Panel>
    <asp:Panel ID="pnlCC" runat="server" Width="90%">
        <table>
            <tr>
                <td colspan="2" style="font-weight: bold">
                    Credir Card Information:</td>
                <td colspan="1" style="width: 100px">
                </td>
                <td colspan="1" style="font-weight: bold">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
            <tr style="color: #000000">
                <td>
                    Name on card:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Card type:</td>
                <td>
                    <asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="VISA">Visa</asp:ListItem>
                        <asp:ListItem Value="MC">Mastercard</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Card number:</td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Expiration date:</td>
                <td>
                    <asp:DropDownList ID="ddlMonth" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="01">01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlYear" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnOrder" runat="server" Font-Bold="True" ForeColor="Maroon" OnClick="btnOrder_Click"
                        Text="Place Order" /></td>
                <td style="width: 100px">
                </td>
                <td>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False" Font-Bold="True" ForeColor="Red"></asp:Label></asp:Panel>
</asp:Content>

