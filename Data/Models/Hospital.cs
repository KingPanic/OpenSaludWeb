using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSalud.Data.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        
        public string? Photo { get; set; }
        public string? Name { get; set; }

        public int LegalEntityId { get; set; }

        public string? AddressLine { get; set; }

        public string? Status { get; set; }

    }
}
