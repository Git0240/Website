<%@ WebHandler Language="C#" Class="HienThiHinhSanPham" %>

using System;
using System.Web;

using System;
using System.Web;
using System.Data;
using System.Web.UI;
using NTT.MyTable;
using NTT.ProcessDB.Select;
using System.Web.UI.WebControls;


public class HienThiHinhSanPham : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        SanPham sanpham = new SanPham();
        sanpham.IdHinhSanPham = int.Parse(context.Request.QueryString["Idhinhsanpham"]);
        
        LayHinhSanPham XuLyLayHinh = new LayHinhSanPham();
        XuLyLayHinh.SanPham = sanpham;        
        XuLyLayHinh.Thucthi();
        
        SqlDataSource src = new SqlDataSource();
        src = XuLyLayHinh.Ketqua;
        DataView view = (DataView)src.Select(DataSourceSelectArguments.Empty);
        
        context.Response.ContentType = "text/plain";
        context.Response.BinaryWrite((byte[])view[0]["DuLieuHinhSanPham"]);
        //context.Response.Write(view[0][0]);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}