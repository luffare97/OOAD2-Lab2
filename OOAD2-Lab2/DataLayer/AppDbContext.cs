

    using System;
    using System.Data;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessEntites;
    using Microsoft.EntityFrameworkCore;
    //using System.Data.Entity;
    using System.Data.SqlClient;
    
namespace DataLayer
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(localdb)\\mssqllocaldb;Initial Catalog=oosu2lab2;user id=;password=;");
            base.OnConfiguring(optionsBuilder);
        }


        public virtual DbSet<Alumn> Alumns { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Användare> Användares { get; set; }
        public virtual DbSet<Entity> Entitet { get; set; }
        public virtual DbSet<Student> Studenter { get; set; }
        public virtual DbSet<UtskicksLista> UtskicksListor { get; set; }
        public virtual DbSet<Aktivitet> Aktiviteter { get; set; }
        public virtual DbSet<Program> Programs { get; set; }





        
        



        /*
        public AppDbContext() : base("Databas")
        {

        }
        */
        
    }
}
