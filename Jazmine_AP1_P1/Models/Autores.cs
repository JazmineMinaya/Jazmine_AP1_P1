using System.ComponentModel.DataAnnotations;

namespace Jazmine_AP1_P1.Models;

public partial class Autores
{
    [Key]
    public int IdAutor { get; set; }

    [Required(ErrorMessage = "Este campo es requerido")]
    public string Nombres { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es requerido")]
    public string Nacionalidad { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es requerido")]
    public DateTime FechaNacimiento { get; set; }

    [Range(1, double.MaxValue, ErrorMessage = "Este campo es requerido")]
    public double Sueldo { get; set; }
}
