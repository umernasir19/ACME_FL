using DAL.Setups;
using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Setups
{
    public class MASJID_BLL
    {
        FL_MASJID objmasjd;
        FL_MASJID_DAL obj_msjd_dal;

        public MASJID_BLL()
        {

        }
        public MASJID_BLL(FL_MASJID obj_msjd)
        {
            objmasjd = obj_msjd;
        }

        public DataTable GEtALL()
        {
            obj_msjd_dal = new FL_MASJID_DAL();
            return obj_msjd_dal.SelectAll();
        }
    }
}
