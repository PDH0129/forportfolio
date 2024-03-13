<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign_in.aspx.cs" Inherits="_gocheokMS_noticeBoard.sign_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="gocheokMSStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">

        <nav class="up_Bar">
            <div class="logo">
                <img src="https://gocheok.sen.ms.kr/dggb/module/file/selectImageView.do?atchFileId=134463&fileSn=0" />
            </div>
        </nav>

        <div class="info_board">
            <p id="f">고척중학교 게시판</p>
            <p id="s">'회원가입 페이지입니다.'</p>
        </div>

        <div class ="signin_board">
            <div class="Sname">
                <dl>
                    <dt>이름</dt>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </dl>
            </div>
            
            <div class="Sgrade">
                <div class ="Sgrade_wrap">
                    <p >학년</p>
                    <select id="sgrade" runat="server">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                    </select>
                       
                    <p>반</p>
                    <select id="sclass" runat="server">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                        <option>6</option>
                        <option>7</option>
                        <option>8</option>
                        <option>9</option>
                        <option>10</option>
                        <option>11</option>
                    </select>
                    
                </div>
            </div>
            <div class="SstudentID">
                <dl>
                    <dt>학번</dt>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </dl>
            </div>

            <div class="Spwd_wrap">
                <p>비밀번호</p>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="Spwd" TextMode="Password"></asp:TextBox>
            </div>

        </div>

        <div class="btn_wrap">
            <asp:Button ID="Button1" runat="server" Text="회원가입" CssClass="btn_Signin" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="취소" CssClass="btn_cancel" OnClick="Button2_Click"/>
            <p style="font-size:15px; color: gray;">*불건전하거나 타인에게 불쾌감을 주는 비밀번호, 게시글 
                또는 형식에 맞지않는 이름등을 관리하기 위해 개발자가 데이터베이스를 열어볼 수 있다는 점을
                알립니다.*
            </p>
        </div>
    </form>
</body>
</html>
