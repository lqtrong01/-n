using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class khachhangBUS
    {
        khachhangDAO _khachhangDAO = new khachhangDAO();

        public List<khachhangDTO> LayDSKhachHang()
        {
            return _khachhangDAO.LayDSKhachHang();
        }

        public List<khachhangDTO> TimKH(string tenKH)
        {
            return _khachhangDAO.TimKH(tenKH);
        }

        public bool ThemKh(khachhangDTO newKH)
        {
            if (_khachhangDAO.IE(newKH)) return false;

            if (_khachhangDAO.KiemTraTuoi(newKH) && _khachhangDAO.kiemTraSDT(newKH))
            {
                return _khachhangDAO.ThemKH(newKH);
            }
            return false;
        }

        public bool XoaKH(khachhangDTO dltKH)
        {
            return _khachhangDAO.XoaKH(dltKH);
        }

        public bool SuaKH(khachhangDTO upKH) 
        {
            if (_khachhangDAO.KiemTraTuoi(upKH) && _khachhangDAO.kiemTraSDT(upKH))
            {
                return _khachhangDAO.SuaKH(upKH);
            }
            return false;
        }
    }
}
