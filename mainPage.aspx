<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainPage.aspx.cs" Inherits="_gocheokMS_noticeBoard.mainPage" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Hello, World</title>
    <link rel="stylesheet" href="gocheokMSStyleSheet.css" />
    <script src="buttonFixing.js"></script>
</head>
<body>
    <form id="form1" runat="server">


        <nav class="up_Bar">
            <div class="logo">
                <img src="https://gocheok.sen.ms.kr/dggb/module/file/selectImageView.do?atchFileId=134463&fileSn=0" />
            </div>
        </nav>

        <div class="signin_wrap">
            <asp:Button ID="Button3" runat="server" Text="회원가입" CssClass="signBtn" OnClick="Button3_Click" />
        </div>

        <div class="main_board" runat="server" id="mainBoard">

            <div class="gradebtn_wrap">
                <asp:Button class="grade" ID="all" runat="server" Text="전체" OnClick="all_Click" />
                <asp:Button class="grade" ID="third" runat="server" Text="3학년" OnClick="third_Click" />
                <asp:Button class="grade" ID="second" runat="server" Text="2학년" OnClick="second_Click" />
                <asp:Button class="grade" ID="first" runat="server" Text="1학년" OnClick="first_Click" />
            </div>

            <div class="contents_wrap">
                <asp:ListBox ID="ListBox1" runat="server" Height="367px" Font-Size="24px" Font-Italic="true" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged1" Width="954px" AutoPostBack="True" ></asp:ListBox>
            </div>
        </div>

        <div class="btn_wrap">
            <asp:Button ID="Button1" runat="server" Text="글쓰기" CssClass="post" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
