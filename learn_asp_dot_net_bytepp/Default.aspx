<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="learn_asp_dot_net_bytepp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" Width="500px" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label">Salam</asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" Height="500px" runat="server" OnClick="Button2_Click" Text="Clear Label1" />


        </div>
    </form>
</body>
</html>
