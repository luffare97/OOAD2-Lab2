namespace DataLayer
{
    using System;
    using System.Data;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessEntites;
    using Microsoft.EntityFrameworkCore;

    public partial class Databas : DbContext
    {
        public Databas()
            : base("name=Databas")
        {
        }

        public virtual DbSet<Alumn> Alumns { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        public virtual DbSet<Entity> Entitet { get; set; }
        public virtual DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicsLisotr { get; set; }
        public virtual DbSet<Aktivitet> Aktiviteter { get; set; }
        public virtual DbSet<Program> Programs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
