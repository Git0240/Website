using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using NTT.MyTable;


namespace NTT.DataAccess.Insert
{
    public class ThemDuLieuChiTietDonHang
    {
        ChiTietDonHang _chitietdonhang;
        public ThemDuLieuChiTietDonHang() { }

        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        public void themdulieuchitietdonhang()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi ketnoi = new KetNoi();
            sqldata.ConnectionString = ketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "ChiTietDonHang_Insert";
            sqldata.InsertParameters.Add("IDDonHang", Chitietdonhang.IdDonHang.ToString());
            sqldata.InsertParameters.Add("IDSanPham", Chitietdonhang.IdSanPham.ToString());
            sqldata.InsertParameters.Add("SoLuongSanPham", Chitietdonhang.SoLuongSanPham.ToString());
            sqldata.Insert();
        }
    }

    public class ThemDuLieuDonHang
    {
        private DonHang _donhang;
        public ThemDuLieuDonHang() { }

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public SqlDataSource themnvalaydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "DonHang_Insert";
            sqldata.InsertParameters.Add("IdNguoiDung", Donhang.IdNguoiDung.ToString());
            sqldata.InsertParameters.Add("IdGiaoDich", Donhang.IdGiaoDich.ToString());
            sqldata.Insert();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHang_Top1_Select ";
            return sqldata;
        }
    }

    public class ThemDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public void Themdulieugiohang()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "GioHang_Insert";
            sqldata.InsertParameters.Add("CartGUID", Giohang.CartGuid);
            sqldata.InsertParameters.Add("IDSanPham", Giohang.IdSanPham.ToString());
            sqldata.InsertParameters.Add("SoLuong", Giohang.SoLuong.ToString());
            sqldata.Insert();
        }
    }

    public class ThemDuLieuNguoiDung
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void themdulieunguoidung()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "NguoiDung_Insert";
            sqldata.InsertParameters.Add("HoTen", Nguoidung.HoTen.ToString());
            sqldata.InsertParameters.Add("TenDangNhap", Nguoidung.TenDangNhap.ToString());
            sqldata.InsertParameters.Add("DiaChi", Nguoidung.DiaChi.ToString());
            sqldata.InsertParameters.Add("MaDienThoai", Nguoidung.MaDienThoai.ToString());
            sqldata.InsertParameters.Add("SoDienThoai", Nguoidung.SoDienThoai.ToString());
            sqldata.InsertParameters.Add("SoFax", Nguoidung.SoFax.ToString());
            sqldata.InsertParameters.Add("Email", Nguoidung.Email.ToString());
            sqldata.InsertParameters.Add("IDKieuNguoiDung", Nguoidung.IdKieuNguoiDung.ToString());
            sqldata.InsertParameters.Add("MatKhau", Nguoidung.MatKhau.ToString());
            sqldata.Insert();
        }
    }

    public class ThemDuLieuSanPham
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public void themdulieusanpham()
        {
            KetNoi chuoiketnoi = new KetNoi();
            SqlConnection conect = new SqlConnection(chuoiketnoi.ConnectionString());
            conect.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conect;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "SanPham_Insert";
            com.Parameters.Add("@dulieuhinhsanpham", SqlDbType.Image).Value = Sanpham.DuLieuHinhSanPham;
            com.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = Sanpham.TenSanPham;
            com.Parameters.Add("@IDDanhMucSanPham", SqlDbType.Int).Value = Sanpham.IdDanhMucSanPham;
            com.Parameters.Add("@MoTaSanPham", SqlDbType.NVarChar).Value = Sanpham.MotaSanPham;
            com.Parameters.Add("@GiaSanPham", SqlDbType.Int).Value = Sanpham.GiaSanPham;
            com.ExecuteNonQuery();
        }
    }

}