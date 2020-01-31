using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace libs.Models
{
    public class Asignatura
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string name { set; get; }

        public DateTime DateStart { set; get; }
        public DateTime DateFinish { set; get; }

        

        
    }
}
