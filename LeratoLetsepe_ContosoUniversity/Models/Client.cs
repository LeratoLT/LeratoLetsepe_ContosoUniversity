using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeratoLetsepe_ContosoUniversity.Models
{
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public Guid IllnessId { get; set; }
        
    }
}
