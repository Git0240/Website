using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using NTT.MyTable;

namespace NTT.DataAccess.Update
{
    public class CapNhatDuLieuDonHang
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "DonHang_Update";
            sqldata.UpdateParameters.Add("IDDonHang", Donhang.IdDonHang.ToString());
            sqldata.UpdateParameters.Add("IDTinhTrangDonHang", Donhang.IdTinhTrangDonHang.ToString());
            sqldata.UpdateParameters.Add("NgayXuLyDonHang", Donhang.NgayXuLyDonHang.ToShortDateString());
            sqldata.UpdateParameters.Add("TrackingNumber", Donhang.TrackingNumber.ToString());
            sqldata.Update();
        }
    }

    public class CapNhatDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "GioHang_Update";
            sqldata.UpdateParameters.Add("SoLuong", Giohang.SoLuong.ToString());
            sqldata.UpdateParameters.Add("IDGioHang", Giohang.IdGioHang.ToString());
            sqldata.Update();
        }
    }

    public class CapNhatDuLieuSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void CapNhatSanphammoi()
        {
            KetNoi chuoiketnoi = new KetNoi();
            SqlConnection conect = new SqlConnection(chuoiketnoi.ConnectionString());
            conect.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conect;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Sanpham_UpDate";
            com.Parameters.Add("@IdDanhMucSanPham", SqlDbType.Int).Value = Sanpham.IdDanhMucSanPham;
            com.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = Sanpham.TenSanPham;
            com.Parameters.Add("@IdHinhSanPham", SqlDbType.Int).Value = Sanpham.IdHinhSanPham;
            com.Parameters.Add("@DuLieuHinhSanPham", SqlDbType.Image).Value = Sanpham.DuLieuHinhSanPham;
            com.Parameters.Add("@MoTaSanPham", SqlDbType.NText).Value = Sanpham.MotaSanPham;
            com.Parameters.Add("@GiaSanPham", SqlDbType.Int).Value = Sanpham.GiaSanPham;
            com.Parameters.Add("@IdSanPham ", SqlDbType.Int).Value = Sanpham.IdSanPham;
            com.ExecuteNonQuery();
        }
    }

    public class CapNhatDuLieuThongKeTruyCap
    {
        public void Capnhatdulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "NguoiTruyCap_Update";
            sqldata.Update();
        }
    }


}