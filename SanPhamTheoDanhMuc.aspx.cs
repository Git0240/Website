using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.MyTable;
using NTT.ProcessDB.Select;


public partial class SanPhamTheoDanhMuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "Danh mục sản phẩm - Hệ thống bán hàng trực tuyến";
        if (!IsPostBack)
        {
            HienThiSanPham();
        }

    }

    private void HienThiSanPham()
    {
        SanPham sanpham = new SanPham();
        String qstr = Request.QueryString["IdDanhMucSanPham"];
        try
        {
            sanpham.IdDanhMucSanPham = Int16.Parse(qstr);
        }
        catch (FormatException) 
        {
            sanpham.IdDanhMucSanPham = 1;
        }
        LayDuLieuSanPhamTheoDanhMuc xulylaysanpham = new LayDuLieuSanPhamTheoDanhMuc();
        xulylaysanpham.SanPham = sanpham;
        try
        {
            xulylaysanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlSanPhamDM.DataSource = xulylaysanpham.Ketqua;
        dtlSanPhamDM.DataBind();

    }
}