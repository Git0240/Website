using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using NTT.DataAccess.Select;
using NTT.MyTable;

namespace NTT.ProcessDB.Select 
{
    public class LayDanhMucSanPham
    {
        private SqlDataSource _ketqua;
        public LayDanhMucSanPham() { }
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi() 
        {
            TruyVanDuLieuDanhMucSanPham dulieudanhmucsanpham = new TruyVanDuLieuDanhMucSanPham();
            Ketqua = dulieudanhmucsanpham.Laydulieu();
        }
    }

    public class Lay10SanPham
    {
        private SqlDataSource _ketqua;
        public Lay10SanPham() { }
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieu10SanPham dulieusanpham = new TruyVanDuLieu10SanPham();
            Ketqua = dulieusanpham.Laydulieu();
        }
    }

    public class LayThongKeTruyCap 
    {
        private SqlDataSource _ketqua;
        public LayThongKeTruyCap() { }
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }

        public void Thucthi()
        {
            //TruyVanDuLieuThongKeTruyCap dulieuthongketruycap = new TruyVanDuLieuThongKeTruyCap();
            //Ketqua = dulieuthongketruycap..Laydulieu();
            Ketqua = (new TruyVanDuLieuThongKeTruyCap()).Laydulieu();
        }
    }

    public class LaySanPhamByID 
    {
        private SanPham _sanpham;
        private SqlDataSource _ketqua;
        public LaySanPhamByID() { }
        public SanPham SanPham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuSanPhamByID truyvansanphamtbyid = new TruyVanDuLieuSanPhamByID();
            truyvansanphamtbyid.Sanpham = SanPham;
            Ketqua = truyvansanphamtbyid.Laydulieu();

            GridView grid = new GridView();
            grid.DataSource = Ketqua;
            grid.DataBind();
            SanPham.TenSanPham = grid.Rows[0].Cells[1].Text.ToString();
            SanPham.MotaSanPham = grid.Rows[0].Cells[4].Text.ToString();
            SanPham.GiaSanPham = Convert.ToInt32(grid.Rows[0].Cells[5].Text.ToString());
            SanPham.IdSanPham = int.Parse(grid.Rows[0].Cells[0].Text.ToString());
            SanPham.DanhMucSanPham.TenDanhMucSanPham = grid.Rows[0].Cells[2].Text.ToString();
            SanPham.IdHinhSanPham = int.Parse(grid.Rows[0].Cells[3].Text.ToString());
        }
    }

    public class LayHinhSanPham
    {
        public LayHinhSanPham() { }
        private SanPham _sanpham;
        public SanPham SanPham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }

        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }

        public void Thucthi()
        {
            TruyVanDuLieuHinhSanPhamByID chonhinhsanpham = new TruyVanDuLieuHinhSanPhamByID();
            chonhinhsanpham.Sanpham = this.SanPham;
            Ketqua = chonhinhsanpham.Laydulieu();
        }

    }

    public class LayDuLieuSanPhamTheoDanhMuc 
    {
        public  LayDuLieuSanPhamTheoDanhMuc(){}
        private SanPham _sanpham;
        public SanPham SanPham
        {
            get { return _sanpham; }
            set { _sanpham = value; }
        }

        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }

        public void Thucthi()
        {
            TruyVanDuLieuSanPhamTheoDanhMuc truyvansanphamtheodanhmuc = new TruyVanDuLieuSanPhamTheoDanhMuc();
            truyvansanphamtheodanhmuc.Sanpham = this.SanPham;
            Ketqua = truyvansanphamtheodanhmuc.Laydulieu();
        }
    }

    public class LaySanPham 
    {
        public LaySanPham() { }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        public void Thucthi()
        {
            TruyVanDuLieuSanPham dulieusanpham = new TruyVanDuLieuSanPham();
            Ketqua = dulieusanpham.Laydulieu();        
        }
    }

    public class TimKiemSanPham
    {
        public TimKiemSanPham() { }
        private SqlDataSource _ketqua;
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }
        
        private string _tieuchuantim;
        public string Tieuchuantim
        {
            get { return _tieuchuantim; }
            set { _tieuchuantim = value; }
        }

        public void Thucthi()
        {
            TruyVanDuLieuTimSanPham timsanpham = new TruyVanDuLieuTimSanPham();
            Ketqua = timsanpham.Laydulieu(Tieuchuantim);
        }
    }
    public class LayDuLieuGioHang 
    {
        private GioHang _giohang;
        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }
        private SqlDataSource _ketqua;        
        public SqlDataSource Ketqua
        {
            get { return _ketqua; }
            set { _ketqua = value; }
        }

        public void Thucthi()
        {
            TruyVanDuLieuGioHang dulieugiohang = new TruyVanDuLieuGioHang();
            dulieugiohang.Giohang = Giohang;
            Ketqua = dulieugiohang.Laydulieu();
        }
    }
} 