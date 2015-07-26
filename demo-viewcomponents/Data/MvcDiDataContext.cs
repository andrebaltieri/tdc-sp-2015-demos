using Microsoft.Data.Entity;
using MvcDi.Models;

namespace MvcDi.Data
{
    public class MvcDiDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(EntityOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryStore();
        }
	}
}