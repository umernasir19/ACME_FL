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
    public class Incident_Bll
    {
        Incident_Info_DAL objIncidentInfoDal;
        Incident_Info_Property objIncidentInfoProperty;
        public Incident_Bll()
        {

        }
        public Incident_Bll(Incident_Info_Property objIncidentInfo_Property)
        {
            objIncidentInfoProperty = objIncidentInfo_Property;
        }
        public DataTable CheckIrUserWithLoginUser(LoginProperty objLoginproperty)
        {
            objIncidentInfoDal = new Incident_Info_DAL();
            return objIncidentInfoDal.CheckIrUserWithLoginUser(objLoginproperty);
        }

        public DataTable GetIrInfo()
        {
            objIncidentInfoDal = new Incident_Info_DAL(objIncidentInfoProperty);
            return objIncidentInfoDal.GetIRInfo();

        }
    }
}
