using System.Data.Entity;
using Example.Data.Mapping;

namespace Example.Data
{
    public class ExampleContext : DbContext
    {
        public ExampleContext()
        {
        }
        public ExampleContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Core.Domain.Example> Example { get; set; }
        public DbSet<Core.Domain.Tag> Tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ExampleMap());
            modelBuilder.Configurations.Add(new TagMap());

            base.OnModelCreating(modelBuilder);

        }

    }
}
