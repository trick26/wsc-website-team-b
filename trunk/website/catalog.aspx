<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="catalog.aspx.cs" Inherits="catalog" Title="WSC :: Product Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetItems" TypeName="BLL.CatalogComponent"></asp:ObjectDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" OnItemCommand="DataList1_ItemCommand"
        RepeatColumns="5">
        <ItemTemplate>
            <br />
            <table style="border-top-style: none; border-right-style: none; border-left-style: none;
                border-bottom-style: none">
                <tr>
                    <td colspan="2" style="height: 150px; text-align: center; width: 200px;">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ThumbPhoto") %>' /></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="GetDetails" Text='<%# Eval("Description") %>'></asp:LinkButton></td>
                </tr>
                <tr>
                    <td style="text-align: right;">
                        Price:</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Price") %>'></asp:Label></td>
                </tr>
            </table>
            <asp:HiddenField ID="hiddenItemId" runat="server" Value='<%# Eval("ID") %>' />
            <br />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

