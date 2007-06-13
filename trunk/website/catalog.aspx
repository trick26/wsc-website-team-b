<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="catalog.aspx.cs" Inherits="catalog" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetItems"
        TypeName="BLL.CatalogComponent"></asp:ObjectDataSource>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("PhotoThumb") %>' /><br />
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

