using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProperty.Models
{
    public class FL_MASJID
    {
        public int MAsjid_ID { get; set; }
        public string Masjid_Title { get; set; }
        public string Masjid_Descr { get; set; }
        public string Masjid_Location { get; set; }
        public decimal Masjid_Lat { get; set; }
        public decimal Masjid_Lon { get; set; }
        public bool Status { get; set; }
        public decimal Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}
