using _12626_Egzamin_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace _12626_Egzamin_ASP.Contexts
{
    public class OcenyContext : DbContext
    {
        public OcenyContext(DbContextOptions<OcenyContext> options) : base(options) { }

        public DbSet<oceny> Oceny { get; set; }
    }
}
