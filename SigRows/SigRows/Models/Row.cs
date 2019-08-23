using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRows.Models
{
    public class Row
    {
        public int RA_usuario { get; set; }
        public string Category { get; set; }
        public string Request { get; set; }
        public string Attendant { get; set; }
        public Enum.Status Status{ get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public string Observation { get; set; }
        public Enum.Priority Priority { get; set; }
    }
}
