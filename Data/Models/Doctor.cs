using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSalud.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string? Photo { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int YearsOfExperience { get; set; }

        public string? PhoneNumber { get; set; }

        public int IdHospital { get; set; }

        public Specialty Specialty { get; set; }

    }
}
