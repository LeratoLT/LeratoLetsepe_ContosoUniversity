using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeratoLetsepe_ContosoUniversity.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool Active { get; set; }

    }
}
