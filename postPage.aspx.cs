using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _gocheokMS_noticeBoard
{
    public partial class postPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region 빈칸처리
            if (txtContent.Value.Trim() == "")
            {
                Response.Write("<script>alert('빈 글은 허용할 수 없습니다.');</script>");
                return;
            }

            if (TextBox1.Text.Trim() == "")
            {
                Response.Write("<script>alert('이게 뭐에요?');</script>");
                return;
            }

            if (TextBox2.Text.Trim() == "" || TextBox3.Text.Trim() == "")
            {
                Response.Write("<script>alert('누구세요?');</script>");
                return;
            }
            #endregion

            string connstr =
                    "Server=PDH_PC\\MSSQLSERVER02;Database=noticed_Board;uid=gocheokNboard_user;pwd=1966gocheok;";
            string sqlQuery = "INSERT INTO posts (Mtitle, Mcontents, Mposted_date, Mpostman, Mposted_place) VALUES (@제목, @내용, @날짜, @글쓴이, @장소)";
            string poster = SName();
            if(poster== null)
            {
                Response.Write("<script>alert('누구세요?');</script>");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connstr))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        // 매개 변수 추가
                        command.Parameters.AddWithValue("@제목", TextBox1.Text.Trim());
                        command.Parameters.AddWithValue("@내용", txtContent.Value.Trim());
                        command.Parameters.AddWithValue("@날짜", DateTime.Now);
                        command.Parameters.AddWithValue("@글쓴이", poster);
                        command.Parameters.AddWithValue("@장소", post_place.Value);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Response.Write("<script>alert('회원가입이 완료되었습니다.');</script>");
                        Response.Redirect("~/mainPage.aspx");
                    }
                    catch (Exception ex)
                    {
                        Response.Write($"<script>alert({ex.Message});</script>");
                        // return;
                    }
                }
            }
        }

        protected string SName()
        {
            string connstr =
                    "Server=PDH_PC\\MSSQLSERVER02;Database=noticed_Board;uid=gocheokNboard_user;pwd=1966gocheok;";
            string query = "SELECT * FROM MUser WHERE [MstudentID]=@MstudentID AND [Mpwd]=@Mpwd";
            string Mname = null;
            
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@MstudentID", TextBox2.Text.Trim());
            comm.Parameters.AddWithValue("@Mpwd", TextBox3.Text.Trim()); 
            
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                Mname = reader["Mname"].ToString();
            }
            reader.Close();

            conn.Close();
            return Mname;
        }
    }
}