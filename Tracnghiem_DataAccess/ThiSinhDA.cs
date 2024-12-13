using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tracnghiem_DataAccess
{
    public class ThiSinhDA
    {
        
       //public ThiSinhDA() : base() { }
        private SqlDataAdapter damt;
        public SqlConnection getcon()
        {
            string strcon = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }
        public int dangki(string ma, string hoten, string diachi, string ngaysinh, string tendn, string mk)
        {
            try
            {
                int x = 0;
                SqlConnection con =getcon();
                string sql = "insert  Table_ThiSinh values('" + ma + "','" + hoten + "','" + diachi + "','" + ngaysinh + "','" + tendn + "','" + mk + "'')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể đăng kí, trùng mã thí sinh");
            }
        }
        public int DoiMatKhau(string tendn, string mkcu,string mkmoi)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "update Table_ThiSinh set MatKhau='" + mkmoi + "' where TenDangNhap='" + tendn + "' and MatKhau='" + mkcu + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thay đổi mật khẩu");
            }
        }
        
        public DataSet GetThiSinh(string pass)
        {
            DataSet ds= new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_ThiSinh where MatKhau='" + pass + "'", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;

        }
        public DataSet GetThiSinhDN(string user,string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_ThiSinh where TenDangNhap='"+user+"' and MatKhau='" + pass + "'", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;

        }
        public DataSet GetMatKhau(string ma, string tendn)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_ThiSinh where TenDangNhap='" + tendn + "' and MaThiSinh='" + ma + "'", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;

        }
        public DataSet GetThiSinh()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select MaThiSinh,HoTen,DiaChi,NgaySinh from Table_ThiSinh ", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet GetThiSinhTen(string hoten)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select MaThiSinh,HoTen,DiaChi,NgaySinh from Table_ThiSinh where HoTen='"+hoten+"' ", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet GetThiSinhMa(string ma)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select MaThiSinh,HoTen,DiaChi,NgaySinh from Table_ThiSinh where MaThiSinh='" + ma + "' ", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet GetKetQua()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select K.MaThiSinh,T.HoTen,T.DiaChi,T.NgaySinh,K.Diem,M.TenMon from Table_ThiSinh T join Table_KetQua K on T.MaThiSinh=K.MaThiSinh join Table_MonThi M on K.MaMon=M.MaMon", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
       
        public DataSet GetKetQuaCSDL(string mamon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select K.MaThiSinh,T.HoTen,T.DiaChi,T.NgaySinh,K.Diem,M.TenMon from Table_ThiSinh T join Table_KetQua K on T.MaThiSinh=K.MaThiSinh join Table_MonThi M on K.MaMon=M.MaMon where M.MaMon='"+mamon+"' ", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet GetMonThi()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_MonThi", con);
            damt.Fill(ds, "Table_MonThi");
            return ds;
        }
        public DataSet GetKetQuaDiemCN(string ma)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select   K.MaThiSinh,T.HoTen,T.DiaChi,T.NgaySinh,K.Diem,M.TenMon from Table_ThiSinh T join Table_KetQua K on T.MaThiSinh=K.MaThiSinh join Table_MonThi M on K.MaMon=M.MaMon where M.MaMon='" + ma + "' and K.Diem=(select Max(Diem) 'Diem' from Table_KetQua where MaMon='" + ma + "')", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet GetKetQuaDiemTN(string ma)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select   K.MaThiSinh,T.HoTen,T.DiaChi,T.NgaySinh,K.Diem,M.TenMon from Table_ThiSinh T join Table_KetQua K on T.MaThiSinh=K.MaThiSinh join Table_MonThi M on K.MaMon=M.MaMon where M.MaMon='" + ma + "' and K.Diem=(select Min(Diem) 'Diem' from Table_KetQua where MaMon='" + ma + "')", con);
            damt.Fill(ds, "Table_ThiSinh");
            return ds;
        }
        public DataSet RanDomCauHoi(string cau,string mamon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("SELECT TOP " + cau + " * FROM Table_CauHoi where MaMon='" + mamon + "' order by newid()", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetDapAn(string macauhoi)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select NoiDungCauTraLoi,KieuDapAn,MaCauTraLoi from Table_DapAn  where MaCauHoi='"+macauhoi+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetDapAnDung(string macauhoi)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select A.NoiDungCauTraLoi,A.KieuDapAn from Table_DapAn A join Table_CauHoi C on A.MaCauHoi=C.MaCauHoi where C.MaCauHoi='" + macauhoi + "' and A.KieuDapAn='1'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetCauHoi_Mon(string mon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select MaCauHoi,NoiDungCauHoi,MaLoaiCauHoi,MaNguoiDung,MaMon from Table_CauHoi where MaMon='" + mon + "'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetCauHoi_NhanVien(string manv)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select C.MaCauHoi,C.NoiDungCauHoi,C.MaLoaiCauHoi,C.MaNguoiDung,C.MaMon from Table_CauHoi C join Table_NguoiDung N on C.MaNguoiDung=N.MaNguoiDung join Table_NhanVien V on N.MaNhanVien=V.MaNhanVien where V.MaNhanVien='"+manv+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetCauHoi()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select MaCauHoi,NoiDungCauHoi,MaLoaiCauHoi,MaNguoiDung,MaMon from Table_CauHoi", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetCauHoiNV(string mand)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select MaCauHoi,NoiDungCauHoi,MaLoaiCauHoi,MaNguoiDung,MaMon from Table_CauHoi where MaNguoiDung='" + mand + "'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet GetCauHoiNV_Mon(string mand,string mamon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select MaCauHoi,NoiDungCauHoi,MaLoaiCauHoi,MaNguoiDung,MaMon from Table_CauHoi where MaNguoiDung='" + mand + "' and MaMon='"+mamon+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public int UpdateCauHoi(string noidung,string mach,string macauhoi,string noidung1,string ma1,string noidung2,string ma2,string noidung3,string ma3,string noidung4,string ma4)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "Update Table_CauHoi set NoiDungCauHoi='" + noidung + "' where MaNguoiDung='" + mach + "' and MaCauHoi='" + macauhoi + "' Update Table_DapAn set NoiDungCauTraLoi='" + noidung1 + "' where MaCauTraLoi='" + ma1 + "' and MaCauHoi='" + macauhoi + "' Update Table_DapAn set NoiDungCauTraLoi='" + noidung2 + "' where MaCauTraLoi='" + ma2 + "' and MaCauHoi='" + macauhoi + "'  Update Table_DapAn set NoiDungCauTraLoi='" + noidung3 + "' where MaCauTraLoi='" + ma3 + "' and MaCauHoi='" + macauhoi + "'  Update Table_DapAn set NoiDungCauTraLoi='" + noidung4 + "' where MaCauTraLoi='" + ma4 + "' and MaCauHoi='" + macauhoi + "'  ";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể cập nhật");
            }
        }
        public int ThemCauHoi(string mach, string noidungch, string mand, string mamon, string matl1, string ndtr1, string kieu1, string matl2, string ndtr2, string kieu2, string matl3, string ndtr3, string kieu3, string matl4, string ndtr4, string kieu4)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_CauHoi values('"+mach+"','"+noidungch+"','1','"+mand+"','"+mamon+"','cau hoi') insert Table_DapAn values('"+matl1+"','"+ndtr1+"','"+mach+"','"+kieu1+"')  insert Table_DapAn values('"+matl2+"','"+ndtr2+"','"+mach+"','"+kieu2+"') insert Table_DapAn values('"+matl3+"','"+ndtr3+"','"+mach+"','"+kieu3+"') insert Table_DapAn values('"+matl4+"','"+ndtr4+"','"+mach+"','"+kieu4+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm");
            }
        }
        public int DeleteCauHoi(string macauhoi)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "delete Table_DapAn where MaCauHoi='"+macauhoi+"' delete Table_CauHoi where MaCauHoi='"+macauhoi+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể cập nhật");
            }
        }
        public DataSet GetCauHoi_Ghichu(string ghichu)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select NoiDungCauHoi from Table_CauHoi where GhiChu='"+ghichu+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public DataSet SoCH_Mon(string mamon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select count(MaMon) from Table_CauHoi where MaMon='"+mamon+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public int ThemMon(string mamon, string tenmon)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_MonThi values('"+mamon+"','"+tenmon+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm");
            }
        }
        public int XoaMon_0(string mamon)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "Delete Table_MonThi where MaMon='"+mamon+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm");
            }
        }
        public DataSet KiemTraMon(string mamon)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select count(MaMon) from Table_CauHoi where MaMon='"+mamon+"'", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public int ThemKetQua(string mats, string diem, string mamon, string ngay)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_KetQua values('" + mats+ "','" + diem + "','"+mamon+"','"+ngay+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm");
            }
        }
    }
}
