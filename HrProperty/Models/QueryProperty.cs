using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrProperty.Models
{
    public class QueryProperty
    {
        public string query { get; set; }
        public string queryid { get; set; }

        public string parameter_name { get; set; }

        public string parametertype { get; set; }

        public string  criteria { get; set; }

        public string datatype { get; set; }
        public string clauses { get; set; }
        public string CompleteQuery { get; set; }
        public int PageNumber { get; set; }

    }
}