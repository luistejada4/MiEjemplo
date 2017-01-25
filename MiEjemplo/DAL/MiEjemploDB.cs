using MiEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEjemplo.DAL
{
    class MiEjemploDB : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public MiEjemploDB() : base("ConStr")
        {

        }
    }
}
