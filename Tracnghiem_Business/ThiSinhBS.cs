using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Tracnghiem_DataAccess;

namespace Tracnghiem_Business
{
    public class ThiSinhBS
    {
        private ThiSinhDA tsda;
        public ThiSinhBS()
        {
            try
            {
                tsda = new ThiSinhDA();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public int dangki(string ma, string hoten, string diachi, string ngaysinh, string tendn, string mk)
        {
            tsda = new ThiSinhDA();
            return tsda.dangki(ma, hoten, diachi, ngaysinh, tendn, mk);
        }
        public DataSet GetThiSinh(string pass)
        {
            tsda = new ThiSinhDA();
            return tsda.GetThiSinh(pass);
        }
        public int DoiMatKhau(string tendn, string mkcu, string mkmoi)
        {
            tsda = new ThiSinhDA();
            return tsda.DoiMatKhau(tendn, mkcu, mkmoi);
        }
        public DataSet GetThiSinhDN(string user, string pass)
        {
            tsda = new ThiSinhDA();
            return tsda.GetThiSinhDN(user, pass);
        }
        public DataSet GetMatKhau(string ma, string tendn)
        {
            tsda = new ThiSinhDA();
            return tsda.GetMatKhau(ma, tendn);
        }
        public DataSet GetThiSinh()
        {
            tsda = new ThiSinhDA();
            return tsda.GetThiSinh();
        }
        public DataSet GetThiSinhTen(string hoten)
        {
            tsda = new ThiSinhDA();
            return tsda.GetThiSinhTen(hoten);
        }
        public DataSet GetThiSinhMa(string ma)
        {
            tsda = new ThiSinhDA();
            return tsda.GetThiSinhMa(ma);
        }
        public DataSet GetKetQua()
        {
            tsda = new ThiSinhDA();
            return tsda.GetKetQua();
        }
       
        public DataSet GetKetQuaCSDL(string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.GetKetQuaCSDL(mamon);
        }
        public DataSet GetMonThi()
        {
            tsda = new ThiSinhDA();
            return tsda.GetMonThi();
        }
        public DataSet GetKetQuaDiemCN(string ma)
        {
            tsda = new ThiSinhDA();
            return tsda.GetKetQuaDiemCN(ma);
        }
        public DataSet GetKetQuaDiemTN(string ma)
        {
            tsda = new ThiSinhDA();
            return tsda.GetKetQuaDiemTN(ma);
        }
        public DataSet RanDomCauHoi(string cau,string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.RanDomCauHoi(cau,mamon);
        }
        public DataSet GetDapAn(string macauhoi)
        {
            tsda = new ThiSinhDA();
            return tsda.GetDapAn(macauhoi);
        }
        public DataSet GetCauHoi_Mon(string mon)
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoi_Mon(mon);
        }
        public DataSet GetCauHoi_NhanVien(string manv)
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoi_NhanVien(manv);
        }
        public DataSet GetCauHoi()
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoi();
        }
        public DataSet GetDapAnDung(string macauhoi)
        {
            tsda = new ThiSinhDA();
            return tsda.GetDapAnDung(macauhoi);
        }
        public DataSet GetCauHoiNV(string mand)
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoiNV(mand);
        }
        public int UpdateCauHoi(string noidung, string mach, string macauhoi, string noidung1, string ma1, string noidung2, string ma2, string noidung3, string ma3, string noidung4, string ma4)
        {
            tsda = new ThiSinhDA();
            return tsda.UpdateCauHoi(noidung, mach, macauhoi, noidung1, ma1, noidung2, ma2, noidung3, ma3, noidung4, ma4);
        }
        public int ThemCauHoi(string mach, string noidungch, string mand, string mamon, string matl1, string ndtr1, string kieu1, string matl2, string ndtr2, string kieu2, string matl3, string ndtr3, string kieu3, string matl4, string ndtr4, string kieu4)
        {
            tsda = new ThiSinhDA();
            return tsda.ThemCauHoi(mach, noidungch, mand, mamon, matl1, ndtr1, kieu1, matl2, ndtr2, kieu2, matl3, ndtr3, kieu3, matl4, ndtr4, kieu4);
        }
        public int DeleteCauHoi(string macauhoi)
        {
            tsda = new ThiSinhDA();
            return tsda.DeleteCauHoi(macauhoi);
        }
        public DataSet GetCauHoiNV_Mon(string mand, string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoiNV_Mon(mand, mamon);
        }
        public DataSet GetCauHoi_Ghichu(string ghichu)
        {
            tsda = new ThiSinhDA();
            return tsda.GetCauHoi_Ghichu(ghichu);
        }
        public DataSet SoCH_Mon(string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.SoCH_Mon(mamon);
        }
        public int ThemMon(string mamon, string tenmon)
        {
            tsda = new ThiSinhDA();
            return tsda.ThemMon(mamon, tenmon);
        }
        public int XoaMon_0(string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.XoaMon_0(mamon);
        }
        public DataSet KiemTraMon(string mamon)
        {
            tsda = new ThiSinhDA();
            return tsda.KiemTraMon(mamon);
        }
        public int ThemKetQua(string mats, string diem, string mamon, string ngay)
        {
            tsda = new ThiSinhDA();
            return tsda.ThemKetQua(mats, diem, mamon,ngay);
        }
    }
}
