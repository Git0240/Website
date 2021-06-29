using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.MyTable;
using NTT.ProcessDB;
using NTT.ProcessDB.Select;

public partial class QLGioHang : System.Web.UI.Page
{
    private int _tongtien;
    protected void Page_Load(object sender, EventArgs e)
    {
        gridgiohang.PageSize = 10;
        if (!IsPostBack)
        {
            HienThiGioHang();
        }        
    }
    private void HienThiGioHang()
    {
        GioHang giohang = new GioHang();
        giohang.CartGuid = CartGUID;
        LayDuLieuGioHang laygiohang = new LayDuLieuGioHang();
        laygiohang.Giohang = giohang;
        try
        {
            laygiohang.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        gridgiohang.DataSource = laygiohang.Ketqua;
        gridgiohang.DataBind();
    }
    private String CartGUID
    {
        get { return TaoCartGUID.LayCartGUID(); }
    }
    protected void gridgiohang_RowDataRound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            _tongtien += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ThanhTien"));
        }
        lblTotal.Text = string.Format(_tongtien.ToString() + "VND");
    }
    public void Message_Prompt(string ms)
    {
        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"JavaScript\">alert(\"" + ms + "\")</SCRIPT>");
        //Page page = HttpContext.Current.CurrentHandler as Page;
        //string str_scpt = "<script type='text/javascript'>alert('" + ms + "');</script>";
        //page.ClientScript.RegisterStartupScript(typeof(Page),"alert_qrcode", str_scpt,true);
    }

    protected void ImageButtonXacnhanthanhtoan_Click(object sender, ImageClickEventArgs e)
    {
    }

    protected void ImageButtoncapnhatthaydoi_Click(object sender, ImageClickEventArgs e)
    {

    }
   

    protected void gridgiohang_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void ImageButtontieptucmuahang_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("GioiThieuSanPham.aspx");
    }
}