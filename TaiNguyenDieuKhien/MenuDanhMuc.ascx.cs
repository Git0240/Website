using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.ProcessDB.Select;

public partial class TaiNguyenDieuKhien_MenuDanhMuc : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            DanhMucSanPham();        
        }
    }

    private void DanhMucSanPham()
    {
        LayDanhMucSanPham xulydanhmucsanpham = new LayDanhMucSanPham();
        try
        {
            xulydanhmucsanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        GridView1.DataSource = xulydanhmucsanpham.Ketqua;
        GridView1.DataBind();
    }
}