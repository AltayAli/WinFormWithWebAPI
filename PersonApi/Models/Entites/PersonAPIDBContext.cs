using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Models.Entites
{
    public class PersonAPIDBContext:DbContext
    {
        public PersonAPIDBContext(DbContextOptions<PersonAPIDBContext> option):base(option)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
