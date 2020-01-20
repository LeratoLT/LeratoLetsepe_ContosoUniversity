using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeratoLetsepe_ContosoUniversity.Models
{
    public class Doctor : Person
    {
        public Guid DoctordId { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public string Specialist { get; set; }

        public string API { get; set; }
    }
}
