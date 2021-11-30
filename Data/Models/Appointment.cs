using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSalud.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? HospitalName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string? DoctorName { get; set; }

    }
}
