using System.ComponentModel.DataAnnotations;

namespace L02P02_2020QQ650_2020AU601.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }

        public string titulo { get; set; }

        public string descripcion { get; set; }

        public int usuarioId { get; set; }
    }
}
