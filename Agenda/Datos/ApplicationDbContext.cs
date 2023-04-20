using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Datos
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contacto> Contacto { get; set; }
    }
}
