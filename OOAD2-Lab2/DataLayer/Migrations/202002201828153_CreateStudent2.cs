namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudent2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Studenter",
                c => new
                {
                    AnvändarId = c.String(),
                    FNamn = c.String(),
                    ENamn = c.String(),
                    ID = c.Int(),
                    EMail = c.String(),
                    TeleNr = c.Int(),


                });
        }
        
        public override void Down()
        {
        }
    }
}
