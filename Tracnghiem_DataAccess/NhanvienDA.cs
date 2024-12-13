using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tracnghiem_DataAccess
{
    public class NhanvienDA
    {
        private SqlDataAdapter damt;
        public SqlConnection getcon()
        {
            string strcon = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }
        public DataSet DangNhapNV(string tendn, string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select * from Table_NguoiDung D join Table_NhanVien N on D.MaNhanVien=N.MaNhanVien where TenNguoiDung='"+tendn+"' and MatKhauNguoiDung='"+pass+"'", con);
            damt.Fill(ds, "Table_NguoiDung");
            return ds;

        }
        public DataSet ThongTinNV(string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select * from Table_NhanVien N join Table_NguoiDung D on N.MaNhanVien=D.MaNhanVien where D.MatKhauNguoiDung='"+pass+"'", con);
            damt.Fill(ds, "Table_NguoiDung");
            return ds;
        }
        public DataSet GetNhanVien()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_NhanVien", con);
            damt.Fill(ds, "Table_NhanVien");
            return ds;
        }
        public DataSet GetNhanVienCV(string cv)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_NhanVien where ChucVu='"+cv+"'", con);
            damt.Fill(ds, "Table_NhanVien");
            return ds;
        }
        public DataSet GetTensTendn(string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select N.TenNguoiDung,V.HoTen from Table_NguoiDung N join Table_NhanVien V on N.MaNhanVien=V.MaNhanVien where N.MatKhauNguoiDung='"+pass+"'", con);
            damt.Fill(ds, "Table_NhanVien");
            return ds;
        }
        public int DoiMatKhau(string tendn, string mkcu, string mkmoi)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "update Table_NguoiDung set MatKhauNguoiDung='" + mkmoi + "' where TenNguoiDung='" + tendn + "' and MatKhauNguoiDung='" + mkcu + "'";
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
        public DataSet GetNhanVienL2()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_NhanVien where ChucVu!='Dieu Hanh'", con);
            damt.Fill(ds, "Table_NhanVien");
            return ds;
        }
        public DataSet GetNhanVien_Ma(string ma)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_NhanVien where MaNhanVien='"+ma+"'", con);
            damt.Fill(ds, "Table_NhanVien");
            return ds;
        }
        public int ThemNV(string manv,string hoten, string diachi, string sodt, string ngays, string chucv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_NhanVien values('"+manv+"','"+hoten+"','"+diachi+"','"+sodt+"','"+ngays+"','"+chucv+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm nhân viên");
            }
        }
        public int ThemTaiKhoan(string mand, string tendn, string mk, string loai, string manv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_NguoiDung values('"+mand+"','"+tendn+"','"+mk+"','"+loai+"','"+manv+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm tài khoản");
            }
        }
        public int UpdateNhanvien(string diachi, string sodt, string ns, string ma)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "update Table_NhanVien set DiaChi='"+diachi+"', SoDienThoai='"+sodt+"', NgaySinh='"+ns+"' where MaNhanVien='"+ma+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm tài khoản");
            }
        }
        public DataSet GetSoCH_MaNV(string manv)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select count(C.MaCauHoi) from Table_CauHoi C join Table_NguoiDung N on C.MaNguoiDung=N.MaNguoiDung  where N.MaNhanVien='"+manv+"'  ", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public int DeleteNhanVien_0(string manv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "delete Table_NguoiDung where MaNhanVien='"+manv+"' delete Table_NhanVien where MaNhanVien='"+manv+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể xóa nhân viên khoản");
            }
        }
    }
}
