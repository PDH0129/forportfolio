using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _gocheokMS_noticeBoard
{
    public partial class viewPost : System.Web.UI.Page
    {
        mainPage mp = new mainPage();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write($"<script>alert({mp.selectedPost})</script>");
        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mainPage.aspx");
        }
    }
}