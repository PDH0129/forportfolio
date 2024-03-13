using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace _gocheokMS_noticeBoard
{
    public partial class sign_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim() == "" || TextBox3.Text.Trim() == "" || TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('{체크 안 된게 있나 확인해주세요!!}');</script>");
                return;
            }

            TextBox2.Text.Replace(" ", "");

            SqlCommand comm;
            SqlConnection conn;
            try
            {
                string connstr =
                    "Server=PDH_PC\\MSSQLSERVER02;Database=noticed_Board;uid=gocheokNboard_user;pwd=1966gocheok;";
                string sql = "insert into MUser(MstudentID, Mname, Mclassroom, Mgrade, Mpwd) values(@MstudentID, @Mname, @Mclassroom, @Mgrade, @Mpwd)";

                conn = new SqlConnection(connstr);
                conn.Open();

                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@MstudentID", int.Parse(TextBox3.Text.Trim()));
                comm.Parameters.AddWithValue("@Mname", TextBox1.Text.Trim());
                comm.Parameters.AddWithValue("@Mclassroom", sclass.Value);
                comm.Parameters.AddWithValue("@Mgrade", int.Parse(sgrade.Value));
                comm.Parameters.AddWithValue("@Mpwd", TextBox2.Text.Trim());

                comm.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('회원가입이 완료되었습니다.');</script>");
                Response.Redirect("~/mainPage.aspx");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('{ex.Message}');</script>");
                /*return*/;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mainPage.aspx");
        }
    }
}