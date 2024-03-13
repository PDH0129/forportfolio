<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewPost.aspx.cs" Inherits="_gocheokMS_noticeBoard.viewPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="gocheokMSStyleSheet.css" />
    <title></title>
    <style type="text/css">
        #txtContent {
            height: 369px;
            width: 954px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="up_Bar">
                <div class="logo">
                    <img src="https://gocheok.sen.ms.kr/dggb/module/file/selectImageView.do?atchFileId=134463&fileSn=0" />
                </div>
            </nav>

            <div class="post_board">
                <div class="post_wrap">

                    <div class="title">
                        <dl>
                            <dt>제목</dt>
                            <asp:TextBox ID="Mtitle" runat="server" ReadOnly="true" Height="31px" Width="331px"></asp:TextBox>
                        </dl>
                    </div>

                    <div class="info">
                        <dl>
                            <dt>글쓴이 </dt>
                            <asp:TextBox ID="post_man" runat="server" ReadOnly="true" Height="17px" Width="142px"></asp:TextBox>
                        </dl>

                        <asp:Label ID="lblposted_date" runat="server" Text="Label" Enabled="False" CssClass="postdate"></asp:Label>
                    </div>

                    <textarea id="txtContent" runat="server" readonly="readonly"></textarea>

                </div>
            </div>

            <div class="btn_wrap">
                <asp:Button ID="btn_OK" runat="server" Text="확인" Height="43px" Width="94px" Font-Size="25px" BackColor="#2a2a2a" BorderColor="White" ForeColor="White"/>
            </div>
        </div>
    </form>
</body>
</html>
