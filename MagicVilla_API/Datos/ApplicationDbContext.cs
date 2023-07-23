using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)

        {

        }
        
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Primera villa",
                    Detalle = "iniciando con los registros",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 5,
                    Tarifa = 2000,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaAcualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "segunda villa",
                    Detalle = "segundo registro",
                    ImagenUrl = "",
                    Ocupantes = 15,
                    MetrosCuadrados = 15,
                    Tarifa = 25000,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaAcualizacion = DateTime.Now
                });
        }
    }
}
