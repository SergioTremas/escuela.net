using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace libs.Models
{
    public class Persona
    {
       [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { set; get; }
       public string Name { set; get; }
       public string Address { set; get; }
       public int age { set; get; }

    }
}
