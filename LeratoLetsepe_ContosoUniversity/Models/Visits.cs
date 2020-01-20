using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeratoLetsepe_ContosoUniversity.Models
{
    public class Visits
    {
        public Guid VisitsId {get;set;}
        public Doctor DoctorId { get; set; }
        public Client ClientId { get; set; }
    }
}
