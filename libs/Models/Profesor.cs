using System;
using System.Collections.Generic;
using System.Text;

namespace libs.Models
{
    public class Profesor: Persona
    {       
        public ICollection<Asignatura> asignaturas { set; get; }        

    }
}
