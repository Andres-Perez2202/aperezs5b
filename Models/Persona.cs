using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aperezs5b.Models
{
  [Table("Persona")]
    public class Persona
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }    

    }
}
