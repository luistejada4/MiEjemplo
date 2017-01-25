using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEjemplo.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudiantesID { get; set; }
        public string Nombres { get; set; }
        public double Deudas { get; set;  }
    }
}
