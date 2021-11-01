using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class ProEventoContext: DbContext
    {
        public ProEventoContext(DbContextOptions<ProEventoContext> options):base(options){}
        public DbSet<Evento> Eventos{get;set;}
    }
}