<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="learn_asp_dot_net_bytepp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="Main.aspx" method="post">
        <div>
            
            <!--
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Product.aspx?id=1" runat="server">Book</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Product.aspx?id=2" runat="server">Car</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Product.aspx?id=3" runat="server">Phone</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Product.aspx?id=4" runat="server">Pen</asp:HyperLink>
            -->

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            &nbsp
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
            &nbsp
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Continue" />

        </div>
    </form>
</body>
</html>
