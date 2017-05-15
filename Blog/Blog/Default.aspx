<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic WebComic</title>
    <link href="~/Content/bootstrap.css" rel="stylesheet" runat="server" id="styleLinkBootstrap"/>
    <link rel="stylesheet" type="text/css" href="~/Content/style.css" runat="server"/>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">
                <asp:Label Text="text" runat="server" ID="comicTitle" CssClass="center-block text-center"/> <br />
                <asp:Image ImageUrl="imageurl" runat="server" ID="comicImage" CssClass="center-block text-center"/><br />
                <asp:Label Text="text" runat="server" ID="comicBlogPost" CssClass="center-block text-center"/><br />
                <div class="center-block text-center">
                    <asp:ImageButton ImageUrl="imageurl" runat="server" ID="moveToOldestButton" OnClick="moveToOldestButton_Click"/> 
                    <asp:ImageButton ImageUrl="imageurl" runat="server" ID="moveBackButton" OnClick="moveBackButton_Click"/> 
                    <asp:ImageButton ImageUrl="imageurl" runat="server" ID="moveForwardButton" OnClick="moveForwardButton_Click"/> 
                    <asp:ImageButton ImageUrl="imageurl" runat="server" ID="moveToMostRecenButton" OnClick="moveToMostRecenButton_Click"/> <br />
                </div>
                <asp:DropDownList ID="comicList" runat="server" CssClass="center-block text-center" AutoPostBack="true" OnSelectedIndexChanged="comicList_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="col-md-1"></div>
        </div>
    </div>
    </form>
</body>
</html>
