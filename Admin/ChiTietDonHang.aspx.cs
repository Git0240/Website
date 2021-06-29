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
using NTT.MyTable;
using NTT.ProcessDB.Select;
using NTT.ProcessDB.Update;

public partial class Admin_ChiTietDonHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HienThiTinhTrangDonHang();
            HienThiChiTietDonHang();
        }
    }
    // ------------Hiển thị chi tiết đơn hàng trong gridview----------
    private void HienThiChiTietDonHang()
    {
        LayChiTietDonHang xulychitietdonhang = new LayChiTietDonHang();
        LayDonHangByID xulydonhangid = new LayDonHangByID();
        ChiTietDonHang chitietdonhang = new ChiTietDonHang();
        chitietdonhang.IdDonHang = int.Parse(Request.QueryString["IDdonhang"]);
        xulychitietdonhang.Chitietdonhang = chitietdonhang;
        DonHang donhang = new DonHang();
        donhang.IdDonHang = int.Parse(Request.QueryString["IDdonhang"]);
        xulydonhangid.Donhang = donhang;
        try
        {
            xulychitietdonhang.Thucthi();
            xulydonhangid.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        gridviewOrderDetailsProducts.DataSource = xulychitietdonhang.Ketqua;
        gridviewOrderDetailsProducts.DataBind();
        //------Hiển thị ID giao dịch trong label------------------
        labelTransactionID.Text = Request.QueryString["IDgiaodich"];
        //------Hiển thị ngày xử lý đơn hàng---------------------
        if (donhang.NgayXuLyDonHang != DateTime.MinValue)
        {
            textShippedDate.Text = donhang.NgayXuLyDonHang.ToShortDateString();
        }
        //--------Hiển thị giá trị Trackingnumber trong textbox---------
        textTrackingNumber.Text = donhang.TrackingNumber;
        //-------Lấy dữ liệu tình trạng đơn hàng trong dropdowlist-------
        dropdownlistOrderStatus.SelectedIndex =
        dropdownlistOrderStatus.Items.IndexOf(dropdownlistOrderStatus.Items.FindByValue(donhang.IdTinhTrangDonHang.ToString()));
    }
    // Hiển thị tình trạng đơn hàng trong dropdownlist-------
    private void HienThiTinhTrangDonHang()
    {
        LayTinhTrangDonHang xulylaytinhtrangdonhang = new LayTinhTrangDonHang();
        try
        {
            xulylaytinhtrangdonhang.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        dropdownlistOrderStatus.DataTextField = "TenTinhTrangDonHang";
        dropdownlistOrderStatus.DataValueField = "IDTinhTrangDonHang";
        dropdownlistOrderStatus.DataSource = xulylaytinhtrangdonhang.Ketqua;
        dropdownlistOrderStatus.DataBind();
    }

    //---------Xự kiện nút trở về--------------------
    protected void btnTroVe_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ThongKeDonHang.aspx");
    }
    // ---------sự kiện kích image button--------------

    protected void imagebuttonDatePicker_Click(object sender, ImageClickEventArgs e)
    {
        if (calendarDatePicker.Visible)
        {
            calendarDatePicker.Visible = false;
        }
        else
        {
            calendarDatePicker.Visible = true;
        }
    }
    //----------Sự kiện chọn giá trị trên điều khiển Calenda------
    protected void calendarDatePicker_SelectionChanged(object sender, EventArgs e)
    {
        textShippedDate.Text = calendarDatePicker.SelectedDate.ToShortDateString();
        calendarDatePicker.Visible = false;
    }
    // --Xử lý nút cập nhật để cập nhật thay đổi đơn hàng sau khi xử lý-------

    protected void btnCapNhat_Click(object sender, ImageClickEventArgs e)
    {
        DonHang donhang = new DonHang();
        CapNhatDonHang xulycapnhatdonhang = new CapNhatDonHang();
        donhang.IdDonHang = int.Parse(Request.QueryString["Iddonhang"]);
        donhang.IdTinhTrangDonHang =
        int.Parse(dropdownlistOrderStatus.SelectedItem.Value);
        donhang.NgayXuLyDonHang = Convert.ToDateTime(textShippedDate.Text);
        donhang.TrackingNumber = textTrackingNumber.Text;
        xulycapnhatdonhang.Donhang = donhang;        
        try
        {
            xulycapnhatdonhang.Thucthi();
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
        Response.Redirect("ThongKeDonHang.aspx");
    }
}
