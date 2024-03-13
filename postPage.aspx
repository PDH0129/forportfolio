<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postPage.aspx.cs" Inherits="_gocheokMS_noticeBoard.postPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="gocheokMSStyleSheet.css" />
    <style type="text/css">
        .btnPost {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <nav class="up_Bar">
            <div class="logo">
                <img src="https://gocheok.sen.ms.kr/dggb/module/file/selectImageView.do?atchFileId=134463&fileSn=0" />
            </div>
        </nav>

        <div class="board_wrap">
            <div class="board_write_wrap">
                <div class="board_write">
                    <div class="title">
                        <dl>
                            <dt>제목</dt>
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="글자제한 (25자)"></asp:TextBox>
                        </dl>
                    </div>
                    <div class="info">
                        <dl>
                            <dt>학번 </dt>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </dl>
                        <dl>
                            <dt>비밀번호</dt>
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                        </dl>
                        <select id="post_place" runat="server">
                            <option>1학년</option>
                            <option>2학년</option>
                            <option>3학년</option>
                        </select>
                    </div>
                    <div class="cont">
                        <textarea placeholder="내용 입력" id="txtContent" runat="server"></textarea>
                    </div>
                </div>
            </div>
        </div>
        <div class="btn_wrap">
            <asp:Button ID="Button1" runat="server" Text="새글 등록" CssClass="btnPost" Height="42px" Width="112px" OnClick="Button1_Click" />
        </div>

    </form>

</body>
</html>
