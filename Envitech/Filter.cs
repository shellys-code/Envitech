using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envitech
{
    public class Filter
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Field { get; set; }
        public string Operation { get; set; }
        public string Value { get; set; }

        public Filter(DateTime dateFrom, DateTime dateTo, string field, string operation, string value)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            Field = field;
            Operation = operation;
            Value = value;
        }
       
    }
}
