

    using System;
    using System.Data;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessEntites;
    //using Microsoft.EntityFrameworkCore;
    using System.Data.Entity;
    using System.Data.SqlClient;
    
namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Användare> Användares { get; set; }
        public DbSet<Entity> Entitet { get; set; }
        public DbSet<Student> Studenter { get; set; }
        public DbSet<UtskicksLista> UtskicksListor { get; set; }
        public DbSet<Aktivitet> Aktiviteter { get; set; }
        public DbSet<Program> Programs { get; set; }

        

        public AppDbContext()
            : base("osu2014")
        {

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext,Migrations.Configuration>());
        }

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        */
       
        


    }
}
