using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Tracnghiem_DataAccess;

namespace Tracnghiem_Business
{
    public class NhanVienBS
    {
        private NhanvienDA nvda;
        public NhanVienBS()
        {
            try
            {
                nvda = new NhanvienDA();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet DangNhapNV(string tendn, string pass)
        {
            nvda = new NhanvienDA();
            return nvda.DangNhapNV(tendn, pass);
        }
        public DataSet ThongTinNV(string pass)
        {
            nvda = new NhanvienDA();
            return nvda.ThongTinNV(pass);
        }
        public DataSet GetNhanVien()
        {
            nvda = new NhanvienDA();
            return nvda.GetNhanVien();
        }
        public DataSet GetNhanVienCV(string cv)
        {
            nvda = new NhanvienDA();
            return nvda.GetNhanVienCV(cv);
        }
        public DataSet GetTensTendn(string pass)
        {
            nvda = new NhanvienDA();
            return nvda.GetTensTendn(pass);
        }
        public int DoiMatKhau(string tendn, string mkcu, string mkmoi)
        {
            nvda = new NhanvienDA();
            return nvda.DoiMatKhau(tendn, mkcu, mkmoi);
        }
        public DataSet GetNhanVienL2()
        {
            nvda = new NhanvienDA();
            return nvda.GetNhanVienL2();
        }
        public DataSet GetNhanVien_Ma(string ma)
        {
            nvda = new NhanvienDA();
            return nvda.GetNhanVien_Ma(ma);
        }
        public int ThemNV(string manv, string hoten, string diachi, string sodt, string ngays, string chucv)
        {
            nvda = new NhanvienDA();
            return nvda.ThemNV(manv, hoten, diachi, sodt, ngays, chucv);
        }
        public int ThemTaiKhoan(string mand, string tendn, string mk, string loai, string manv)
        {
            nvda = new NhanvienDA();
            return nvda.ThemTaiKhoan(mand, tendn, mk, loai, manv);
        }
        public int UpdateNhanvien(string diachi, string sodt, string ns, string ma)
        {
            nvda = new NhanvienDA();
            return nvda.UpdateNhanvien(diachi, sodt, ns, ma);
        }
        public DataSet GetSoCH_MaNV(string manv)
        {
            nvda = new NhanvienDA();
            return nvda.GetSoCH_MaNV(manv);
        }
        public int DeleteNhanVien_0(string manv)
        {
            nvda = new NhanvienDA();
            return nvda.DeleteNhanVien_0(manv);
        }
    }
}
