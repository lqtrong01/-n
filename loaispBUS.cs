using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class loaispBUS
    {
        loaispDAO _loaispDAO = new loaispDAO();

        public List<loaispDTO> LayDSLoaiSP()
        {
            return _loaispDAO.LayDSLoaiSP();
        }

        public List<loaispDTO> TimLSP(string tenLSP)
        {
            return _loaispDAO.TimLSP(tenLSP);
        }

        public bool ThemLSP(loaispDTO newLSP)
        {
            if(_loaispDAO.IE(newLSP)) return false;

            return _loaispDAO.ThemLSP(newLSP);
        }

        public bool XoaLSP(loaispDTO dltLSP)
        { 
            return _loaispDAO.XoaLSP(dltLSP);
        }

        public bool SuaLSP(loaispDTO upLSP)
        {
            return _loaispDAO.SuaLSP(upLSP);
        }
    }
}
