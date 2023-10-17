using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class taikhoanBUS
    {
        taikhoanDAO _taikhoanDAO = new taikhoanDAO();

        public List<taikhoanDTO> LayDSTaiKhoan()
        {
            return _taikhoanDAO.LayDSTaiKhoan();
        }

        public bool ThemTK(taikhoanDTO newTK)
        {
            if (_taikhoanDAO.IE(newTK)) return false;

            return _taikhoanDAO.ThemTK(newTK);
        }
        public bool XoaTK(taikhoanDTO dltTK)
        {
            return _taikhoanDAO.XoaTK(dltTK);
        }

        public bool SuaTK(taikhoanDTO upTK)
        {
            return _taikhoanDAO.SuaTK(upTK);
        }

        public List<taikhoanDTO> TimTK(string maTK)
        {
            return _taikhoanDAO.TimTK(maTK);
        }

        public bool kiemTraDN(string ttk, string mk)
        {
            var taiKhoan = _taikhoanDAO.LayTaiKhoan(ttk);

            if(taiKhoan == null) return false;

            if(mk != taiKhoan.MATKHAU)
            {
                return false;
            }
            return true;
        }


        public bool kiemtraQUyen(string pq)
        {
            var quyen = _taikhoanDAO.Quyen(pq);

            if(quyen == null) return false;

            if(pq != quyen.QUYEN)
            {
                return false;
            }
            return true;
        }
    }
}
