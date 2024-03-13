using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _gocheokMS_noticeBoard
{
    public partial class mainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            all.Text = "전체";
            third.Text = "3학년";
            second.Text = "2학년";
            first.Text = "1학년";

            selectData(4);
        }

        private void selectData(int g)  // 데이터베이스에서 데이터 불러오기
        {
            ListBox1.Items.Clear();

            string connstr =
                   "Server=PDH_PC\\MSSQLSERVER02;Database=noticed_Board;uid=gocheokNboard_user;pwd=1966gocheok;";

            string query = selectQuery(g); //COUNT(*)  

            List<string> items = new List<string>();

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string item = string.Format($"{reader["ID"]}.    -{reader["Mtitle"]}-    ({reader["Mposted_date"]})    <{reader["Mpostman"]}>");
                items.Add((item != null) ? item : "! 불러오기 오류");
            }

            ListBox1.DataSource = items;
            ListBox1.DataBind();
            conn.Close();
            reader.Close();
        }

        private string selectQuery(int g)
        {
            string query = "";
            switch (g)
            {
                case 1:
                    query = "SELECT * FROM posts where [Mposted_place] = '1학년'";
                    break;
                case 2:
                    query = "SELECT * FROM posts where [Mposted_place] = '2학년'";
                    break;
                case 3:
                    query = "SELECT * FROM posts where [Mposted_place] = '3학년'";
                    break;
                default:
                    query = "SELECT * FROM posts";
                    break;
            }

            return query;
        } // 쿼리

        protected void Button1_Click(object sender, EventArgs e)  // 새글 작성버튼
        {
            string cmd = "~/postPage.aspx";
            Response.Redirect(cmd);
        }

        protected void Button3_Click(object sender, EventArgs e)  // 회원가입 버튼
        {
            Response.Redirect("~/sign_in.aspx");
        }

        protected void all_Click(object sender, EventArgs e)
        {
            first.Text.Replace("*", "");
            second.Text.Replace("*", "");
            third.Text.Replace("*", "");
            all.Text += "*";
        }

        protected void third_Click(object sender, EventArgs e)
        {
            third.Text += "*";
            selectData(3);
        }

        protected void second_Click(object sender, EventArgs e)
        {
            second.Text += "*";
            selectData(2);
        }

        protected void first_Click(object sender, EventArgs e)
        {
            first.Text += "*";
            selectData(1);

            if (first.Text.Length == 16)
            {
                Response.Redirect("https://www.youtube.com/watch?v=haceXrrm-LU&list=RDhaceXrrm-LU&start_radio=1");
            }
        }


        public string selectedPost = "";

        protected void ListBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            /*if (ListBox1.SelectedIndex == -1) return;*/

            selectedPost = ListBox1.SelectedItem.ToString();
            Response.Redirect("~/viewPost.aspx");
            /*Response.Write($"<script>alert(hello world)</script>");*/
        }
    }
}