using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace libs.Models
{
    public class Expediente
    {
        
        [Key,ForeignKey("Estudiante")]
        public int Id { set; get; }
   
        public ICollection<Asignatura>  Asignatura { set; get; }
        public ICollection<Matricula> Matriculas { set; get; }




    }
}
