using System.ComponentModel.DataAnnotations;

namespace L02P02_2020QQ650_2020AU601.Models
{
    public class usuarios
    {
        [Key]
        
        public int usuarioId { get; set; }

        public int rolId { get; set; }

        public string nombreUsuario { get; set;}

        public string clave { get; set;}
        public string nombre { get; set;}
        public string apellido { get; set;}
        
    }
}
