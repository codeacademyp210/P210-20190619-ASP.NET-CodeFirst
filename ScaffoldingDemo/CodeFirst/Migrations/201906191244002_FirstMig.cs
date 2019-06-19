namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Gender = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                        Rating = c.Single(nullable: false),
                        Budget = c.Decimal(precision: 18, scale: 2),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genre", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieActor",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Actor_Id })
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actor", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Actor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreID", "dbo.Genre");
            DropForeignKey("dbo.MovieActor", "Actor_Id", "dbo.Actor");
            DropForeignKey("dbo.MovieActor", "Movie_Id", "dbo.Movie");
            DropIndex("dbo.MovieActor", new[] { "Actor_Id" });
            DropIndex("dbo.MovieActor", new[] { "Movie_Id" });
            DropIndex("dbo.Movie", new[] { "GenreID" });
            DropTable("dbo.MovieActor");
            DropTable("dbo.Genre");
            DropTable("dbo.Movie");
            DropTable("dbo.Actor");
        }
    }
}
