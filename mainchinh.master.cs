using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mainchinh : System.Web.UI.MasterPage
{
    public void Set_Title_Page() 
    {
        string pageName = this.Page.ToString().Substring(4, this.Page.ToString().Substring(4).Length - 5).ToLower();
        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"JavaScript\">alert(\"" + this.Page.ToString().Substring(4) + "\")</SCRIPT>");
        switch (pageName)
        {            
            case "gioithieu":
                this.title_main_page.Text = "Giới thiệu - Bán hàng Online - ĐH NTT";
                break;
            case "lienhe":
                this.title_main_page.Text = "Liên Hệ - Bán hàng Online - ĐH NTT";
                break;
            default:
                this.title_main_page.Text = "Trang chủ - Bán hàng Online - ĐH NTT";
                break;
        }
       
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Set_Title_Page();
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        if (Request.Cookies["ReturnURL"] != null)
        {
            Response.Cookies["ReturnURL"].Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("DangNhap.aspx");
    }
}
