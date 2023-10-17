using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class hoadonBUS
    {
        hoadonDAO _hoadonDAO;

        public List<HoaDonBan> LayDSHoaDon()
        {
            return _hoadonDAO.LayDSHoaDon();
        }
    }
}
