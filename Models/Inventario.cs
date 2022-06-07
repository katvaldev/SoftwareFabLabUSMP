using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fablab.Models
{
    [Table("Inventario")]
    public class Inventario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name="Nombre")]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name="Stock")]
        [Column("stock")]
        public int Stock { get; set; }
    }
}