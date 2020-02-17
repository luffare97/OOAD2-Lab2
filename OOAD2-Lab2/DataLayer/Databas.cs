namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessEntites;

    public partial class Databas : DbContext
    {
        public Databas()
            : base("name=Databas")
        {
        }

        public virtual DbSet<Alumn> Alumns { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
