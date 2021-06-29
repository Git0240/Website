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
using NTT.ProcessDB.Update;

public partial class Admin_SuaSanPham : System.Web.UI.Page
{
    private const string IDHinh = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //txtTenSanPham.Focus();
            HienDanhMucSanPham();
            HienSanPham();
        }
    }
    //-----------Hiện danh mục sản phẩm----------------
    private void HienDanhMucSanPham()
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
        dropDanhMucSanPham.DataTextField = "TenDanhMucSanPham";
        dropDanhMucSanPham.DataValueField = "IDDanhMucSanPham";
        dropDanhMucSanPham.DataSource = xulydanhmucsanpham.Ketqua;
        dropDanhMucSanPham.DataBind();
    }
    //----------Hiện sản phẩm theo id sản phẩm--------------
    private void HienSanPham()
    {
        NTT.MyTable.SanPham Spham = new NTT.MyTable.SanPham();
        Spham.IdSanPham = int.Parse(Request.QueryString["Idsanpham"]);
        LaySanPhamByID laySanPhamByID = new LaySanPhamByID();
        laySanPhamByID.SanPham = Spham;
        try
        {
            laySanPhamByID.Thucthi();
            txtTenSanPham.Text = laySanPhamByID.SanPham.TenSanPham;
            CKEditorControlMoTa.Text = laySanPhamByID.SanPham.MotaSanPham;
            textGia.Text = laySanPhamByID.SanPham.GiaSanPham.ToString();
            imgHinhSanPham.ImageUrl = "../HienThiHinhSanPham.ashx?Idhinhsanpham=" + laySanPhamByID.SanPham.IdHinhSanPham.ToString();
            dropDanhMucSanPham.SelectedIndex =
            dropDanhMucSanPham.Items.IndexOf(dropDanhMucSanPham.Items.FindByText(
            laySanPhamByID.SanPham.DanhMucSanPham.TenDanhMucSanPham));
            LuuTamIdHinhSanPham = laySanPhamByID.SanPham.IdHinhSanPham;
        }
        catch
        {
            Response.Redirect("../Trangloi.aspx");
        }
    }
    //---------------Cập nhật thay đổi sản phẩm--------------------
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            NTT.MyTable.SanPham Spham = new NTT.MyTable.SanPham();
            Spham.IdSanPham = int.Parse(Request.QueryString["IDsanpham"]);
            Spham.TenSanPham = txtTenSanPham.Text;
            Spham.MotaSanPham = CKEditorControlMoTa.Text;
            Spham.GiaSanPham = Convert.ToDecimal(textGia.Text);
            Spham.IdDanhMucSanPham = int.Parse(
            dropDanhMucSanPham.SelectedItem.Value);
            Spham.IdHinhSanPham = LuuTamIdHinhSanPham;
            if (fileuploadHinhSanPham.HasFile)
            {
                Spham.DuLieuHinhSanPham = fileuploadHinhSanPham.FileBytes;
            }
            else
            {
                LayHinhSanPham XuLyLayHinh = new LayHinhSanPham();
                XuLyLayHinh.SanPham = Spham;
                try
                {
                    XuLyLayHinh.Thucthi();
                }
                catch
                {
                    Response.Redirect("../Trangloi.aspx");
                }
                SqlDataSource src = new SqlDataSource();
                src = XuLyLayHinh.Ketqua;
                DataView view = (DataView)src.Select(DataSourceSelectArguments.Empty);
                Spham.DuLieuHinhSanPham = (byte[])view[0]["DuLieuHinhSanPham"];
            }
            CapNhatSanPham capnhatsanpham = new CapNhatSanPham();
            capnhatsanpham.Sanpham = Spham;
            try
            {
                capnhatsanpham.Thucthi();
            }
            catch
            {
                Response.Redirect("../Trangloi.aspx");
            }
            Response.Redirect("SanPham.aspx");
        }
    }

    //---------sự kiện nút bỏ qua----------------------
    protected void btnBoQua_Click(object sender, EventArgs e)
    {
        Response.Redirect("SanPham.aspx");
    }
    // Lưu hình để lấy lại hình sản phẩm trong trường hợp hình không thay đổi
    private int LuuTamIdHinhSanPham
    {
        get { return (int)ViewState[IDHinh]; }
        set { ViewState[IDHinh] = value; }
    }
}