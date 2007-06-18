<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" Title="WSC :: My Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Width="90%">
        <h3>
            Change Password:</h3>
        <table>
            <tr>
                <td style="text-align: right">
                    Current Password:</td>
                <td style="width: 3px">
                    <asp:TextBox ID="txtCurrentPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">
                    New Password:</td>
                <td style="width: 3px">
                    <asp:TextBox ID="txtNewPassword1" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">
                    Retype Password:</td>
                <td style="width: 3px">
                    <asp:TextBox ID="txtNewPassword2" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="width: 3px; text-align: center">
                    <asp:Button ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click"
                        Text="Change Password" /></td>
            </tr>
        </table>
        <asp:Label ID="lblPasswordMessage" runat="server" Text="Label" Visible="False"></asp:Label><br />
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" Width="90%">
        <h3>
            Previous Orders:</h3>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetOrdersByClientId"
            TypeName="BLL.OrdersComponent" OnSelecting="ObjectDataSource1_Selecting">
            <SelectParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
            <HeaderTemplate>
                <table style="border-collapse: collapse">
                    <tr>
                        <td style="font-weight: bold; border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid;">
                            Order #
                        </td>
                        <td style="font-weight: bold; border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid;">
                            Date
                        </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid;">
                        <asp:LinkButton runat="server" CommandName="btnOrderNum" OnCommand="Button_Command" Text='<%# Eval("ID") %>' />
                    </td>
                    <td style="border-right: navy 1px solid; border-top: navy 1px solid; border-left: navy 1px solid; border-bottom: navy 1px solid;">
                        <asp:Label runat="server" ID="lblDate" Text='<%# Eval("OrderDate") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </asp:Panel>
</asp:Content>

