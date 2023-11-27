using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProperty.Models
{
   public class Task_Property
    {
        public int ID { get; set; }
        public int MileStone_ID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start_Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Work_Date { get; set; }
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Expected_End_Date { get; set; }

        public decimal Allocated_Time { get; set; }

        public decimal ActualEndTime { get; set; }
        public decimal ActualCost { get; set; }

        public int CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public DateTime Last_Updated_date { get; set; }
        public int Updated_By { get; set; }


        public string Status { get; set; }
        public bool Is_Completed { get; set; }
        public bool Is_Started { get; set; }
        public DateTime Date_Created { get; set; }
        //View Model Items
        public List<Project_Property> Project_Item { get; set; }
        public int Project_ID { get; set; }

        public DataTable TaskList { get; set; }

    }
}
