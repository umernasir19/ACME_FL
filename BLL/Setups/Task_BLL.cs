using DAL.Setups;
using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Setups
{
   public class Task_BLL
    {
        Task_Property objtaskproperty;
        Project_Task_DAL objprojecttask_DAl;


        public Task_BLL()
        {

        }
        public Task_BLL(Task_Property taskproperty)
        {
            objtaskproperty = taskproperty;
        }

        public bool Insert()
        {
            objprojecttask_DAl = new Project_Task_DAL(objtaskproperty);
            return objprojecttask_DAl.Insert();
        }
    }
}
