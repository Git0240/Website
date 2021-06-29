using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.MyTable;
using NTT.ProcessDB;
using NTT.ProcessDB.Insert;

public partial class ThemGioHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Process_ThemGioHang xulygiohang = new Process_ThemGioHang();
        GioHang giohang = new GioHang();
        giohang.IdSanPham = int.Parse(Request.QueryString["IDsanpham"]);
        giohang.CartGuid = CartGUID;
        giohang.SoLuong = 1;
        xulygiohang.Giohang = giohang;
        try
        {
            xulygiohang.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        Response.Redirect("GioHang.aspx");
    }
    
    private String CartGUID 
    {
        get { return TaoCartGUID.LayCartGUID(); }
    }
}