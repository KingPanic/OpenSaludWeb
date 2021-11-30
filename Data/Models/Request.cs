using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSalud.Data.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime PreciseTimestamp { get; set; }

        public int IdHospital { get; set; }

        public string? Status { get; set; }

        public string? Comments { get; set; }


    }
}
