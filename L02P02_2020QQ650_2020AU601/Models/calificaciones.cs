using System.ComponentModel.DataAnnotations;
namespace L02P02_2020QQ650_2020AU601.Models
{
    public class calificaciones
    {
        [Key]

        public int calificacionId { get; set; }
        public int publicacionId { get; set; }
        public int usuarioId { get; set; }
        public int calificacion { get; set; }
    }
}
