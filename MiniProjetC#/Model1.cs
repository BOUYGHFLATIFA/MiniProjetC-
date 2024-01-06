using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MiniProjetC_
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Adherent> Adherent { get; set; }
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<Emprunt> Emprunt { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adherent>()
                .HasMany(e => e.Emprunt)
                .WithRequired(e => e.Adherent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Livre>()
                .HasMany(e => e.Emprunt)
                .WithRequired(e => e.Livre)
                .WillCascadeOnDelete(false);
        }
    }
}
