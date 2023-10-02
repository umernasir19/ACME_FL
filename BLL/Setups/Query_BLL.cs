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
    public class Query_BLL
    {
        QueryProperty objqueryproperty;
        Query_DAL objquerydal;

        public Query_BLL()
        {

        }

        public Query_BLL(QueryProperty obj_queryproperty)
        {
            objqueryproperty = obj_queryproperty;
        }

        public DataTable SelectCustomQuery()
        {
            objquerydal = new Query_DAL(objqueryproperty);
            return objquerydal.SelectFromCustomQuery();
        }
   
    }
}
