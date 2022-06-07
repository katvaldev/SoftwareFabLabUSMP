using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fablab.Models
{
    [Table("Pasante")]
    public class Pasante
    {
        // public enum Semestre
        // {
        // I, II,III,IV,V,VI,VII,VIII,IX,X
        // }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su apellido")]
        [Display(Name="Apellido")]
        [Column("apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un e-mail para contactarlo")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "No es un e-mail válido")]
        [Display(Name="Email")]
        [Column("email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
        [StringLength(9)]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "No es un número de teléfono válido")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Teléfono")]
        [Column("telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
        [StringLength(8)]
        [RegularExpression(@"[0-9]{8}", ErrorMessage = "No es un DNI válido")]
        [Display(Name="DNI")]
        [Column("DNI")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento requerida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name="Fecha de Nacimiento")]
        [Column("fecha_nac")]
        public System.DateTime FechaNac { get; set; }

        [Required(ErrorMessage = "Seleccione un Semestre")]
        [Display(Name="Semestre")]
        [Column("semestre")]
        public string semestre { get; set; }

        [Display(Name="Trabaja")]
        [Column("trabaja")]
        public bool Trabaja { get; set; }

        [Display(Name="Habilidades")]
        [Column("habilidades")]
        public string Habilidades { get; set; }
    }
}