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




            <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="Holder">
                <LayoutTemplat></LayoutTemplat>
                <p>1234</p>
                <p runat="server" id="Holder"></p>

                <ItemTemplate></ItemTemplate>
            </asp:ListView>




        </div>
    </form>
</body>
</html>
