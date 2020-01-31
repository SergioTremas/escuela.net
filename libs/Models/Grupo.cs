using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace libs.Models
{
    public class Grupo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public ICollection<Alumno> Alumnos { set; get; }
        public Profesor tutor { set; get; }
        public ICollection<Asignatura> Asignaturas {set; get;}
    }
}
