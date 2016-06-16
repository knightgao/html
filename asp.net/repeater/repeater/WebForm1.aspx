<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="repeater.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style type="text/css">
        body, div, p, img, h1, h2, h3, h4, h5
        {
            margin:0px; padding:0px;
        }
        .f1
        {
            float:left;
        }
        .fr
        {
            float:right;
        }
        .clr
        {
            clear:both;
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
