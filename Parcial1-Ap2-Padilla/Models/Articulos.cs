using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Padilla.Models
{
    public class Articulos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public double Costo { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public double ValorInventario { get; set; }
    }
}
