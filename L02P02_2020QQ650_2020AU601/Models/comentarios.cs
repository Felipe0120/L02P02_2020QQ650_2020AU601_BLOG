
using System.ComponentModel.DataAnnotations;

namespace L02P02_2020QQ650_2020AU601.Models
{
    public class comentarios
    {
        [Key]

        public int cometarioId { get; set; }
        public int publicacionId { get; set; }
        public string comentario { get; set; }
        public int usuarioId { get; set; }
    }
}
