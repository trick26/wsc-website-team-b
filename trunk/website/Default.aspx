<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true"  CodeFile="default.aspx.cs" Inherits="_Default" Title="Williams Specialty Company" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Welcome to Williams Specialty Company!<br />
    <br />
    Please see our
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="catalog.aspx">catalog</asp:HyperLink>
    and browse our available products!

</asp:Content>
