using System;
using System.Collections.Generic;
using System.Text;

namespace libs.Models
{
    public class Clase
    {
        public int Id { set; get; }

        public ICollection<Asignatura> listAsignaturas;

        public string nombre;
    }
}
