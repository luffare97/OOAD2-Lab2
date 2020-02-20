namespace DataLayer.Migrations
{
    using System.Data.SqlClient;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AktivitetNamn = c.String(),
                        AktivitetId = c.Int(),
                        Start = c.DateTime(),
                        Slut = c.DateTime(),
                        AntalPlatser = c.Int(),
                        Plats = c.String(),
                        Beskrivning = c.String(),
                        AnvändarId = c.String(),
                        FNamn = c.String(),
                        ENamn = c.String(),
                        EMail = c.String(),
                        TeleNr = c.Int(),
                        Ort = c.String(),
                        Anställning = c.String(),
                        ExamensÅr = c.Int(),
                        År = c.Int(),
                        Possition = c.String(),
                        Information = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Program_ID = c.Int(),
                        Program_ID1 = c.Int(),
                        Program_ID2 = c.Int(),
                        Program_ID3 = c.Int(),
                        UtskicksLista_ID = c.Int(),
                        UtskicksLista_ID1 = c.Int(),
                        UtskicksLista_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Entities", t => t.Program_ID)
                .ForeignKey("dbo.Entities", t => t.Program_ID1)
                .ForeignKey("dbo.Entities", t => t.Program_ID2)
                .ForeignKey("dbo.Entities", t => t.Program_ID3)
                .ForeignKey("dbo.Entities", t => t.UtskicksLista_ID)
                .ForeignKey("dbo.Entities", t => t.UtskicksLista_ID1)
                .ForeignKey("dbo.Entities", t => t.UtskicksLista_ID2)
                .Index(t => t.Program_ID)
                .Index(t => t.Program_ID1)
                .Index(t => t.Program_ID2)
                .Index(t => t.Program_ID3)
                .Index(t => t.UtskicksLista_ID)
                .Index(t => t.UtskicksLista_ID1)
                .Index(t => t.UtskicksLista_ID2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entities", "UtskicksLista_ID2", "dbo.Entities");
            DropForeignKey("dbo.Entities", "UtskicksLista_ID1", "dbo.Entities");
            DropForeignKey("dbo.Entities", "UtskicksLista_ID", "dbo.Entities");
            DropForeignKey("dbo.Entities", "Program_ID3", "dbo.Entities");
            DropForeignKey("dbo.Entities", "Program_ID2", "dbo.Entities");
            DropForeignKey("dbo.Entities", "Program_ID1", "dbo.Entities");
            DropForeignKey("dbo.Entities", "Program_ID", "dbo.Entities");
            DropIndex("dbo.Entities", new[] { "UtskicksLista_ID2" });
            DropIndex("dbo.Entities", new[] { "UtskicksLista_ID1" });
            DropIndex("dbo.Entities", new[] { "UtskicksLista_ID" });
            DropIndex("dbo.Entities", new[] { "Program_ID3" });
            DropIndex("dbo.Entities", new[] { "Program_ID2" });
            DropIndex("dbo.Entities", new[] { "Program_ID1" });
            DropIndex("dbo.Entities", new[] { "Program_ID" });
            DropTable("dbo.Entities");
        }
    }
}
