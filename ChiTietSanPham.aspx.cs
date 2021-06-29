using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.MyTable;
using NTT.ProcessDB.Select;

public partial class ChiTietSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Hienchitietsanpham();
        }
    }

    private void Hienchitietsanpham()
    {
        SanPham sanpham = new SanPham();
        sanpham.IdSanPham = int.Parse(Request.QueryString["IdSanPham"]);
        LaySanPhamByID laysanpham = new LaySanPhamByID();
        laysanpham.SanPham = sanpham;

        try
        {
            laysanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlChiTietSanPham.DataSource = laysanpham.Ketqua;
        dtlChiTietSanPham.DataBind();
    }
}