using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeratoLetsepe_ContosoUniversity.Models
{
    public class Illness
    {
        public Guid IllnessId { get; set; }
        public string IllnessName { get; set; }
    }
}
