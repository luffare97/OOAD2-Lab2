namespace DataLayer
{
    using System;
    using System.Data;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessEntites;
    using Microsoft.EntityFrameworkCore;

    public partial class AppDbContext : DbContext
    {

        public virtual DbSet<Alumn> Alumns { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        public virtual DbSet<Entity> Entitet { get; set; }
        public virtual DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicksListor { get; set; }
        public virtual DbSet<Aktivitet> Aktiviteter { get; set; }
        public virtual DbSet<Program> Programs { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}

        //public AppDbContext() : base("Databas")
        //{

        //}
    }
}
