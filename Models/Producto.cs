using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;//AGREGAR

namespace catstore.Models
{
    [Table("t_producto")] //AGREGAR
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]//llave primaria cuyo nombre es ID
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public Decimal PorcentajeDescuento { get; set; }

        public string? ImageName { get; set; }

        public string? Status { get; set; }
    }  
    
}