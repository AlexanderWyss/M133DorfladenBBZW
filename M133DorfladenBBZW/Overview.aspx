<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="M133DorfladenBBZW.Overview" %>
<%@ Import Namespace="M133DorfladenBBZW" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Styles/overview.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <h1 class="title">Aktionen</h1>
        <asp:Repeater ID="items" runat="server">
            <ItemTemplate>
                <div class="itemContainer">
                    <asp:Image CssClass="itemImage" runat="server" ImageUrl='<%# GetImage(Eval("imageName"))%>'/>
                    <br/>
                    <asp:Label CssClass="itemName" runat="server"><%# Eval("productName") %></asp:Label>
                    <br/>
                    <asp:Label CssClass="itemSpecialPrice itemPrice" runat="server">CHF <%# Eval("specialOffer") %></asp:Label>
                    <asp:Label CssClass="itemNormalPrice itemPrice" runat="server">CHF <%# Eval("normalPrice") %></asp:Label>
                </div>
                </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
