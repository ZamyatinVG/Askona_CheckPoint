namespace Askona_CheckPoint
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CheckPoint : DbContext
    {
        public CheckPoint() : base("name=CheckPoint") { }

        public virtual DbSet<InOut> InOut { get; set; }
        public virtual DbSet<Request> Request { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>()
                .HasMany(e => e.InOut)
                .WithRequired(e => e.Request)
                .WillCascadeOnDelete(false);
        }
    }
}
