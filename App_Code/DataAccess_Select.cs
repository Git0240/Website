using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using NTT.MyTable;

namespace NTT.DataAccess.Select 
{
    public class TruyVanDuLieu10SanPham
    {
        public TruyVanDuLieu10SanPham(){}

        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();

            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPham10_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuChiTietDonHang
    {
        private ChiTietDonHang _chitietdonhang;
        public ChiTietDonHang Chitietdonhang
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "ChiTietDonHang_Select";
            sqldata.SelectParameters.Add("IDDonHang", Chitietdonhang.IdDonHang.ToString());
            return sqldata;
        }

    }

    public class TruyVanDuLieuDangNhapAdmin
    {
        private NguoiDung _nguoidung;

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DangNhapAdmin_Select";
            sqldata.SelectParameters.Add("TenDangNhap", Nguoidung.TenDangNhap);
            sqldata.SelectParameters.Add("MatKhau", Nguoidung.MatKhau);
            return sqldata;
        }
    }

    public class TruyVanDuLieuDangNhapNguoiDung
    {
        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DangNhapNguoiDung_Select";
            sqldata.SelectParameters.Add("TenDangNhap", Nguoidung.TenDangNhap);
            sqldata.SelectParameters.Add("MatKhau", Nguoidung.MatKhau);
            return sqldata;
        }
    }

    public class TruyVanDuLieuDanhMucMaster
    {
        private DanhMucSanPham _danhmucsp;

        public DanhMucSanPham Danhmucsp
        {
            get { return _danhmucsp; }
            set { _danhmucsp = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DanhMucSanPhamMaster_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuDanhMucSanPham
    {
        private DanhMucSanPham _danhmucsanpham;
        public DanhMucSanPham Danhmucsanpham
        {
            get { return _danhmucsanpham; }
            set { _danhmucsanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DanhMucSanPham_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuDonHang
    {
        private NguoiDung _nguoidung;
        public NguoiDung NguoiDung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHang_Select";
            sqldata.SelectParameters.Add("IdNguoiDung", NguoiDung.IdNguoiDung.ToString());
            return sqldata;
        }
    }

    public class TruyVanDuLieuDonHangByID
    {
        private DonHang _donhang;
        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHangByID_Select";
            sqldata.SelectParameters.Add("IDDonHang", Donhang.IdDonHang.ToString());
            return sqldata;
        }
    }

    public class TruyVanDuLieuGioHang
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "GioHang_Select";
            sqldata.SelectParameters.Add("CartGUID", Giohang.CartGuid);
            return sqldata;
        }
    }

    public class TruyVanDuLieuHinhSanPhamByID
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "HinhSanpham_Select";
            sqldata.SelectParameters.Add("IDHinhSanPham", Sanpham.IdHinhSanPham.ToString());
            return sqldata;
        }
    }

    public class TruyVanDuLieuSanPham
    {
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPham_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuSanPhamByID
    {
        private SanPham _sanpham;
        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPhamByID_Select";
            sqldata.SelectParameters.Add("IdSanPham ", Sanpham.IdSanPham.ToString());
            return sqldata;
        }
    }

    public class TruyVanDuLieuSanPhamTheoDanhMuc
    {
        private SanPham _sanpham;

        public SanPham Sanpham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPhamTheoDanhMuc_Select";
            sqldata.SelectParameters.Add("IdDanhMucSanPham", Sanpham.IdDanhMucSanPham.ToString());
            return sqldata;
        }

    }

    public class TruyVanDuLieuTatCaDonHang
    {
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "DonHangAll_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuThongKeTruyCap
    {
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "NguoiTruyCap_Select";
            return sqldata;
        }
    }

    public class TruyVanDuLieuTimSanPham
    {
        public SqlDataSource Laydulieu(string Tieuchuan)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "SanPham_SelectSearch";
            sqldata.SelectParameters.Add("tieuchuantim", Tieuchuan);
            return sqldata;
        }
    }

    public class TruyVanDuLieuTinhTrangDonHang
    {
        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoi chuoiketnoi = new KetNoi();
            sqldata.ConnectionString = chuoiketnoi.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "TinhTrangDonHang_Select";
            return sqldata;
        }
    }

}