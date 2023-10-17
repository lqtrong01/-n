using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class nhasanxuatBUS
    {
        nhasanxuatDAO _nhasanxuatDAO = new nhasanxuatDAO();

        public List<nhasanxuatDTO> LayDSNhaSX()
        {
            return _nhasanxuatDAO.LayDSNhaSX();
        }

        public List<nhasanxuatDTO> TimNSX(string tenNSX)
        {
            return _nhasanxuatDAO.TimNSX(tenNSX);
        }

        public bool ThemNSX(nhasanxuatDTO newNSX)
        {
            if (_nhasanxuatDAO.IE(newNSX)) return false;

            return _nhasanxuatDAO.ThemNSX(newNSX);
        }

        public bool XoaNSX(nhasanxuatDTO dltNSX)
        {
            return _nhasanxuatDAO.XoaNSX(dltNSX);
        }

        public bool SuaNSX(nhasanxuatDTO upNSX)
        {
            return _nhasanxuatDAO.SuaNSX(upNSX);
        }
    }
}
