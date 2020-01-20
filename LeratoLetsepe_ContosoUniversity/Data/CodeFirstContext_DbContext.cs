using LeratoLetsepe_ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace LeratoLetsepe_ContosoUniversity.Data
{
    public class CodeFirstContext_DbContext : DbContext
    {
        public CodeFirstContext_DbContext(DbContextOptions<CodeFirstContext_DbContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Illness> Illnesses { get; set; }

    }
}
