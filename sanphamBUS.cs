using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class sanphamBUS
    {
        sanphamDAO _sanphamDAO = new sanphamDAO();

        public List<sanphamDTO> LayDSSanPham()
        {
            return _sanphamDAO.LayDSSanPham();
        }

        public List<sanphamDTO> TimSP(string tenSP)
        {
            return _sanphamDAO.TimSP(tenSP);
        }

        public bool ThemSP(sanphamDTO newSP)
        {
            if(_sanphamDAO.IE(newSP))  return false;

            return _sanphamDAO.ThemSP(newSP);
        }

        public bool XoaSP(sanphamDTO dltSP)
        {
            return _sanphamDAO.XoaSP(dltSP);
        }

        public bool SuaSP(sanphamDTO upSP)
        {
            return _sanphamDAO.SuaSP(upSP);
        }
    }
}
