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

            <% Response.Write("Use markup"); %>

            <% //its comments no see in browser%>

            <!--this comments will see-->

            <%="<br/>Salam with Markup" %>



            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />



        </div>
    </form>
</body>
</html>
