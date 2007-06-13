<%@ Page Language="C#" MasterPageFile="~/Master1.master" AutoEventWireup="true" CodeFile="itemdetails.aspx.cs" Inherits="itemdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetItemById"
        TypeName="BLL.CatalogComponent">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="item" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    &nbsp;
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" OnItemCommand="FormView1_ItemCommand">
        <ItemTemplate>
            <div style="float: left; margin-bottom: 1em; margin-left: 1em; margin-right: 1em">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Photo") %>' /></div>
            <div>
                        <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>' Font-Bold="True"></asp:Label><br />
                <br />
                        Price:
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Price", "{0:C}") %>'></asp:Label><br />
                <br />
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Notes") %>'></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" CommandName="AddToCart" Text="Add to Cart" />
                <asp:HiddenField ID="hiddenItemId" runat="server" Value='<%# Eval("ID") %>' />
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            Photo:
            <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>'>
            </asp:TextBox><br />
            ThumbPhoto:
            <asp:TextBox ID="ThumbPhotoTextBox" runat="server" Text='<%# Bind("ThumbPhoto") %>'>
            </asp:TextBox><br />
            Notes:
            <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>'>
            </asp:TextBox><br />
            ID:
            <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>'>
            </asp:TextBox><br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>'>
            </asp:TextBox><br />
            Description:
            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>'>
            </asp:TextBox><br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                Text="Update">
            </asp:LinkButton>
            <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                Text="Cancel">
            </asp:LinkButton>
        </EditItemTemplate>
        <InsertItemTemplate>
            Photo:
            <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>'>
            </asp:TextBox><br />
            ThumbPhoto:
            <asp:TextBox ID="ThumbPhotoTextBox" runat="server" Text='<%# Bind("ThumbPhoto") %>'>
            </asp:TextBox><br />
            Notes:
            <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>'>
            </asp:TextBox><br />
            ID:
            <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>'>
            </asp:TextBox><br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>'>
            </asp:TextBox><br />
            Description:
            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>'>
            </asp:TextBox><br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                Text="Insert">
            </asp:LinkButton>
            <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                Text="Cancel">
            </asp:LinkButton>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>

