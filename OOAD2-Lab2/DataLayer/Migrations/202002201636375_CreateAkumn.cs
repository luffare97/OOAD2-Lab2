namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAkumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumn",
                c => new
                {
                    Ort = c.String(),
                    Anställning = c.String(),
                    ExamensÅr = c.Int()
                });
                
        }
        
        public override void Down()
        {
        }
    }
}
