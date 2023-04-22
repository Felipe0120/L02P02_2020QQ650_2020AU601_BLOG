using Microsoft.EntityFrameworkCore;
using L02P02_2020QQ650_2020AU601.Models;
namespace L02P02_2020QQ650_2020AU601.Models
{
    public class blogDbContext : DbContext
    {
        public blogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }

    }




}
