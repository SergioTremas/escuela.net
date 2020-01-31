using System;
using System.Collections.Generic;
using System.Text;

namespace libs.Models
{
    public class Alumno: Persona
    {
        public Expediente Expediente { set; get; }
        public ICollection<Matricula> Matriculas { set; get; }
    }
}
