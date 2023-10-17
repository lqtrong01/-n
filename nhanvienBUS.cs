using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class nhanvienBUS
    {
        nhanvienDAO _nhanvienDAO = new nhanvienDAO();

        public List<nhanvienDTO> LayDSNhanVien()
        {
            return _nhanvienDAO.LayDSNhanVien();
        }

        public List<nhanvienDTO> TimKiemNV(string tenNV)
        {
            return _nhanvienDAO.TimKiemNV(tenNV);
        }

        public bool ThemNV(nhanvienDTO newNV)
        {
            if (_nhanvienDAO.IE(newNV)) return false;
            if (_nhanvienDAO.KiemTraTuoi(newNV) && _nhanvienDAO.kiemTraSDT(newNV))
            {
                return _nhanvienDAO.ThemNV(newNV);
            }
            return false;
        }

        public bool XoaNV(nhanvienDTO dltNV)
        {
            return _nhanvienDAO.XoaNV(dltNV);
        }

        public bool SuaNV(nhanvienDTO upNV)
        {
            if (_nhanvienDAO.KiemTraTuoi(upNV) && _nhanvienDAO.kiemTraSDT(upNV))
            {
                return _nhanvienDAO.SuaNV(upNV);
            }
            return false;
        }

        
    }
}
