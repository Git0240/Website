using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTT.ProcessDB.Select;

public partial class TaiNguyenDieuKhien_ThongKeTruyCap : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HienthiSonguoiOnline();
    }

    public void HienthiSonguoiOnline()
    {
        lblOnline.Text = Application["SoNguoiOnLine"].ToString();
        LayThongKeTruyCap thongketruycap = new LayThongKeTruyCap();
        thongketruycap.Thucthi();
        // Hiển thị lượt truy cập ra điều khiển GridView1
        GridView1.DataSource = thongketruycap.Ketqua; // GridView1 là ID của GridView
        GridView1.DataBind();
    }
}