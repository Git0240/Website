using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTT.MyTable 
{
    //Bảng Chi tiết đơn hàng
    public class ChiTietDonHang 
    {
        public ChiTietDonHang(){}
        private int _idsanpham;
        public int IdSanPham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }
        private int _idchitietdonhang;
        public int IdChiTietDonHang
        {
            get { return _idchitietdonhang; }
            set { _idchitietdonhang = value; }
        }
        private int _iddonhang;
        public int IdDonHang
        {
            get { return _iddonhang; }
            set { _iddonhang = value; }
        }        
        private int _soluongsanpham;
        public int SoLuongSanPham
        {
            get { return _soluongsanpham; }
            set { _soluongsanpham = value; }
        }

        private SanPham[] _sanpham;
        public SanPham[] SanPham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
    }

    //Bảng sản phẩm
    public class SanPham
    {
        private DanhMucSanPham _danhmucsanpham;
        public SanPham()
        {
            _danhmucsanpham = new DanhMucSanPham();
        }

        private int _idsanpham;
        public int IdSanPham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }

        private int _iddanhmucsanpham;
        public int IdDanhMucSanPham
        {
            get { return _iddanhmucsanpham; }
            set { _iddanhmucsanpham = value; }
        }
        
        public DanhMucSanPham DanhMucSanPham
        {
            get { return _danhmucsanpham; }
            set { _danhmucsanpham = value; }
        }

        private int _idhinhsanpham;
        public int IdHinhSanPham
        {
            get { return _idhinhsanpham; }
            set { _idhinhsanpham = value; }
        }
        private byte[] _dulieuhinhsanpham;
        public byte[] DuLieuHinhSanPham
        {
            get { return _dulieuhinhsanpham; }
            set { _dulieuhinhsanpham = value; }
        }

        private string _tensanpham;
        public string TenSanPham
        {
            get { return _tensanpham; }
            set { _tensanpham = value; }
        }
        private string _motasanpham;
        public string MotaSanPham
        {
            get { return _motasanpham; }
            set { _motasanpham = value; }
        }

        private decimal _giasanpham;
        public decimal GiaSanPham
        {
            get { return _giasanpham; }
            set { _giasanpham = value; }
        }

        private int _soluong;
        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }                       
    }

    //Bảng danh mục sản phẩm
    public class DanhMucSanPham 
    {
        public DanhMucSanPham() {}
        private int _iddanhmucsanpham;
        public int IdDanhMucSanPham
        {
            get { return _iddanhmucsanpham; }
            set { _iddanhmucsanpham = value; }
        }
        private string _tendanhmucsanpham;
        public string TenDanhMucSanPham
        {
            get { return _tendanhmucsanpham; }
            set { _tendanhmucsanpham = value; }
        }
    }

    //Bảng dữ liệu Người dùng
    public class NguoiDung
    {
        private int _idnguoidung;
        public int IdNguoiDung
        {
            get { return _idnguoidung; }
            set { _idnguoidung = value; }
        }

        private int _idkieunguoidung;
        public int IdKieuNguoiDung
        {
            get { return _idkieunguoidung; }
            set { _idkieunguoidung = value; }
        }

        private string _hoten;
        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        private string _tendangnhap;
        public string TenDangNhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }

        private string _matkhau;
        public string MatKhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }

        private string _diachi;
        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        
        private string _sodienthoai;
        public string SoDienThoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }

        private string _sofax;
        public string SoFax
        {
            get { return _sofax; }
            set { _sofax = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _madienthoai;
        public string MaDienThoai
        {
            get { return _madienthoai; }
            set { _madienthoai = value; }
        }
    }

    //Bảng dữ liệu kiểu người dùng
    public class KieuNguoiDung 
    {
        public KieuNguoiDung() { }

        private int _idkieunguoidung;
        public int IdKieuNguoiDung
        {
            get { return _idkieunguoidung; }
            set { _idkieunguoidung = value; }
        }
        private string _tenkieunguoidung;
        public string TenKieuNguoiDung
        {
            get { return _tenkieunguoidung; }
            set { _tenkieunguoidung = value; }
        }
    }

    //Bảng đơn hàng
    public class DonHang 
    {
        private int _iddonhang;
        public int IdDonHang
        {
            get { return _iddonhang; }
            set { _iddonhang = value; }
        }

        private NguoiDung _nguoidung;
        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }

        private int _idnguoidung;
        public int IdNguoiDung
        {
            get { return _idnguoidung; }
            set { _idnguoidung = value; }
        }

        private int _idtinhtrangdonhang;
        public int IdTinhTrangDonHang
        {
            get { return _idtinhtrangdonhang; }
            set { _idtinhtrangdonhang = value; }
        }

        private string _idgiaodich;
        public string IdGiaoDich
        {
            get { return _idgiaodich; }
            set { _idgiaodich = value; }
        }

        private DateTime _ngaytaodonhang;
        public DateTime NgayTaoDonHang
        {
            get { return _ngaytaodonhang; }
            set { _ngaytaodonhang = value; }
        }

        private DateTime _ngayxulydonhang;
        public DateTime NgayXuLyDonHang
        {
            get { return _ngayxulydonhang; }
            set { _ngayxulydonhang = value; }
        }
        
        private string _trackingnumber;
        public string TrackingNumber
        {
            get { return _trackingnumber; }
            set { _trackingnumber = value; }
        }

        private ChiTietDonHang _chitietdonhang;
        public ChiTietDonHang ChiTietDonHang_
        {
            get { return _chitietdonhang; }
            set { _chitietdonhang = value; }
        }
        
        public DonHang()
        {
            _chitietdonhang = new ChiTietDonHang();
            _nguoidung = new NguoiDung();
        }
    }

    //Bảng dữ liệu giỏ hàng
    public class GioHang 
    {
        public GioHang() { }
        private int _idgiohang;
        public int IdGioHang
        {
            get { return _idgiohang; }
            set { _idgiohang = value; }
        }

        private string _cartguid;
        public string CartGuid
        {
            get { return _cartguid; }
            set { _cartguid = value; }
        }
        
        private int _idsanpham;
        public int IdSanPham
        {
            get { return _idsanpham; }
            set { _idsanpham = value; }
        }       

        private int _soluong;
        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        private DateTime _ngaytaogiohang;
        public DateTime NgayTaoGioHang
        {
            get { return _ngaytaogiohang; }
            set { _ngaytaogiohang = value; }
        }
    }

    //Bảng dữ liệu tình trạng đơn hàng
    public class TinhTrangDonHang 
    {
        public TinhTrangDonHang(){}
        private int _idtinhtrangdonhang;
        public int IdTinhTrangDonHang 
        {
            get { return _idtinhtrangdonhang; }
            set { _idtinhtrangdonhang = value; }
        }

        private String _tentinhtrangdonhang;
        public String TenTinhTrangDonHang
        {
            get { return _tentinhtrangdonhang;}
            set { _tentinhtrangdonhang = value;}
        }    
    }
}