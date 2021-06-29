using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NTT.ProcessDB.Select;

public partial class GioiThieuSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "Giới thiệu sản phẩm - Hệ thống bán hàng trực tuyến";
        if (!IsPostBack)
        {
            HienThiSanPham();
        }
    }

    private void HienThiSanPham()
    {
        LaySanPham xulylaysanpham = new LaySanPham();
        try
        {
            xulylaysanpham.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlSanPham.DataSource = xulylaysanpham.Ketqua; // dtlSanPham là ID của DataList
        dtlSanPham.DataBind();

        //Phân trang sản phẩm
        DataView dataview = (DataView)xulylaysanpham.Ketqua.Select(DataSourceSelectArguments.Empty);
        CollectionPagerPhanTrang.PageSize = 12; ////số sản phẩm hiển thị trên một trang
        CollectionPagerPhanTrang.DataSource = dataview;
        CollectionPagerPhanTrang.LabelText = "Trang thứ : ";
        CollectionPagerPhanTrang.BackText = "Quay lui";
        CollectionPagerPhanTrang.NextText = "Tiếp theo";
        //dtlSanPham là tên datalist
        CollectionPagerPhanTrang.BindToControl = dtlSanPham;
        dtlSanPham.DataSource = CollectionPagerPhanTrang.DataSourcePaged;
    }

    protected void ImageButtonTim_Click(object sender, ImageClickEventArgs e)
    {
        dtlSanPham.DataSource = null;
        dtlSanPham.DataBind();
        string strtext = textSearch.Text.Trim();
        if (strtext.Length > 0) 
        {
            Timsanpham(strtext);
        }
        else
        {
            HienThiSanPham();
        }
    }

    private void Timsanpham(string tieuchuantim)
    {
        TimKiemSanPham xulytim = new TimKiemSanPham();
        xulytim.Tieuchuantim = tieuchuantim;
        try
        {
            xulytim.Thucthi();
        }
        catch
        {
            Response.Redirect("Trangloi.aspx");
        }
        dtlSanPham.DataSource = xulytim.Ketqua;// dtlSanPham là ID của Datalist
        dtlSanPham.DataBind();

        if (dtlSanPham.Items.Count != 0)
            lblketqua.Text = "Các sản phẩm bạn cần tìm:";
        //lblketqua là ID của Label chứa dòng thông tin để thông báo kết quả tìm kiếm
        else
        {
            lblketqua.Text = "Không tìm thấy sản phẩm";
        }

        //Phân trang sản phẩm
        DataView dataview = (DataView)xulytim.Ketqua.Select(DataSourceSelectArguments.Empty);
        CollectionPagerPhanTrang.PageSize = 12; ////số sản phẩm hiển thị trên một trang
        CollectionPagerPhanTrang.DataSource = dataview;
        CollectionPagerPhanTrang.LabelText = "Trang thứ : ";
        CollectionPagerPhanTrang.BackText = "Quay lui";
        CollectionPagerPhanTrang.NextText = "Tiếp theo";
        //dtlSanPham là tên datalist
        CollectionPagerPhanTrang.BindToControl = dtlSanPham;
        dtlSanPham.DataSource = CollectionPagerPhanTrang.DataSourcePaged;
    }
}