using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.ProcessDB.Select;

public partial class TaiNguyenDieuKhien_Top10SanPham : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HienThiSanPham();
        }
    }

    private void HienThiSanPham()
    {
        Lay10SanPham xulylay10sanpham = new Lay10SanPham();
        try
        {
            xulylay10sanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        dtl10SanPham.DataSource = xulylay10sanpham.Ketqua;
        dtl10SanPham.DataBind();
    }
}