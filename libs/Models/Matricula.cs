using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libs.Models
{

    public class Matricula
    {
        public int idAlumno { set; get; }
        public Alumno Alumno { set; get; }

        public int idExpediente { set; get; }
        
        public Expediente Expediente { set; get; }

        public string Tipo { set; get; }
        public DateTime FechaInicio { set; get; }
        



    }
}