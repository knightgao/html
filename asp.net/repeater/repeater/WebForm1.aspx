<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="repeater.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style type="text/css">
        html
        {
            background-color: Silver;
        }

        .content
        {
            width: 600px;
            border: soild 1px black;
            background-color: White;
        }

        .movies
        {
            border-collapse: collapse;
        }

            .movies th, .movies td
            {
                padding: 10px;
                border-bottom: 1px solid black;
            }

        .alternating
        {
            background-color: #eeeeee;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="sql">
                <HeaderTemplate>
                    <table class="movies">
                        <tr>
                            <th>Movie Title</th>
                            <th>Movie Director</th>
                            <th>Box Office Totals</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><% %></td>
                        <td><% %></td>
                        <td><% %></td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr class="alternating">
                        <td><%#Eval("Title") %></td>
                        <td><%#Eval("Director") %></td>
                        <td><%#Eval("BoxOfficeTotals","{0:c}") %></td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
