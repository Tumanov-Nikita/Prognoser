using System.Data.Entity;

namespace Prognoser.Model
{
    public class PrognoserContext : DbContext
    {
        public PrognoserContext() : base("DbConnection")
        {

        }
        public DbSet<Literature> Literatures { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
