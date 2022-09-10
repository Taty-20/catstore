using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;//AGREGAR
using System.ComponentModel.DataAnnotations.Schema;//AGREGAR

namespace catstore.Models
{
    [Table("t_contacto")] //
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //FORMA QUE SE GENERE AUTOINCRIMENTAL
        [Column("id")]  //NOMBRE DE LA COLUMNA DE LA TABAL
        public int Id { get; set; } //NOMBRE DEL ATRIBUTO DE LA CLASE

        [Column("name")]
        public string? Name {get;set;}

        [Column("email")]
        public string? Email {get;set;}
        [Column("subject")]
        public string? Subject {get; set; } 
        [Column("comment")]
        public string? Comment {get; set; }
    }
}