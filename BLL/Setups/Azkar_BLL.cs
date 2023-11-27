using DAL;
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

    public class Azkar_BLL
    {
        FL_AZKAR objdbAzkar;
        Azkar_Property objazkarproperty;
        Azkar_DAL objazakrdal;

        public Azkar_BLL()
        {

        }
        public Azkar_BLL(Azkar_Property _objazkarproperty)

        {
            objazkarproperty = _objazkarproperty;
        }


        public bool AddUpdate()
        {
            //objdbAzkar = new FL_AZKAR()
            //{
            //    Azkar_ID= objazkarproperty.Azkar_ID,
            //    Azkar_Name = objazkarproperty.Azkar_Name,
            //    Azkar_Arabic = objazkarproperty.Azkar_Arabic,
            //    Azkar_Eng =  objazkarproperty.Azkar_Eng,
            //    Azkar_Urdu= objazkarproperty.Azkar_Urdu,
            //    Azkar_Count= objazkarproperty.Azkar_Count,
            //    DateCreated=DateTime.UtcNow,
            //    Status=true,
            //    CreatedBy=1
                

            //};
           objazakrdal = new Azkar_DAL(objazkarproperty);
           return objazakrdal.Insert();
           // return obj_msjd_dal.SelectAll();
        }

        public DataTable GetAll()
        {
            objazakrdal = new Azkar_DAL(objazkarproperty);
            return objazakrdal.SelectAll();
        }

        public bool Delete()
        {
            objazkarproperty = GetAll().AsEnumerable().Select(row => new Azkar_Property
            {
                Azkar_ID=row.Field<int>("Azkar_ID"),
                Azkar_Name = row.Field<string>("Azkar_Name"),
                Azkar_Arabic = row.Field<string>("Azkar_Arabic"),
                Azkar_Eng = row.Field<string>("Azkar_Eng"),
                Azkar_Urdu = row.Field<string>("Azkar_Urdu"),
                Azkar_Count = row.Field<int>("Azkar_Count"),
                Status =false,
                DateCreated= row.Field<DateTime>("DateCreated"),
                CreatedBy= row.Field<int>("CreatedBy")
            }).FirstOrDefault();

            objazakrdal = new Azkar_DAL(objazkarproperty);
            return objazakrdal.Insert();
        }
    }
}
